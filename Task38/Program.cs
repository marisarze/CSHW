using System;

void OutputArray(float[] input){
    Console.Write("[");
    for (int index=0;index<input.Length;index++){
        if (index!=input.Length-1)
            Console.Write("{0:##.##}, ", input[index]);
        else
            Console.Write("{0:##.##}", input[index]);
    }
    Console.WriteLine("]");
};

float GetMax(float[] input){
    float result = input[0];
    for (int index=1;index<input.Length;index++){
        if (input[index]>result) result = input[index];
    }
    return result;
}

float GetMin(float[] input){
    float result = input[0];
    for (int index=1;index<input.Length;index++){
        if (input[index]<result) result = input[index];
    }
    return result;
}


Console.WriteLine("Enter length of the sequence:");
int n = Convert.ToInt32(Console.ReadLine());

var rand = new Random();
float[] m = new float[n];
for (int index=0;index<n;index++){
    m[index] = (float)(rand.NextDouble() * 100);
}
OutputArray(m);

float difference = GetMax(m) - GetMin(m);

Console.Write("Difference between max and min value of the matrix is {0:##.##}", difference);