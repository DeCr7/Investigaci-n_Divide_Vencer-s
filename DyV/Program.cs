using System;

class Programa
{
    static void Main()
    {
        // Aquí tenemos un arreglo de números desordenados
        int[] arreglo = { 5, 3, 8, 4, 2 };

        // Mostramos el arreglo original en la consola
        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));

        // Llamamos a la función que ordenará el arreglo
        Ordenar(arreglo, 0, arreglo.Length - 1);

        // Mostramos el arreglo ordenado en la consola
        Console.WriteLine("Arreglo ordenado: " + string.Join(", ", arreglo));
    }

    // Esta función ordena el arreglo
    static void Ordenar(int[] arreglo, int inicio, int fin)
    {
        // Verificamos si hay más de un elemento para ordenar
        if (inicio < fin)
        {
            // Particionamos el arreglo y encontramos la posición del pivote
            int pivote = Particionar(arreglo, inicio, fin);

            // Llamamos a la función para ordenar la parte izquierda
            Ordenar(arreglo, inicio, pivote - 1);

            // Llamamos a la función para ordenar la parte derecha
            Ordenar(arreglo, pivote + 1, fin);
        }
    }

    // Esta función organiza el arreglo alrededor del pivote
    static int Particionar(int[] arreglo, int inicio, int fin)
    {
        // Elegimos el último elemento como pivote
        int pivote = arreglo[fin];
        // Inicializamos una variable para contar los elementos menores que el pivote
        int i = inicio - 1;

        // Recorremos el arreglo desde el inicio hasta el penúltimo elemento
        for (int j = inicio; j < fin; j++)
        {
            // Si el elemento actual es menor o igual al pivote
            if (arreglo[j] <= pivote)
            {
                // Aumentamos el contador de elementos menores
                i++;
                // Intercambiamos los elementos
                Intercambiar(arreglo, i, j);
            }
        }
        // Colocamos el pivote en su lugar correcto
        Intercambiar(arreglo, i + 1, fin);
        // Retornamos la nueva posición del pivote
        return i + 1;
    }

    // Esta función intercambia dos elementos del arreglo
    static void Intercambiar(int[] arreglo, int i, int j)
    {
        // Guardamos el valor de la posición i
        int temp = arreglo[i];
        // Intercambiamos los valores en las posiciones i y j
        arreglo[i] = arreglo[j];
        arreglo[j] = temp;
    }
}
