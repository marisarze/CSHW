using System;

int SumDigits(int a){
    int result = 0;
    int temp = Math.Abs(a);
    while (temp>0){
        result += temp % 10;
        temp /= 10;
    }
    return result;
};


int a = 0;
Console.WriteLine("Please, input number");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Sum of digits of {0} is {1}", a, SumDigits(a));