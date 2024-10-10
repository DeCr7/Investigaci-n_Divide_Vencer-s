using System;
    public class AplicacionPractica
    {
    static int[] facturas = new int[1000];
    static string[] fecha = new string[1000];
    static double[] total = new double[1000];
    static double[] galloPintoFactura = new double[1000];
    static double[] nacatamalFactura = new double[1000];
    static double[] vigoronFactura = new double[1000];
    static double[] bahoFactura = new double[1000];
    static double[] carneAsadaFactura = new double[1000];
    static double[] indioViejoFactura = new double[1000];
    static double[] quesilloFactura = new double[1000];
    static double[] sopaMondongoFactura = new double[1000];
    static double[] tajadasCarneFactura = new double[1000];
    static double[] sopaGallinaFactura = new double[1000];
    static double[] tostonesQuesoFactura = new double[1000];
    static double[] arrozValencianaFactura = new double[1000];
    static double[] chicharronYucaFactura = new double[1000];
    static double[] ensaladaRepolloFactura = new double[1000];
    static double[] tajadasQuesoFactura = new double[1000];
    static double galloPinto = 91.25;
    static double nacatamal = 91.25;
    static double vigoron = 100.38;
    static double baho = 164.25;
    static double carneAsada = 182.5;
    static double indioViejo = 127.75;
    static double quesillo = 73;
    static double sopaMondongo = 146;
    static double tajadasCarne = 136.88;
    static double sopaGallina = 136.88;
    static double tostonesQueso = 82.12;
    static double arrozValenciana = 146;
    static double chicharronYuca = 127.75;
    static double ensaladaRepollo = 54.75;
    static double tajadasQueso = 100.38;
    public static void Main(string[] args)
        {
        int op;
        do
        {
            Console.WriteLine("\n-MENÚ-\n");
            Console.WriteLine("Gallo Pinto – C$91.25");
            Console.WriteLine("Nacatamal – C$109.50");
            Console.WriteLine("Vigorón – C$100.38");
            Console.WriteLine("Baho – C$164.25");
            Console.WriteLine("Carne Asada – C$182.50");
            Console.WriteLine("Indio Viejo – C$127.75");
            Console.WriteLine("Quesillo – C$73.00");
            Console.WriteLine("Sopa de Mondongo – C$146.00");
            Console.WriteLine("Tajadas con Carne – C$136.88");
            Console.WriteLine("Sopa de Gallina – C$173.38");
            Console.WriteLine("Tostones con Queso – C$82.12");
            Console.WriteLine("Arroz a la Valenciana – C$146.00");
            Console.WriteLine("Chicharrón con Yuca – C$127.75");
            Console.WriteLine("Ensalada de Repollo – C$54.75");
            Console.WriteLine("Tajadas con Queso – C$100.38\n");
            Console.Write("Elija una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: CrearFactura(); break;
                case 2: EliminarFactura(); break;
                case 3: BuscarFactura(); break;
                case 4: MostrarFacturas(); break;
                case 5: Console.WriteLine("¡Adiós!"); break;
                default: Console.WriteLine("Opción inválida, vuelva a intentarlo."); break;
            }
        }
        while (op != 5);
    }
    public static void CrearFactura() //Dennis
    {

    }
    public static void EliminarFactura() //Enoc
    {

    }
    public static void BuscarFactura() //Josué
    {

    }
    public static void MostrarFacturas() //Josué
    {

    }
}