using System;
using System.IO;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\";
            var dir = new FileProcessor();

            dir.readDir(filePath);
         
           

 
        }
    }


    public class FileProcessor { 

       public void readDir(string filePath)
        {
            var dir = Directory.GetDirectories(filePath);

            foreach(var x in dir)
            {
                Console.WriteLine("Processed" +x);
            }

        }
       

    }
}
