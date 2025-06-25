#include <stdio.h>
#include <fcntl.h>
#include <unistd.h>
#include <string.h>
#include <errno.h>
#include <stdlib.h>
#include <sys/ioctl.h>

#define DEVICE_PATH "/dev/headset"
#define IOCTL_MUTE _IO('H', 1)
#define IOCTL_UNMUTE _IO('H', 2)
#define IOCTL_SET_VOLUME _IOW('H', 3, int)
#define IOCTL_GET_VOLUME _IOR('H', 4, int)
#define BUFFER_SIZE 128

int main() {
    int fd = open(DEVICE_PATH, O_RDWR);
    if (fd < 0) {
        perror("Failed to open the headset");
        return errno;
    }

    const char *messages[] = {"Sepehr Ebadi", "Test 2", "Copmuter Engineering Programmer in IUT aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"};
    int read_sizes[] = {16, 32, 64};

    for (int i = 0; i < 3; i++) {
        printf("Writing to headset: %s\n", messages[i]);
        if (write(fd, messages[i], strlen(messages[i])) < 0) {
            perror("Failed to write to the headset");
        }

        if (i == 0) {
            printf("Setting volume to 0 (mute sound)...\n");
            int volume = 0;
            ioctl(fd, IOCTL_SET_VOLUME, &volume);
        } else if (i == 1) {
            printf("Setting volume to 50...\n");
            int volume = 50;
            ioctl(fd, IOCTL_SET_VOLUME, &volume);
        }
    }

    for (int i = 0; i < 3; i++) {
        char read_data[BUFFER_SIZE] = {0};
        printf("Reading %d bytes from headset...\n", read_sizes[i]);
        if (read(fd, read_data, read_sizes[i]) < 0) {
            perror("Failed to read from the headset");
        } else {
            printf("Data read: ");
            for (int j = 0; j < read_sizes[i]; j++) {
                printf("%02x ", (unsigned char)read_data[j]);
            }
            printf("\n");
        }

        if (i == 0) {
            printf("Muting microphone...\n");
            ioctl(fd, IOCTL_MUTE);
        } else if (i == 1) {
            printf("Unmuting microphone...\n");
            ioctl(fd, IOCTL_UNMUTE);
        }
    }

    close(fd);
    return 0;
}
