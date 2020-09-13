Option Strict On
Option Explicit On
Option Compare Text

Module WisdomsLC
    'Lane Coleman
    'RCET 0265
    'Fall 2020
    'Accumulate Messages

    Sub Main()
        Dim randomNumber As Integer
        Randomize()
        Do


            Console.WriteLine($"Press enter to gain wisdom")
            Console.ReadLine()

            randomNumber = GetRandomNumber(1, 2)

            If randomNumber = 1 Then
                Console.WriteLine($"wisdom1{vbNewLine}")

            ElseIf randomNumber = 2 Then
                Console.WriteLine($"wisdom2{vbNewLine}")

            ElseIf randomNumber = 3 Then
                Console.WriteLine($"wisdom3{vbNewLine}")

            End If
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub
    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Return CInt(value)
    End Function

End Module

