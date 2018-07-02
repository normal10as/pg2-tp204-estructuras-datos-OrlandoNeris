Module _4_6

    '4.6. Se tiene la producción de los 7 días de la semana de una planta de chipas con varios empleados.
    '   Escribir un algoritmo que permita ingresar cantidad de productos producidos por cada empleado
    '   en un día especificado teniendo en cuenta que la producción de cada empleado puede ser
    '   ingresadas varias veces por día.
    '        Luego de cada ingreso totalizar los ingresos por empleado y por día.
    '        Los empleados están cargados programáticamente e identificados por una clave que es su
    '           nombre abreviado.
    '        Utilizar ArrayList y Collection.

    Enum Menu
        Cargar = 1
    End Enum

    Sub main()
        Dim op As Menu
        Dim Empleados As New Collection
        Dim TotalSemanas As New ArrayList
        Dim Semana(6) As Single
        For i = 0 To 6
            Semana(i) = 0
        Next

        Empleados.Add("Orlando", "OR")
        Empleados.Add("Pedro", "PE")
        Empleados.Add("Juan", "JU")

        For Each empleado In Empleados
            TotalSemanas.Add(Semana)
        Next


        Do
            Console.WriteLine("Ingrese Opcion: ")
            op = Console.ReadLine

            Select Case op
                Case op.Cargar
                    Console.Write("Ingrese cofigo de Empleado en Mayusculas.. ")
                    Dim codigoemp As String = Console.ReadLine
                    If Empleados.Contains(codigoemp) Then
                        Console.WriteLine("Ingrese dia de la semana en el cual Agregar Producto: ")
                        Console.Write("1) Lunes, 2) Martes, 3) Miercoles, 4) Jueves, 5) Viernes, 6) Sabado, 7) Domingo: ")
                        Dim dia As Byte = Console.ReadLine
                        Console.Write("Ingrese Cantidad a Agregar en este el dia {0}: ", NombreDias(dia))
                        Dim cantidad As Integer = Console.ReadLine
                        TotalSemanas(BuscarIndice(Empleados, codigoemp, dia) = 


                    Else
                        Console.WriteLine("Codigo Incorrecto, Intente de Nuevo. ")
                    End If
            End Select


        Loop Until (op = 0)





        For Each semana In TotalSemanas
            For i = 0 To 6
                Console.WriteLine(semana(i))
            Next
        Next

        Console.ReadKey()


    End Sub

    Private Function NombreDias(value) As String
        Dim aux As String
        Select Case value
            Case 1
                aux = "Lunes"
            Case 2
                aux = "Martes"
            Case 3
                aux = "Miercoles"
            Case 4
                aux = "Jueves"
            Case 5
                aux = "Viernes"
            Case 6
                aux = "Sabado"
            Case 7
                aux = "Domingo"
        End Select
        Return aux
    End Function

    Private Function BuscarIndice(nombres As Collection, nombrealu As String) As Byte

        Dim i As Byte = 0

        For Each nombre In nombres
            If nombre = nombrealu Then
                Return i
            End If
            i += 1
        Next

    End Function


End Module
