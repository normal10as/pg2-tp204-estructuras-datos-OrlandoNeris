Module _4_9

    '4.9.Crear un programa para dar tunos a los compradores de una tienda por orden de llegada.
    '         Cuando los compradores ingresan al local dan su nombre y quedan esperando ser llamados
    '          por un empleado.
    '         Un empleado llama al próximo cliente para ser atendido el programa muestra su nombre y
    '          este sale de la lista
    '         Tener en cuenta que estos procesos pueden ser en cualquier orden.
    '         En todo momento informar la cantidad de clientes en espera y el nombre de los dos
    '          siguientes clientes a ser atendidos. Si no hay compradores en espera informar “Sin
    '          clientes”. 

    Sub main()

        Dim Clientes As New Queue
        Dim bandera As Byte = 1

        While bandera <> 3
            If Clientes.Count = 0 Then
                Console.WriteLine(" Sin Clientes en Espera...! ")
            Else
                Console.WriteLine(" Hay {0} Clientes en Espera...! ", Clientes.Count)
            End If
            Console.WriteLine("1) Agregar Cliente a la fila, 2) LLamar a un cliente,  3) Salir. ")
            Console.Write("Ingrese Opcion: ")
            bandera = Console.ReadLine
            If bandera = 1 Then
                Console.WriteLine()
                Console.Write("Ingese Nombre del Cliente: ")
                Dim nombre As String = Console.ReadLine
                Clientes.Enqueue(nombre)
            ElseIf bandera = 2 Then
                Console.WriteLine()
                Console.WriteLine("Es el Turno del Cliente: " & Clientes.Dequeue())
            End If
        End While
        Console.ReadKey()

    End Sub



End Module
