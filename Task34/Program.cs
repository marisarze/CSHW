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
    m[index] = rand.Next(100,1000);
}
OutputArray(m);

int count = 0;
for (int index=0;index<n;index++){
    if ((m[index] % 2)==0)
        count++;
}

Console.Write("The number of even numbers in the matrix is {0}", count);