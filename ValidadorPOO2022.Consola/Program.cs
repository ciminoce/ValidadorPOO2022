using System;
using ValidadorPOO2022.Entidades;

namespace ValidadorPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int valor;
            do
            {
                do
                {
                    Console.Write("Ingrese un valor");
                    valor = int.Parse(Console.ReadLine());
                } while (Validador.Validar(valor,-100,100));

                contador++;
                Sumador.Sumar(valor);
                Informador.ObtenerMayor(valor);
                Informador.ObtenerMenor(valor);
            } while (contador<10);

            Console.WriteLine($"Menor valor:{Informador.GetMenor()}");
            Console.WriteLine($"Mayor valor:{Informador.GetMayor()}");
            Console.WriteLine($"Promedio: {Sumador.GetSuma()/10}");
            Console.ReadLine();
        }
    }
}
