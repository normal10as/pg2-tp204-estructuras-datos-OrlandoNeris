Module _4_8

    '4.8.    Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
    '        una Hashtable y permita realizar consultas por el nombre de dominio
    '             se introduce el nombre del dominio y se deberá mostrar el nombre del país
    '             Informar si la clave no existe con un mensaje.
    '             Salir cuando el valor ingresado es vacío.

    Sub main()
        Dim dominio As String
        Dim Paises As New Hashtable

        Paises.Add("AR", "Argentina")
        Paises.Add("BR", "Brazil")
        Paises.Add("PY", "Paraguay")
        Paises.Add("BO", "Bolivia")
        Paises.Add("EU", "Estados Unidos")
        Paises.Add("MX", "Mexico")
        Paises.Add("UK", "Inglaterra")
        Paises.Add("FR", "Francia")
        Paises.Add("PE", "Peru")
        Paises.Add("UR", "Uruguay")


        Console.WriteLine("Ingrese Dominio a buscar en mayusculas. ej: AR")
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
