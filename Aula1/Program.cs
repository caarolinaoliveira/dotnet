// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// int[] a = new int[] { 1, 2, 3, 4, 5 };
// System.Console.WriteLine(a);
// System.Console.WriteLine(string.Join(", ", a));

// List<int> b = new List<int> { 10, 20, 30, 40, 50 };
// System.Console.WriteLine(string.Join(", ", b)); 

void somaNumSemMult3() {
    int soma = 0;
    for (int i=1; i <=100; i++){
        if (i % 3 != 0){
            soma +=i;
            
        }
            System.Console.WriteLine(soma);
    }
}

somaNumSemMult3();