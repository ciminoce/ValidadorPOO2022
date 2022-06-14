using System;

namespace ValidadorPOO2022.Entidades
{
    public static class Validador
    {
        /// <summary>
        /// Valida si un valor se encuentra comprendida en un rango dado
        /// </summary>
        /// <param name="valor">valor a cotejar</param>
        /// <param name="min">menor valor del rango</param>
        /// <param name="max">mayor valor del rango</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        public static bool Validar(string palabra, int min, int max)
        {
            return palabra.Length >= min && palabra.Length <= max;
        }
    }
}
