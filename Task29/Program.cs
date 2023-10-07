using System;

int[] RandomEight(){
    var rand = new Random();
    int[] result = new int[8];
    for (int index=0;index<result.Length;index++){
        result[index] = rand.Next(100);
    }
    return result;  
};

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


int[] eightNumbers = RandomEight();
OutputArray(eightNumbers);
