using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program me = new Program();
            me.Menu();
        }

        public void Menu()
        {
            Capitulo1 obj = new Capitulo1();
            Capitulo2 cap2 = new Capitulo2();
            Capitulo3 cap3 = new Capitulo3();
            Capitulo4 cap4 = new Capitulo4();

            int op = 0, opc = 0;
            string valor = "";
            //Menu

            Console.WriteLine("Eliga una opcion para ver lo ejercicio del capitulo \n" +
                "\n1.Capitulo1" +
                "\n2.Capitulo2" +
                "\n3.Capitulo3" +
                "\n4.Capitulo4" +
                "\n5.Salir\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Elige un ejercicio del cap#1\n" +
                        "\n1.Ejercicio 1" +
                        "\n2.Ejercicio 5" +
                        "\n3.Volver al menu\n");
                    valor = Console.ReadLine();
                    opc = Convert.ToInt32(valor);
                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            obj.Ejercicio1(); break;

                        case 2:
                            obj.Ejercicio5(); break;
                        case 3:
                            Menu();
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Elige un ejercicio del Cap#20\n" +
                        "\n1.Ejercicio 1" +
                        "\n2.Ejercicio 3" +
                        "\n3.Ejercicio 4" +
                        "\n4.Ejercicio 5" +
                        "\n5.Volver al menu\n");
                    valor = Console.ReadLine();
                    opc = Convert.ToInt32(valor);

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            cap2.ejercicio1(); break;

                        case 2:
                            Console.Clear();
                            cap2.ejercicio3(); break;
                        case 3:
                            Console.Clear();
                            cap2.Ejercicio4(); break;
                        case 4:
                            Console.Clear();
                            cap2.Ejercicio5(); break;
                        case 5:
                            Console.Clear();
                            Menu();
                            break;
                    }
                    break;

                case 3:
                    cap3.Menu2();

                    break;
                case 4:
                    cap4.Menu3();

                    break;
                case 5:
                    Console.WriteLine("Opcion salir\n" +
                        "Preciones Cual Quier tecla para salir");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;


            }

            Console.ReadKey();


        }

    }

}




