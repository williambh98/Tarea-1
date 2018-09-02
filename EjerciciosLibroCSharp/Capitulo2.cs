using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Capitulo2
    {
        public void ejercicio1()
        {
            Console.WriteLine(" Calcular el perímetro  Polígono .\n");
            int lado = 4, p, log = 4;
            p = lado * log;
            Console.WriteLine("El perimetro es:" + p);
            Console.ReadKey();
        }

        public void ejercicio3()
        {
            float gr, rad;
            Console.WriteLine("Convertir de grado a radianes");
            gr = Convert.ToSingle(Console.ReadLine());
            rad = gr * ((float)Math.PI / 180);
            Console.WriteLine("Los radianes son:{0}", rad);
            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            float temp;
            Console.WriteLine("transformar de grados centíg a grad Fahrenheit.");
            Console.WriteLine("Digite la temperatura");
            temp = Convert.ToSingle(Console.ReadLine());
            temp = (temp * 1.8F) + 32;
            Console.WriteLine("La Temperatura en grado F es:" + temp);
            Console.ReadKey();
        }

        public void Ejercicio5()
        {
            float dolar, eur, cambio;
            Console.WriteLine("Cambio de dolar a euro ");
            Console.WriteLine("Cantidad de dolar");
            dolar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Cambio del dia");
            cambio = Convert.ToSingle(Console.ReadLine());
            eur = dolar * cambio;
            Console.WriteLine("Cambio de dolar a euro es:{0}", eur);
            Console.ReadKey();

        }
    }

}
