Module _4_1

    '.Elaborar un algoritmo que permita cargar 5 números en un arreglo de 5 elementos;
    ' calcular la media y luego imprimir cada elemento del arreglo y la desviación que tiene respecto a la media.
    'La MEDIA se obtiene la sumatoria de los todos elementos del arreglo y se divide por la cantidad de los mismos.
    ' La DESVIACION de cada elemento se obtiene restándole al elemento la MEDIA.
    '

    Sub main()

        Dim valores(4) As Integer
        Dim MEDIA As Integer

        For i = 0 To 4
            Console.WriteLine("Ingrese {0}° elemento a evaluar: ", i + 1)
            valores(i) = Console.ReadLine
            MEDIA += valores(i)
        Next

        MEDIA = MEDIA / 5

        Console.WriteLine()
        Console.WriteLine("La media de los elementos ingresados es: " & MEDIA)
        Console.WriteLine()

        For i = 0 To 4
            Console.WriteLine("El elemento ingresado en la {0}° posicion tiene una desviacion de: {1} de la MEDIA.", i, valores(i) - MEDIA)
        Next

        Console.ReadKey()


    End Sub



End Module
