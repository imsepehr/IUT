#include <linux/module.h>
#include <linux/kernel.h>
#include <linux/fs.h>
#include <linux/uaccess.h>
#include <linux/random.h>
#include <linux/ioctl.h>

#define DEVICE_NAME "headset"
#define BUFFER_SIZE 100     
#define PRINT_THRESHOLD 5
#define VOLUME_MAX 100
#define VOLUME_MIN 0

#define IOCTL_MUTE _IO('H', 1)
#define IOCTL_UNMUTE _IO('H', 2)
#define IOCTL_SET_VOLUME _IOW('H', 3, int)
#define IOCTL_GET_VOLUME _IOR('H', 4, int)

MODULE_LICENSE("GPL");

static char kernel_buffer[BUFFER_SIZE];
static int buffer_pos = 0;
static int major_number;
static int is_device_open = 0; 
static int is_muted = 0;       
static int volume = 50;        

static ssize_t device_write(struct file *file, const char __user *user_buffer, size_t len, loff_t *offset) 
{
    if (volume == 0) {
        printk(KERN_INFO "Volume is 0, no sound played.\n");
        return len;
    }

    if (len > BUFFER_SIZE - buffer_pos)
        len = BUFFER_SIZE - buffer_pos;

    if (copy_from_user(kernel_buffer + buffer_pos, user_buffer, len) != 0)
        return -EFAULT;
    
    buffer_pos += len;
    
    if (buffer_pos >= PRINT_THRESHOLD) 
    {
        kernel_buffer[buffer_pos] = '\0';
        printk(KERN_INFO "Played sound at volume %d: %s\n", volume, kernel_buffer);
        buffer_pos = 0;
    }

    return len;
}

static ssize_t device_read(struct file *file, char __user *user_buffer, size_t len, loff_t *offset) 
{
    if (is_muted) {
        printk(KERN_INFO "Microphone is muted, returning empty buffer.\n");
        memset(kernel_buffer, 0, len);
        if (copy_to_user(user_buffer, kernel_buffer, len) != 0)
            return -EFAULT;
        return len;
    }

    char random_data[BUFFER_SIZE];
    if (len > BUFFER_SIZE) 
        len = BUFFER_SIZE;
    
    get_random_bytes(random_data, len);
    if (copy_to_user(user_buffer, random_data, len) != 0) 
        return -EFAULT;
    
    printk(KERN_INFO "Recorded sound and sent to user.\n");
    return len;
}

static long device_ioctl(struct file *file, unsigned int cmd, unsigned long arg)
{
    int user_value;
    switch (cmd) {
        case IOCTL_MUTE:
            is_muted = 1;
            printk(KERN_INFO "Microphone muted.\n");
            break;

        case IOCTL_UNMUTE:
            is_muted = 0;
            printk(KERN_INFO "Microphone unmuted.\n");
            break;

        case IOCTL_SET_VOLUME:
            if (copy_from_user(&user_value, (int __user *)arg, sizeof(user_value)))
                return -EFAULT;
            if (user_value < VOLUME_MIN || user_value > VOLUME_MAX) {
                printk(KERN_WARNING "Invalid volume value: %d\n", user_value);
                return -EINVAL;
            }
            volume = user_value;
            printk(KERN_INFO "Volume set to %d.\n", volume);
            break;

        case IOCTL_GET_VOLUME:
            if (copy_to_user((int __user *)arg, &volume, sizeof(volume)))
                return -EFAULT;
            printk(KERN_INFO "Volume retrieved: %d.\n", volume);
            break;

        default:
            return -EINVAL;
    }
    return 0;
}

static int device_open(struct inode *inode, struct file *file) 
{
    if (is_device_open) return -EBUSY;
    is_device_open++;
    try_module_get(THIS_MODULE);
    return 0;
}

static int device_release(struct inode *inode, struct file *file) 
{
    is_device_open--;
    module_put(THIS_MODULE);
    return 0;
}

static struct file_operations fops = 
{
    .open = device_open,
    .release = device_release,
    .write = device_write,
    .read = device_read,
    .unlocked_ioctl = device_ioctl,
};

static int __init headset_init(void) 
{
    major_number = register_chrdev(0, DEVICE_NAME, &fops);
    if (major_number < 0) 
    {
        printk(KERN_ALERT "Headset module failed with major number %d\n", major_number);
        return major_number;
    }
    printk(KERN_INFO "Headset module loaded with device major number %d\n", major_number);
    return 0;
}

static void __exit headset_exit(void) 
{
    unregister_chrdev(major_number, DEVICE_NAME);
    printk(KERN_INFO "Headset module unloaded.\n");
}

module_init(headset_init);
module_exit(headset_exit);
