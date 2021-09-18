using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    class FileProcessor
    {
        public string InputFilePath { get; set; }
    }

    public FileProceesser(string filepath)
    {
        InputFilePath = filepath;
    }
    
}