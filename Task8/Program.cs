bool is_even(float a){
    if (a % 2 == 0)
        return true;
    else
        return false;
};


int a;
Console.WriteLine("Please, input number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("All even numbers from 0 to {0}:", a);
for (int i=0;i<=a;i++){
    if (is_even(i)) Console.Write("{0} ", i);
}

