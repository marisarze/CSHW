void max_min_report(float a, float b){
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


float a = 0.0f, b = 0.0f;
Console.WriteLine("Please, input numbers");
Console.WriteLine("first number: ");
a = Single.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
b = Single.Parse(Console.ReadLine());
max_min_report(a, b);

