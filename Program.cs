using System;
using System.IO;
namespace File
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string path = @"/Users/anandkunalmishra/Desktop/untitled folder/file.txt";
            string input = @"/Users/anandkunalmishra/Desktop/untitled folder/input.txt";
            string output = @"/Users/anandkunalmishra/Desktop/untitled folder/output.txt";

            using (StreamReader reader= new StreamReader(input))
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    string[] arr = reader.ReadLine().Split();
                    int x = int.Parse(arr[0]);
                    int y = int.Parse(arr[1]);

                    writer.WriteLine(x+y);
                }
            }
            Console.ReadLine();
        }
    }
}
