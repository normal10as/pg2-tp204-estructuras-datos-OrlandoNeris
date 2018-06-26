Module _4_4
    '        4. Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
    '        una Collection. A continuación, debe permitir realizar consultas: se introduce el nombre del
    '        dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.

    Sub main()

        Dim Paises As New Collection
        Dim dominio As String

        Paises.Add("Argentina", "ar")
        Paises.Add("Brazil", "br")

        Console.WriteLine("Ingrese Dominio a buscar: ")
        Do
            Console.Write("Ingrese dominio: ")
            dominio = Console.ReadLine
            If Paises.Contains(dominio) Then
                Console.WriteLine(Paises.Item(dominio))
            Else
                Console.WriteLine("El dominio no esta en los existentes. ")
            End If

        Loop Until (dominio = "")
        Console.ReadKey()
    End Sub


End Module
