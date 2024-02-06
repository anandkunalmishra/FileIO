using System;
using System.IO;
namespace File
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string path = @"/Users/anandkunalmishra/Desktop/untitled folder/file.txt";
            //string input = @"/Users/anandkunalmishra/Desktop/untitled folder/input.txt";
            string output = @"/Users/anandkunalmishra/Desktop/untitled folder/output.txt";


            string csvFile = @"/Users/anandkunalmishra/Downloads/Contacts.csv";
            Dictionary<int,string> label= new Dictionary<int,string>();
            using (StreamReader reader= new StreamReader(csvFile))
            {
                using(StreamWriter writer = new StreamWriter(output))
                {
                    string line;
                    int counter = 0;

                    int labelCounter = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string [] words = line.Split(',');
                        counter++;
                        if (counter == 1)
                        {
                            foreach(var word in words)
                            {
                                label.Add(labelCounter,word);
                                labelCounter++;
                            }
                        }
                        else
                        {
                            labelCounter = 0;
                            foreach (var word in words)
                            {
                                writer.Write(label[labelCounter] + " : " + word + ", ");
                                labelCounter++;
                            }
                            writer.WriteLine();
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
