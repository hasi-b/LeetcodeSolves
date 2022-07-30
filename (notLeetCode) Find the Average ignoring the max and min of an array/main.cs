using System;

class Program {
  public static void Main (string[] args) {
    int[] arr = {6,3,8,4,7,5};
    int min = arr[0];
    int max = arr[0];
    float sum=0;

    for(int i =0;i<arr.Length;i++){
        if(arr[i]<=min){
          min =arr[i];
        }
      if(arr[i]>max){
        max = arr[i];
      }
      sum=sum+arr[i];


      
    }

    sum = sum-(max+min);
    sum= sum/(arr.Length-2);
    Console.WriteLine("Average: "+sum);

 
  }
}