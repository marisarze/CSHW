using System;

int GetSumBetween(int M, int N){
    if (M==N){
        return M;
    } else if (M>N){
        return M + GetSumBetween(M-1, N);
    } else {
        return N + GetSumBetween(M, N-1);
    }
}


Console.WriteLine("Enter number M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of all numbers from {0} to {1} is {2}", M, N, GetSumBetween(M,N));