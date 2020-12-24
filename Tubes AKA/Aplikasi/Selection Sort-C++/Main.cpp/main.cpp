#include <iostream>

using namespace std;

int main()
{
    int n, k, j, i, max, temp;
    string con;
    int arr[10];
    i = 0;
    cout<<"Masukan Jumlah Data : "<<endl;
    cin>>n;
    k = 0;
    while(k < n){
        cout<<"Masukan angka : "<<endl;
        cin>>arr[k];
        k = k + 1;
    }
    while(i <= k){
        j = i;
        max = i;
        while(j <= k){
            if(arr[max] < arr[j]){
                max = j;
            }
            j = j + 1;
        }
        temp = arr[max];
        arr[max] = arr[i];
        arr[i] = temp;
        i = i + 1;
    }
    i = 1;
    cout<<" "<<endl;
    while(i <= k){
        cout<<arr[i]<<endl;
        i = i + 1;
    }

    return 0;
}
