Module _4_5

    '   Al ejercicio anterior agregarle las funcionalidades que permita interactivamente agregar, editar,
    '   eliminar y mostrar el nombre de país y su dominio. También informar la cantidad de países
    '   cargados

    Enum Menu
        salir = 0
        listar = 1
        agregar = 2
        buscar = 3
        editar = 4
    End Enum

    Sub main()

        Dim Paises As New Collection

        Paises.Add("Argentina", "ar")
        Paises.Add("Brazil", "br")
        Dim opcion As Menu

        Do
            Console.WriteLine(" ------ Menu de bajo presupuesto ------------ ")
            Console.WriteLine("1) Listar.  2) Agregar, 3) Buscar.  4) Editar  0) Salir: ")
            Console.Write("Ingrese Opcion: ")
            opcion = Console.ReadLine
            Select Case opcion
                Case opcion.listar
                    For Each pais In Paises
                        Console.WriteLine(pais)
                    Next
                Case opcion.agregar
                    AgregarPais(Paises)

                Case opcion.buscar
                    BuscarPais(Paises)

                Case opcion.editar

                    Editar(Paises)

            End Select
        Loop Until (opcion = 0)

        Console.ReadKey()
    End Sub

    Private Sub AgregarPais(Paises As Collection)
        Dim dominio As String

        Dim bandera As Boolean = False
        Do
            Console.Write("Ingrese dominio del pais:  ")
            dominio = Console.ReadLine

            If Paises.Contains(dominio) Then
                Console.WriteLine("El Dominio del pais ya existe ")
            Else
                bandera = True
            End If

        Loop Until (bandera)
        Console.Write("Ingrese Nombre del pais a ingresar : ")
        Dim pais As String = Console.ReadLine
        Paises.Add(pais, dominio)
        Console.WriteLine("Pais agregado con exito! ")
        Console.ReadKey()
    End Sub

    Private Sub Editar(Paises As Collection)
        Console.WriteLine("Ingrese Dominio a Editar: ")
        Dim dominio As String = Console.ReadLine
        If Paises.Contains(dominio) Then
            Dim auxdom, auxpais As String
            Console.WriteLine("1) Editar Pais.  2) Editar Dominio ")
            Dim op As Byte = Console.ReadLine
            If op = 1 Then
                Console.Write("Ingrese Nuevo Nombre del Pais: ")
                auxpais = Console.ReadLine
                auxdom = dominio
                Paises.Remove(dominio)
                Paises.Add(auxpais, auxdom)
                Console.WriteLine("Operacion Realizada Con Exito!! ")

            ElseIf op = 2 Then
                Console.Write("Ingrese Nuevo Dominio del pais {0}: ", Paises.Item(dominio))
                auxdom = Console.ReadLine
                auxpais = Paises.Item(dominio)
                Paises.Remove(dominio)
                Paises.Add(auxpais, auxdom)
                Console.WriteLine("Operacion Realizada Con Exito!! ")
            Else
                Console.WriteLine("Opcion Ingresada Incorrecta!! ")
            End If
        End If
    End Sub

    Private Sub BuscarPais(Paises As Collection)
        Dim dominio As String
        Do
            Console.WriteLine("Ingrese Dominio del Pais a buscar")
            dominio = Console.ReadLine
            If Paises.Contains(dominio) Then
                Console.WriteLine(Paises.Item(dominio))
            Else
                Console.WriteLine("El dominio no esta en los existentes. ")
            End If
        Loop Until (dominio = "")
    End Sub

End Module
