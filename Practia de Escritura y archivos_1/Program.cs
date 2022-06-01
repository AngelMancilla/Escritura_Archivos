using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practia_de_Escritura_y_archivos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion del archivo
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);

            //Pide el nombre y lo guarda en una variable
            Console.Write("Introduce tu nombre: ");
            string line = Console.ReadLine();

            //Escribe en el archivo
            sw.WriteLine(line);

            //Cerrar archivo
            sw.Close();

            Console.WriteLine("Listo :)");
            Console.ReadLine();
        }
    }
}
