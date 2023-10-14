using System;

void OutputArray(int[] input){
    for (int index=0;index<input.Length;index++){
        if (index!=input.Length-1)
            Console.Write("{0}, ", input[index]);
        else
            Console.Write("{0}", input[index]);
    }
    Console.Write(" -> [");
    for (int index=0;index<input.Length;index++){
        if (index!=input.Length-1)
            Console.Write("{0}, ", input[index]);
        else
            Console.Write("{0}", input[index]);
    }
    Console.WriteLine("]");
};


Console.WriteLine("Enter length of the sequence:");
int n = Convert.ToInt32(Console.ReadLine());

var rand = new Random();
int[] m = new int[n];
for (int index=0;index<n;index++){
    m[index] = rand.Next(100);
}
OutputArray(m);

int sum = 0;
for (int index=0;index<n;index++){
    if ((index % 2) !=0)
        sum = sum + m[index];
}

Console.Write("The elements sum on even indexes of the matrix is {0}", sum);