void report_is_even(float a){
    if (a % 2 == 0){
        Console.WriteLine("Number {0} is even", a);
    } else {
        Console.WriteLine("Number {0} is is odd", a);
    }
};


float a = 0.0f;
Console.WriteLine("Please, input number");
a = Single.Parse(Console.ReadLine());
report_is_even(a);