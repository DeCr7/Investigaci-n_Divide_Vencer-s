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
    static int facturaActual = 0;
    public static void Main(string[] args)
    {
        int op;
        do
        {
            Console.WriteLine("\n-MENÚ-\n");
            Console.WriteLine("(1) Gallo Pinto – C$91.25");
            Console.WriteLine("(2) Nacatamal – C$109.50");
            Console.WriteLine("(3) Vigorón – C$100.38");
            Console.WriteLine("(4) Baho – C$164.25");
            Console.WriteLine("(5) Carne Asada – C$182.50");
            Console.WriteLine("(6) Indio Viejo – C$127.75");
            Console.WriteLine("(7) Quesillo – C$73.00");
            Console.WriteLine("(8) Sopa de Mondongo – C$146.00");
            Console.WriteLine("(9) Tajadas con Carne – C$136.88");
            Console.WriteLine("(10) Sopa de Gallina – C$173.38");
            Console.WriteLine("(11) Tostones con Queso – C$82.12");
            Console.WriteLine("(12) Arroz a la Valenciana – C$146.00");
            Console.WriteLine("(13) Chicharrón con Yuca – C$127.75");
            Console.WriteLine("(14) Ensalada de Repollo – C$54.75");
            Console.WriteLine("(15) Tajadas con Queso – C$100.38\n");
            Console.WriteLine("(1) Crear Factura");
            Console.WriteLine("(2) Eliminar Factura.");
            Console.WriteLine("(3) Buscar Factura.");
            Console.WriteLine("(4) Mostrar Factura.");
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
        if (facturaActual >= 1000)
        {
            Console.WriteLine("\nRegistro lleno, no se pueden agregar más facturas.\n");
            return;
        }

        Console.Write("\nIngrese la fecha de la factura (formato dd/mmmm/yyyy): ");
        fecha[facturaActual] = Console.ReadLine();
        Console.Write("Ingrese los números claves de los platos pedidos (clave clave clave...): ");
        string entradaPlatos = Console.ReadLine();
        string[] platosSeleccionados = entradaPlatos.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double totalFactura = 0;

        foreach (string plato in platosSeleccionados)
        {
            int clavePlato;
            if (int.TryParse(plato, out clavePlato))
            {
                switch (clavePlato)
                {
                    case 1:
                        galloPintoFactura[facturaActual] += 1;
                        totalFactura += galloPinto;
                        break;
                    case 2:
                        nacatamalFactura[facturaActual] += 1;
                        totalFactura += nacatamal;
                        break;
                    case 3:
                        vigoronFactura[facturaActual] += 1;
                        totalFactura += vigoron;
                        break;
                    case 4:
                        bahoFactura[facturaActual] += 1;
                        totalFactura += baho;
                        break;
                    case 5:
                        carneAsadaFactura[facturaActual] += 1;
                        totalFactura += carneAsada;
                        break;
                    case 6:
                        indioViejoFactura[facturaActual] += 1;
                        totalFactura += indioViejo;
                        break;
                    case 7:
                        quesilloFactura[facturaActual] += 1;
                        totalFactura += quesillo;
                        break;
                    case 8:
                        sopaMondongoFactura[facturaActual] += 1;
                        totalFactura += sopaMondongo;
                        break;
                    case 9:
                        tajadasCarneFactura[facturaActual] += 1;
                        totalFactura += tajadasCarne;
                        break;
                    case 10:
                        sopaGallinaFactura[facturaActual] += 1;
                        totalFactura += sopaGallina;
                        break;
                    case 11:
                        tostonesQuesoFactura[facturaActual] += 1;
                        totalFactura += tostonesQueso;
                        break;
                    case 12:
                        arrozValencianaFactura[facturaActual] += 1;
                        totalFactura += arrozValenciana;
                        break;
                    case 13:
                        chicharronYucaFactura[facturaActual] += 1;
                        totalFactura += chicharronYuca;
                        break;
                    case 14:
                        ensaladaRepolloFactura[facturaActual] += 1;
                        totalFactura += ensaladaRepollo;
                        break;
                    case 15:
                        tajadasQuesoFactura[facturaActual] += 1;
                        totalFactura += tajadasQueso;
                        break;
                    default:
                        Console.WriteLine($"Plato con clave {clavePlato} no es válido.");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Error al interpretar la clave {plato}, asegúrese de ingresar números.");
            }
        }

        total[facturaActual] = totalFactura;
        facturas[facturaActual] = facturaActual;

        Console.WriteLine($"\nFACTURA N. {facturas[facturaActual]+1}");
        Console.WriteLine($"Fecha de la factura: {fecha[facturaActual]}");
        if (galloPintoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{galloPintoFactura[facturaActual]} órdenes de Gallo Pinto.");
        }
        if (nacatamalFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{nacatamalFactura[facturaActual]} órdenes de Nacatamal.");
        }
        if (vigoronFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{vigoronFactura[facturaActual]} órdenes de Vigorón.");
        }
        if (bahoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{bahoFactura[facturaActual]} órdenes de Baho.");
        }
        if (carneAsadaFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{carneAsadaFactura[facturaActual]} órdenes de Carne Asada.");
        }
        if (indioViejoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{indioViejoFactura[facturaActual]} órdenes de Indio Viejo.");
        }
        if (quesilloFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{quesilloFactura[facturaActual]} órdenes de Quesillo.");
        }
        if (sopaMondongoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{sopaMondongoFactura[facturaActual]} órdenes de Sopa de Mondongo.");
        }
        if (tajadasCarneFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{tajadasCarneFactura[facturaActual]} órdenes de Tajadas con Carne.");
        }
        if (sopaGallinaFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{sopaGallinaFactura[facturaActual]} órdenes de Sopa de Gallina.");
        }
        if (tostonesQuesoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{tostonesQuesoFactura[facturaActual]} órdenes de Tostones con Queso.");
        }
        if (arrozValencianaFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{arrozValencianaFactura[facturaActual]} órdenes de Arroz a la Valenciana.");
        }
        if (chicharronYucaFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{chicharronYucaFactura[facturaActual]} órdenes de Chicharrón con Yuca.");
        }
        if (ensaladaRepolloFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{ensaladaRepolloFactura[facturaActual]} órdenes de Ensalada de Repollo.");
        }
        if (tajadasQuesoFactura[facturaActual] != 0)
        {
            Console.WriteLine($"{tajadasQuesoFactura[facturaActual]} órdenes de Tajadas con Queso.");
        }

        Console.WriteLine($"Total: C${totalFactura}");

        facturaActual++;
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