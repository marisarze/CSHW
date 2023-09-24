float get_max(float a, float b){
    if (a>=b) {
        return a;        
    } 
    else {
        return b;
    }
};


void max_report(float a, float b, float c){
    Console.WriteLine("Maximal number is {0}", get_max(get_max(a,b),c)); 
};


float a = 0.0f, b = 0.0f, c = 0.0f;
Console.WriteLine("Please, input numbers");
Console.WriteLine("first number: ");
a = Single.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
b = Single.Parse(Console.ReadLine());
Console.WriteLine("third number: ");
c = Single.Parse(Console.ReadLine());
max_report(a, b, c);
