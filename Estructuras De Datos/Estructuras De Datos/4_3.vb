Module _4_3

    'Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de alumnos.
    '     Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
    '      máximo de 40 alumnos y 4 notas.
    '     Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
    '      y que no sea repetido y el rango de la nota.
    '     Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
    '      teniendo en cuenta que aprueba con 6 o más.
    '     También informar quien es el mejor alumno (puede haber más de uno).
    '     Implementar procedimientos para resolver al menos las siguientes tareas:
    '     Uno para validad el nombre no sea vacío
    '     uno que valide la inexistencia de un nombre igual
    '     uno que valide el rango de la nota
    '     uno que determine el promedio
    '     uno que escriba si el alumno aprobó o no
    '     uno que devuelva la lista de mejores alumnos



    Sub main()
        Dim NombresAlumnos() As String
        Dim NotasAlumnos(,) As Single
        Dim cantalu, cantnotas As Byte
        Dim MejorNota As Single = 0


        Validar(cantalu, "Cantidad de Alumnos", 40)
        Validar(cantnotas, "Cantidad de Notas", 4)

        ReDim NombresAlumnos(cantalu - 1)
        ReDim NotasAlumnos(cantalu - 1, cantnotas - 1)

        CargarDatos(NombresAlumnos, cantalu, NotasAlumnos)

        Select Case (NotasAlumnos.Length / cantalu)
            Case 1
                Console.WriteLine("NOMBRE" & vbTab & vbTab & "NOTA 1" & vbTab & vbTab & "Promedio" & vbTab & vbTab & " Condidion ")
            Case 2
                Console.WriteLine("NOMBRE" & vbTab & vbTab & "NOTA 1" & vbTab & vbTab & "NOTA 2" & vbTab & vbTab & "Promedio" & vbTab & vbTab & " Condidion ")
            Case 3
                Console.WriteLine("NOMBRE" & vbTab & vbTab & "NOTA 1" & vbTab & vbTab & "NOTA 2" & vbTab & vbTab & "NOTA 3" & vbTab & vbTab & "Promedio" & vbTab & vbTab & " Condidion ")
            Case 4
                Console.WriteLine("NOMBRE" & vbTab & vbTab & "NOTA 1" & vbTab & vbTab & "NOTA 2" & vbTab & vbTab & "NOTA 3" & vbTab & vbTab & "NOTA 4" & vbTab & vbTab & "Promedio" & vbTab & vbTab & " Condidion ")

        End Select

        For i = 0 To NombresAlumnos.Length - 1

            Console.Write(NombresAlumnos(i) & vbTab & vbTab)
            For j = 0 To (NotasAlumnos.Length / cantalu) - 1
                Console.Write(NotasAlumnos(i, j) & vbTab & vbTab)
            Next
            Console.Write(Promedio(NotasAlumnos, i, cantalu) & vbTab & vbTab & vbTab & Condicion(Promedio(NotasAlumnos, i, cantalu)))
            If (Promedio(NotasAlumnos, i, cantalu) > MejorNota) Then
                MejorNota = Promedio(NotasAlumnos, i, cantalu)
            End If

            Console.WriteLine()
        Next

        Console.ReadKey()

    End Sub

    Private Sub CargarDatos(ByRef NombresAlumnos() As String, cantalu As Byte, ByRef Matriz(,) As Single)
        Dim bandera As Boolean = False
        For i = 0 To cantalu - 1
            Dim auxnombre As String
            Do
                Console.Write("Ingrese Nombre del {0}° Alumno : ", i + 1)
                auxnombre = Console.ReadLine()
                If ValidarNombres(NombresAlumnos, auxnombre) Then
                    Console.WriteLine("Nombre existente o vacio.. intente de nuevo..! ")
                    bandera = False
                Else
                    bandera = True
                End If
            Loop Until (bandera = True)
            NombresAlumnos(i) = auxnombre

            For j = 0 To (Matriz.Length / cantalu) - 1
                Dim auxnota As Single
                Do
                    Console.Write("Ingrese {0}° Nota del {1} Alumno : ", j + 1, i + 1)
                    auxnota = Console.ReadLine()
                    If ValidarNota(auxnota) Then
                        Matriz(i, j) = auxnota
                        bandera = True
                    Else
                        bandera = False
                    End If
                Loop Until (bandera = True)
            Next
        Next
    End Sub

    Private Function ValidarNota(ByVal value As Single) As Boolean

        If value > 0 And value <= 10 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Validar(ByRef value As Byte, concepto As String, tope As Byte)

        Dim aux As Integer
        Do
            Console.Write("Ingrese Un Numero Correspondiente a la cantidad de {0}: ", concepto)
            aux = Console.ReadLine
        Loop Until (aux > 0 And aux <= tope)

        value = aux

    End Sub


    Private Function ValidarNombres(ByVal vector() As String, Nombre As String) As Boolean

        If Nombre <> "" Then
            For i = 0 To vector.Length() - 1
                If vector(i) = Nombre Then
                    Return True
                End If
            Next
        ElseIf Nombre = "" Then
            Return True
        End If

        Return False
    End Function

    Private Function Promedio(ByVal array(,) As Single, linea As Byte, dimension As Byte) As Single
        Dim acumulador As Single = 0
        Dim j As Byte

        For j = 0 To (array.Length / dimension) - 1
            acumulador += array(linea, j)
        Next
        Return acumulador / (j)

    End Function

    Private Function Condicion(ByVal nota As Single) As String

        If nota >= 6 And nota <= 10 Then
            Return "Aprobado"
        Else
            Return "Desaprobado"
        End If

    End Function



End Module
