#include <iostream> 
#include <algorithm> 
 
using namespace std; 
 
int CountNumbers(int arr[], int n) { 
    int count = 0; 
 
    sort(arr, arr + n);  
    for (int i = 0; i < n; i++) { 
        int target = 3 * arr[i+1] + 1; 
        int left = i + 1, right = n - 1; 
 
        while (left <= right) { 
            int mid = left + (right - left) / 2; 
 
            if (arr[mid] > target) { 
                right = mid - 1; 
            } 
            else { 
                left = mid + 1; 
            } 
        } 
 
        count += left - (i + 1); 
    } 
 
    return count; 
} 
 
int main() { 
    int n; 
    cin >> n; 
    int arr[n]; 
 
    for (int i = 0; i < n; i++) { 
        cin >> arr[i]; 
    } 
 
    int result = CountNumbers(arr, n); 
    cout << result << endl; 
 
    return 0; 
}