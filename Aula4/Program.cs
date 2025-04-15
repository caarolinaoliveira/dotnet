// See https://aka.ms/new-console-template for more information
//fibonacci com lista 


public class Program{
   
   static void Main (){
    fibonacci(10);
   }

   static void fibonacci(int n){
    List<int> fib = [0,1];
    for (int i =2; i <n; i++ )
    {
        fib.Add(fib[i-1] + fib[i-2]);
    }
    foreach(int num in fib){
        System.Console.WriteLine(num);
    }
   }
}


