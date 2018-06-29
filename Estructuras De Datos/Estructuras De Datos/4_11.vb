Module _4_11

    '4.11. Crear un algoritmo que lea valores reales en forma consecutiva y los vaya agregando a
    '      una pila de tipo real.
    '             Si el valor ingresado es cero se quita un elemento.
    '             En todo momento informar la sumatoria total de los valores.



    Sub main()

        Dim Reales As New Stack(Of Single)

        Rutina(Reales)

        Console.ReadKey()

    End Sub

    Private Sub Rutina(Reales As Stack(Of Single))
        While True
            If Reales.Count = 0 Then
                Console.WriteLine("No Hay numeros en la Pila...")
            Else
                Console.WriteLine("La Pila cuenta con {0} Numeros. Y su Sumatoria es {1}", Reales.Count, Sumatoria(Reales))
            End If
            Console.WriteLine()
            Console.Write("Ingrese un Numero Real: ")
            Dim numero As Single = Console.ReadLine
            If numero = 0 Then
                Reales.Pop()
            Else
                Reales.Push(numero)
            End If
        End While
    End Sub

    Private Function Sumatoria(pila As Stack(Of Single)) As Single
        Dim acumulador As Single = 0
        For Each numero In pila
            acumulador += numero
        Next
        Return acumulador
    End Function

End Module
