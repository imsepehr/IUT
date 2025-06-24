#include<stdio.h>
#include <stdlib.h>

int count_numbers(int *arr, int size);

int main()
{
    int *arr;
    int size;
    scanf("%d",&size);
    arr = (int *) malloc(sizeof(int) * size);

    for (int i = 0; i < size; i++)
    {
        scanf("%d", &arr[i]);
    }

    printf("%d\n",count_numbers(arr,size));

    return 0;
}

int count_numbers(int *arr, int size)
{
    int count = 0;
    for (int i = 0; i < size-1; i++)
    {
        for (int j=i+1; j<size; j++)
        {
            if (arr[i] > 3 * arr[j] + 1)
            {
                count++;
            }
        }
    }
    return count;

}
