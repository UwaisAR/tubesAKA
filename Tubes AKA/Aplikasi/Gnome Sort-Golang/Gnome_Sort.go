package main

import "fmt"

func main(){
	var arr[100] int
	var temp, index, n, i int
	n = 0
	for(n <= 8){
		fmt.Print("Masukan angka : "," ")
		fmt.Scan(&arr[n])
		n = n + 1
	}
	index = 0 
	for(index < n){
		if(index == 0){
			index = index + 1
		}
		if(arr[index] <= arr[index-1]){
			index = index + 1
		}else{
			temp = arr[index]
			arr[index] = arr[index-1]
			arr[index-1] = temp
			index = index - 1 
		}
	}
	i = 0
	for(i <= n){
		fmt.Println(arr[i])
		i = i + 1
	}

}
