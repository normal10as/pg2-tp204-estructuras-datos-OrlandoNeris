Module _4_2

    'Se tiene tres arrays cargados programáticamente con una lista de productos: 
    'el primero tiene el código, 
    'el segundo el nombre
    'el tercero el precio unitario. 
    'Repetitivamente se ingresa un código de producto y el programa muestra su descripción y precio, 
    'luego el usuario ingresa la cantidad con lo que el programa responde calculando el total del producto y el total general
    '(acumulando los productos anteriores).
    'Esto sucede hasta que el código sea cero.

    Sub main()

        Dim CodProducto = New UShort() {0, 1, 2, 3, 4}
        Dim NomProducto = New String() {"Leche", "Pan", "Papa", "Yerba"}
        Dim PreciUnit = New Single() {1.4, 2, 4.3, 8.1}
        Dim TotalGeneral As Single = 0

        Dim opcion As Integer

        Do
            opcion = ValidarCodigo(CodProducto)
            Dim cantidad As UShort

            If opcion = 0 Then
                Exit Do
            End If

            For Each codigo As Integer In CodProducto
                If codigo = opcion Then
                    Console.WriteLine("Descripcion: " & NomProducto(opcion))
                    Console.WriteLine("Precio Unitario: " & PreciUnit(opcion))
                    Console.Write("Ingrese Cantidad: ")
                    cantidad = Console.ReadLine
                    TotalGeneral += PreciUnit(opcion) * cantidad
                    Console.WriteLine("Total del Producto: " & PreciUnit(opcion) * cantidad)
                    Console.WriteLine("Total General: " & TotalGeneral)
                End If
            Next
        Loop While (True)

        Console.WriteLine("Total De la Compra: " & TotalGeneral)
        Console.ReadKey()

    End Sub

    Function ValidarCodigo(listadecodigos() As UShort)

        Do
            Console.Write("Ingrese Codigo de Producto: ")
            Dim value As Integer = Console.ReadLine

            For Each codigo As Integer In listadecodigos
                If codigo = value Then
                    Return value
                End If
            Next
            Console.WriteLine("Codigo Erroneo, Ingreselo de nuevo...")
        Loop While (True)

    End Function


End Module
