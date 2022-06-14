namespace ValidadorPOO2022.Entidades
{
    public static class Sumador
    {
        private static int suma = 0;
        public static void Sumar(int valor)
        {
            suma += valor;
        }
        public static int GetSuma()
        {
            return suma;
        }
    }
}
