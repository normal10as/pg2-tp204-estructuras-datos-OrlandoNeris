Module _4_7

    '4.7. Crear un algoritmo que utilice arrayList para almacenar las notas (0 a 10) de una serie de alumnos.
    '         Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
    '          máximo de 40 alumnos y 4 notas.
    '         Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
    '          y que no sea repetido y el rango de la nota.
    '         Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
    '          teniendo en cuenta que aprueba con 6 o más.
    '         También informar quien es el mejor alumno (puede haber más de uno).
    '         Implementar procedimientos para resolver al menos las siguientes tareas:
    '         Uno para validad el nombre no sea vacío
    '         uno que valide la inexistencia de un nombre igual
    '         uno que valide el rango de la nota
    '         uno que determine el promedio
    '         uno que escriba si el alumno aprobó o no
    '         uno que devuelva la lista de mejores alumnos

    Sub main()

        Dim cantalu, cantnotas As Byte
        Dim MejorNota As Single = 0


        Validar(cantalu, "Cantidad de Alumnos", 40)
        Validar(cantnotas, "Cantidad de Notas", 4)

        Dim NombreAlumnos As New ArrayList



        Console.ReadKey()

    End Sub

    Private Sub Validar(ByRef value As Byte, concepto As String, tope As Byte)

        Dim aux As Integer
        Do
            Console.Write("Ingrese Un Numero Correspondiente a la cantidad de {0}: ", concepto)
            aux = Console.ReadLine
        Loop Until (aux > 0 And aux <= tope)

        value = aux

    End Sub
End Module
