using System;

int CountPositive(int[] arr){
    int count = 0;
    for (int i=0;i<arr.Length;i++){
        if (arr[i]>0) count++;
    }
    return count;
};

int[] ConvertToInt(string[] arr){
    int[] result = new int[arr.Length];
    for (int i=0;i<arr.Length;i++){
        result[i] = Convert.ToInt32(arr[i]);
    }
    return result; 
}



Console.WriteLine("Enter numbers with same separator in one line:");
string text = Console.ReadLine();

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
string[] words = text.Split(delimiterChars);
int[] arr = ConvertToInt(words);
int count = CountPositive(arr);

Console.Write("Positive number count is {0}", count);


