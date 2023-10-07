using System;

int Powered(int A, int B){
    int result = 1;
    for (int i=1; i<=B; i++){
        result *= A;
    }
    return result;
};


int A, B;
Console.WriteLine("Please, input number A: ");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input number B: ");
B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the result of A^B or {0}^{1} is {2}", A,B,Powered(A,B));