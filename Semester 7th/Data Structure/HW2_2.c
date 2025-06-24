#include<stdio.h>
#include <stdlib.h>


//int count_numbers(int *arr, int size);
//int *quick_sort(int *arr, int size);
void print_array(int *arr,int size);
int *quicksort(int *arr,int first,int last);
int binarySearch(int *arr, int left, int right, int target);
int countNumbers(int *arr, int n);

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

    //print_array(arr,size);

    //printf("%d\n",count_numbers(arr,size));

    arr = quicksort(arr,0,size - 1);
    //print_array(arr,size);

    int result = countNumbers(arr, size);
    printf("%d\n", result);

    free(arr); 

    return 0;
}

// int count_numbers(int *arr, int size)
// {
//     int count = 0;
//     for (int i = 0; i < size-1; i++)
//     {
//         for (int j=i+1; j<size; j++)
//         {
//             if (arr[i] > 3 * arr[j] + 1)
//             {
//                 count++;
//             }
//         }
//     }
//     return count;

// }


// int *quick_sort(int *arr, int size)
// {
//     for (int i = 0; i < size - 1; i++) {
//         for (int j = i + 1; j < size; j++) {
//             if (arr[i] > arr[j]) {
//                 int temp = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = temp;
//             }
//         }
//     }
//     return arr;
// }

void print_array(int *arr, int size)
{
    printf("["); // [
    for (int i = 0; i < size - 1; i++) 
    {   // [1, 2, 3, 4, 
        printf("%i, ", arr[i]);
    }
    if (size >= 1) printf("%i", arr[size-1]); 
    printf("]\n");
}


int *quicksort(int *arr,int first,int last){
   int i, j, pivot, temp;
   if(first<last){
      pivot=first;
      i=first;
      j=last;
      while(i<j){
         while(arr[i]<=arr[pivot]&&i<last)
         i++;
         while(arr[j]>arr[pivot])
         j--;
         if(i<j){
            temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
         }
      }
      temp=arr[pivot];
      arr[pivot]=arr[j];
      arr[j]=temp;
      quicksort(arr,first,j-1);
      quicksort(arr,j+1,last);
   }
   return arr;
}

int binarySearch(int arr[], int left, int right, int target) {
    while (left <= right) {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) {
            return 1;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    return 0;
}


int countNumbers(int *arr, int n) {
    int count = 0;
    for (int i = 0; i < n; i++) 
    {
        for (int j = i+1; j < n; j++)
        {
            int num = arr[i];
            int target = num * 3 + 1;
            if (binarySearch(arr, 0, n - 1, target))
                count++;
        }
    }
    return count;
}