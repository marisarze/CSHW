void max_min_report(float a, float b){
    if (a>b) {
        Console.WriteLine("Number {0} greater than number {1}", a, b);        
    } 
    else if (a<b) 
    {
        Console.WriteLine("Number {0} greater than number {1}", b, a);
    } 
    else 
    {
        Console.WriteLine("Number {0} equal to number {1}", a, b);
    };
};


float a = 0.0f, b = 0.0f;
Console.WriteLine("Please, input numbers");
Console.WriteLine("first number: ");
a = Single.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
b = Single.Parse(Console.ReadLine());
max_min_report(a, b);

