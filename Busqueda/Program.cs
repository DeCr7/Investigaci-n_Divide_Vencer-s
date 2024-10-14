using System;

class BinarySearchExample
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 9, 10, 27, 38, 43, 82 };
        int objetivo = 27;

        int result = BusquedaBinaria(array, objetivo); //Llamada de la búsqueda binaria

        if (result != -1)
            Console.WriteLine("Elemento encontrado en la posición: " + result); //Devolución de elemento encontrado
        else
            Console.WriteLine("Elemento no encontrado."); //Devolución de elemento no encontrado
    }

    static int BusquedaBinaria(int[] array, int objetivo)
    {
        int izquierda = 0, derecha = array.Length - 1;

        while (izquierda <= derecha)
        {
            // Encuentra el punto medio
            int medio = izquierda + (derecha - izquierda) / 2;

            // Compara el elemento del medio con el objetivo
            if (array[medio] == objetivo)
                return medio;

            // Si el objetivo es menor, ignora la mitad derecha
            if (array[medio] > objetivo)
                derecha = medio - 1;
            // Si el objetivo es mayor, ignora la mitad izquierda
            else
                izquierda = medio + 1;
        }

        // Si el elemento no está en el array
        return -1;
    }
}