public class Solution {
    public double Average(int[] salary) {
        
        int max =  salary[0];
        int min = salary[0];
        int sum =0;
        
        
        
        for(int i=0;i<salary.Length;i++){
            
            
            if(salary[i]>max){
                max = salary[i];
            }
            if(salary[i]<min){
                min = salary[i];
            }
            
            sum = sum+salary[i];
            
        }
        
        
        double avg = (sum-(max+min))/(salary.Length-2.0);
        return avg;
        
        
        
    }
}