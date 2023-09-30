
int GetSecondDigit(int number){
    int firstTwoDigits = number / 10;
    int secondDigit = firstTwoDigits % 10;
    return secondDigit;
};


int a;
Console.WriteLine("Please, input number");
a = Convert.ToInt32(Console.ReadLine());
int secondDigit = GetSecondDigit(a);
Console.WriteLine("Second digit is : {0}", secondDigit);
