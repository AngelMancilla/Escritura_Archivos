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
            StreamWriter sw = new StreamWriter("Alumnos.txt", true);

            try
            { //Pide datos del alumno y lo guarda en su respectivo variable
                Console.Write("\nIntroduce tu nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("\nIntroduce tu edad: ");
                int edad = Int32.Parse(Console.ReadLine());
                Console.Write("\nIntroduce tu carrera: ");
                string carrera = Console.ReadLine();

                //Escribe en el archivo
                sw.WriteLine(nombre + ", " + edad + " años, " + carrera);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Cerrar archivo
            sw.Close();

            Console.WriteLine("Listo :)");
            Console.ReadLine();
        }
    }
}
