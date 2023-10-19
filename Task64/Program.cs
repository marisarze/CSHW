using System;

void PrintNaturalNumbers(int n){
    if (n!=1){
        Console.Write($"{n}, ");
        PrintNaturalNumbers(n-1);
    } else {
        Console.WriteLine("1");
    }
}


Console.WriteLine("Enter number N:");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(n);
