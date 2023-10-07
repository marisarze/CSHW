void MaxMinReport(int a, int b){
    if (a>b) {
        Console.WriteLine("First number {0} is greater than second number {1}", a, b);        
    } 
    else if (a<b) 
    {
        Console.WriteLine("First number {0} is greater than second number {1}", a, b);
    } 
    else 
    {
        Console.WriteLine("First number {0} is equal to second number {1}", a, b);
    };
};


int a = 0, b = 0;
Console.WriteLine("Please, input numbers");
Console.WriteLine("first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("second number: ");
b = Convert.ToInt32(Console.ReadLine());
MaxMinReport(a, b);

