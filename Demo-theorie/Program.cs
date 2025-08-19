namespace Demo_theorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 5;
            int? nombreNullable;

            object monNombre = nombre;
            int monNombreUmboxe = (int)monNombre;

            if (nombre is int)
            {
                Console.WriteLine("C'est un nombre");
            }

            switch (nombre)
            {
                case 1:
                    break;
                //case int:
                //    break;
                case int i:
                    break;
            }
        }
    }
}
