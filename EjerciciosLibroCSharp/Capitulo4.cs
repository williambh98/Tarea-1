using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Capitulo4
    {
        public void Menu3()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del Cap#4");
            Console.WriteLine("\n1.Ejercicio1" +
                              "\n2.Ejercicio2" +
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
                        Ejercicio2();
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

            int nun1 = 10, num2 = 10;
            int x = 0, i = 0;

            Console.WriteLine("Tabla de Multiplicacion del 1 a 10");

            for (; i < nun1; i++)
            {
                for (; x < num2; x++)
                    Console.WriteLine("{0}*{1}={2}", i + 1, x + 1, i + 1 * x + 1);


            }

            Console.ReadKey();

        }

        public void Ejercicio2()
        {
            int num, pot;
            Console.WriteLine("Digite el numero a elevar a cual quier potencia:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Potencia a elevar: ");
            pot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado elevado es: " + Math.Pow(num, pot));
            Console.ReadKey();

        }

        public void Ejercicio5()
        {
            {
                int tam, cont = 0, edad;
                Console.WriteLine("Digite el numero de persona del grupo: ");
                tam = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[tam];

                for (int i = 0; i < tam; i++)
                {
                    Console.Write("Edad de la Persona{0}:", (i + 1));
                    edad = Convert.ToInt32(Console.ReadLine());
                    cont += edad;
                    arr[i] = edad;
                }

                Console.WriteLine("Edad Promedio: " + cont / tam);

                int Mayor = 0;

                for (int i = 0; i < tam; i++)
                {
                    if (arr[i] > Mayor)
                    {
                        Mayor = arr[i];
                    }
                }

                int Menor = Mayor;
                for (int i = 0; i < tam; i++)
                {
                    if (arr[i] < Menor)
                    {
                        Menor = arr[i];
                    }
                }

                Console.WriteLine("La Persona Mayor Tiene una edad: " + Mayor);
                Console.WriteLine("La PersonaMenor tiene una edad: " + Menor);
                Console.ReadKey();
            }




        }


    }
}
