Module Pruebas



    Sub main()

        Dim Nombres As New Collection
        Dim Notas As New ArrayList

        Dim vector(1) As Integer


        Nombres.Add("Orlando")
        Nombres.Add("Mariano")
        Nombres.Add("Marcelo")
        Nombres.Add("maria")

        vector(0) = 1
        vector(1) = 2

        Notas.Add(vector)

        vector(0) = 5
        vector(1) = 4

        Notas.Add(vector)

        'For Each nota In Notas
        '    nota(0)
        'Next
        Console.WriteLine(Notas(BuscarIndice(Nombres, "orlando")))

        Console.WriteLine(BuscarIndice(Nombres, "maria"))

        Console.ReadKey()

    End Sub

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
