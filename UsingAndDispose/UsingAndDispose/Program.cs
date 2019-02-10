using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAndDispose
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejemplo de utilizacion USING
            Char[] buffer = new Char[50];
            using (StreamReader reader = new StreamReader("File1.txt")) {
                 int charRead = 0;
                while (reader.Peek() != -1) {
                charRead = reader.Read(buffer, 0, buffer.Length);
           
                }

            }

            //ejemplo de utilizaion de Dispose.
            StreamReader sReader = null;
              try {
                 sReader = new StreamReader("file1.txt");
                 String text= sReader.ReadToEnd(); 
              }      
              finally {
                 if (sReader != null) sReader.Dispose();     
              }
        }
    }
}

    
