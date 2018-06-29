Module _4_10

    '4.10.   Crear un algoritmo que tenga una colección de stack de manera tal que pueda ser
    '        accedida en todo el módulo. Con un menú permite efectuar 2 acciones: ingresar nombres a la
    '        colección desde teclado y la segunda permita extraerlo y mostrarlo en la pantalla. El programa
    '        debe finalizar cuando se quitan todos los elementos de la colección
    Private Nombres As New Stack

    Sub main()
        Dim bandera As Byte = 1

        While bandera <> 3
            If Nombres.Count = 0 Then
                Console.WriteLine(" Sin Nombres en la Pila...! ")
            Else
                Console.WriteLine(" Hay {0} Nombres en la Pila...! ", Nombres.Count)
            End If
            Console.WriteLine("1) Agregar Nombre a la Pila, 2) Extraer nombre de la Pila,  3) Salir. ")
            Console.Write("Ingrese Opcion: ")
            bandera = Console.ReadLine
            If bandera = 1 Then
                Console.WriteLine()
                Console.Write("Ingese Nombre a Agregar: ")
                Dim nombre As String = Console.ReadLine
                Nombres.Push(nombre)
            ElseIf bandera = 2 Then
                Console.WriteLine()
                Console.WriteLine("El Nombre Extraido es: " & Nombres.Pop())
            End If
        End While
        Console.ReadKey()
    End Sub

End Module
