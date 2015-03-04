/*
 * Problem 2. Concatenate text files
Write a program that concatenates two text files into another text file.
 */

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        //string fileName1 = "win.txt";
        //string fileName2 = "win.txt";
        //string fileName3 = "Result.txt";
        Console.WriteLine("Please eneter the path of the first file:");
        string fileName1 = Console.ReadLine();
        Console.WriteLine("Please eneter the path of the second file:");
        string fileName2 = Console.ReadLine();
        //The resultant file will be in the current directory
        string fileName3 = "Result.txt";
        try
        {
            StreamReader reader1 = new StreamReader(fileName1, Encoding.GetEncoding("UTF-8"));
            StreamWriter writer1 = new StreamWriter(fileName3, false,  Encoding.GetEncoding("UTF-8"));
            using (reader1)
            {
                using (writer1)
                {
                    string line;
                    while((line = reader1.ReadLine()) != null)
                    {
                        writer1.WriteLine(line);
                    }
                }
            }
            StreamReader reader2 = new StreamReader(fileName2, Encoding.GetEncoding("UTF-8"));
            StreamWriter writer2 = new StreamWriter(fileName3, true, Encoding.GetEncoding("UTF-8"));
            using (reader1)
            {
                using (writer2)
                {
                    string line;
                    while ((line = reader2.ReadLine()) != null)
                    {
                        writer2.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can not find file.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine(
            "Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can not open the file.");
        }
    }
}