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

            string[] lines =
            {
                "Este es un nuevo texto",
                "Hola",
                "Bonito dia :)"
            };

            //Recorrer archivo para escribir las lineas en el archivo
            foreach(string line in lines)
            {
                //escribir en el archivo
                sw.WriteLine(line);
            }

            //Cerrar archivo
            sw.Close();

            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    }
}
