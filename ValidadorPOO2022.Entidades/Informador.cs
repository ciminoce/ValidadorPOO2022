namespace ValidadorPOO2022.Entidades
{
    public static class Informador
    {
        private static int minimo = int.MaxValue;
        private static int maximo = int.MinValue;

        public static void ObtenerMenor(int valor)
        {
            if (valor<minimo)
            {
                minimo = valor;
            }
        }
        public static void ObtenerMayor(int valor)
        {
            if (valor>maximo)
            {
                maximo = valor;
            }
        }
        public static int GetMayor()
        {
            return maximo;
        }
        public static int GetMenor()
        {
            return minimo;
        }
    }
}
