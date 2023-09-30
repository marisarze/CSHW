using System;

int GetThirdDigit(int number){
    int target = -1;
    number = Math.Abs(number);
    while (number / 100 > 0){
        target = number % 10;
        number = number / 10;
    }
    return target;
};


int a;
Console.WriteLine("Please, input number");
a = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(a);
if (thirdDigit!=-1)
    Console.WriteLine("Third digit is : {0}", thirdDigit);
else
    Console.WriteLine("Third digit doesn't exist");
