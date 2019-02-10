using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este codigo representa un boxing Quiere decir que pasamos 
            //una variable tipo int a un objeto
            int Number = 2;
            Object O = Number;
            System.Diagnostics.Debug.Write(O);

            //Este codigo realiza el unboxing quiere decir que pasamos un objeto a variable tipo int
            O = 456;
            Number = (int)O;
            System.Diagnostics.Debug.Write(Number);
        }
    }
}
