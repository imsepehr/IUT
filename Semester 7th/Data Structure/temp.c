#include <stdio.h> 
#include <stdlib.h> 

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

void merge(int arr[], int l, int m, int r) 
{ 
    int i, j, k; 
    int n1 = m - l + 1; 
    int n2 = r - m; 
  
    int L[n1], R[n2]; 

      
  
    for (i = 0; i < n1; i++) 
        L[i] = arr[l + i]; 
    for (j = 0; j < n2; j++) 
        R[j] = arr[m + 1 + j]; 

   
  
    i = 0; 
    j = 0; 
    k = l; 
    while (i < n1 && j < n2) { 
        if (L[i] <= R[j]) { 
            arr[k] = L[i]; 
            i++; 
        } 
        else { 
            arr[k] = R[j]; 
            j++; 
        } 
        k++; 
    } 
  
    while (i < n1) { 
        arr[k] = L[i]; 
        i++; 
        k++; 
    } 

    while (j < n2) { 
        arr[k] = R[j]; 
        j++; 
        k++; 
    } 

     /////////////////////////////

    int left=l,right=r;
    int counter = 0;

    while (left >= 0 && right >=0) 
    {
        if (L[left] > (3 * R[right]) + 1)
        {
            counter += right + 1;
            --left;
        }
        else 
        {
            --right;
        }
    }
    printf("counter: %d\n", counter);

  /////////////////////////////








} 
  

void mergeSort(int arr[], int l, int r) 
{ 
    if (l < r) { 
        
        int m = l + (r - l) / 2; 
        mergeSort(arr, l, m); 
        mergeSort(arr, m + 1, r); 
        merge(arr, l, m, r); 
    } 
} 


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

    mergeSort(arr, 0, size -1);
     
    print_array(arr,size);

    return 0;
}