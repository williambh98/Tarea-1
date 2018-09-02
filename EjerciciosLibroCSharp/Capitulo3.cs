using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Capitulo3
    {

        public void Menu2()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del cap#3");
            Console.WriteLine("\n1.Ejercicio1" +
                              "\n2.Ejercicio4" +
                              "\n3.Ejercicio5" +
                              "\n4.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Ejercicio1();
                    Console.Clear();
                    Me.Menu();
                    break;
                case 2:
                    {
                        Console.Clear();
                        Ejercicio4();
                        Console.Clear();
                        Me.Menu();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Ejercicio5();
                        Console.Clear();
                        Me.Menu();
                        break;
                    }
                case 4:
                    Console.Clear();

                    Me.Menu();
                    break;

            }
            Console.ReadKey();

        }

        public void Ejercicio1()
        {
            int num;
            Console.WriteLine("Determinar si un par o impar");
            Console.WriteLine("Digite un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Es un numero par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            string num = " ";
            Console.WriteLine("Digite un Numero Del 1 a 7");
            num = Console.ReadLine();
            switch (num)
            {
                case "1": Console.WriteLine("Lunes"); break;
                case "2": Console.WriteLine("Martes"); break;
                case "3": Console.WriteLine("Miercoles"); break;
                case "4": Console.WriteLine("Jueves"); break;
                case "5": Console.WriteLine("Viernes"); break;
                case "6": Console.WriteLine("Sabados"); break;
                case "7": Console.WriteLine("Domingo"); break;

            }

            Console.ReadKey();
        }
        public void Ejercicio5()
        {

            int op = 0;

            Console.WriteLine("Digite la operancion a realizar " +
                "\n1.Calcular el Area" +
                "\n2.Calcular perimetro\n"
                );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    float lado, longitud;
                    Console.WriteLine("Digite numero de lado:");
                    lado = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite la Longitud");
                    longitud = Convert.ToSingle(Console.ReadLine());
                    lado *= longitud / 2;
                    Console.WriteLine("El Area es:{0}", lado);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Digite numero de lado:");
                    lado = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite la Longitud");
                    longitud = Convert.ToSingle(Console.ReadLine());
                    lado *= longitud;
                    Console.WriteLine("El Area es:{0}", lado);
                    Console.ReadKey();
                    break;


            }
        }
    }

}
