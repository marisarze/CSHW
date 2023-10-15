using System;

int[] ConvertToInt(string[] arr){
    int[] result = new int[arr.Length];
    for (int i=0;i<arr.Length;i++){
        result[i] = Convert.ToInt32(arr[i]);
    }
    return result; 
}



Console.WriteLine("Enter for equations y=k1*x+b1 and y=k2*x+b2 in one line");
Console.WriteLine("k1 b1 k2 b2:");
string text = Console.ReadLine();
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
string[] words = text.Split(delimiterChars);
int[] arr = ConvertToInt(words);
if (arr[0]==arr[2] && arr[1]==arr[3]){
    Console.Write("We have same lines, they are overlapped");
} else if (arr[0]==arr[2] && arr[1]!=arr[3]){
    Console.Write("These lines do not intersect (they intersect at infinity)");
} else {
    float x = (arr[3]-arr[1])/(arr[0]-arr[2]);
    float y = arr[0]*x + arr[1];
    Console.Write("Intersection at coordinates: ({0:##.##},{1:##.##})", x, y);
}



