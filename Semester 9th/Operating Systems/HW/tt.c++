#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>

int main ()
{

    pid_t pid1, pid2, pid3;
    pid1 = fork();
    wait();
    pid2 = fork();

    if (pid1 == 0 or pid2==0)
    {
        printf("new child process");
    }

    pid3 = fork();
    printf("End of the process");
}