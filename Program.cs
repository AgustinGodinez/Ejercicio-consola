using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Ejemplo_menu
{
    class Program
    {
        static void Main(string[] args)
        {
             
            bool salir = false;
 
            while (!salir) {
 
                try
                {
                     
                    Console.WriteLine("1. Crear claves");
                    Console.WriteLine("2. Cifrar archivo");
                    Console.WriteLine("3. Descifrar archivo");
                    Console.WriteLine("4. Exportar la clave publica");
                    Console.WriteLine("5. Importar la clave publica");
                    Console.WriteLine("6. Obtener la clave privada");
                    Console.WriteLine("7. Importar la clave publica");
                    Console.WriteLine("8. Firmar documento");
                    Console.WriteLine("9. Verificar firma de documento");
                    Console.WriteLine("10. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());
 
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            break;
 
                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            break;
 
                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Has elegido la opción 1");
                            break;
 
                        case 5:
                            Console.WriteLine("Has elegido la opción 2");
                            break;
 
                        case 6:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 7:
                            Console.WriteLine("Has elegido la opción 1");
                            break;
 
                        case 8:
                            Console.WriteLine("Has elegido la opción 2");
                            break;
 
                        case 9:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 10:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }
 
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
 
            Console.ReadLine();
 
        }
    }
}