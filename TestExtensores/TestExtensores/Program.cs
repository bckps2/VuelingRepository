using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtensores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Name= "";
            System.Diagnostics.Debug.Write(persona1.HasName()+"\n");
        }
    }
}
