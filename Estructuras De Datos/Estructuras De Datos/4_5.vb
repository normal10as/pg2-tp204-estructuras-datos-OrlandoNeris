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
        'Dim opcion As Menu

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

                Case opcion.buscar
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

                Case opcion.editar

            End Select


        Loop Until (opcion = 0)
        '    Console.Write("Ingrese dominio: ")
        '    


        Console.ReadKey()
    End Sub








End Module
