/*
 * Problem 1. Odd lines
Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        //win.ini file was copied in the \bin\Debug folder of the current project "01. Odd Lines"
        string fileName = "win.ini";

        try
        {
            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {
                int lineNumber = 0;
                //Read first line form the text file
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    lineNumber += 2;
                    line = reader.ReadLine(); line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine(
            "Can not find file {0}.", fileName);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine(
            "Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
            "Can not open the file {0}", fileName);
        }
    }
}