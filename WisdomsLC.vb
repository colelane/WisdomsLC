Option Strict On
Option Explicit On
Option Compare Text

Module WisdomsLC
    'Lane Coleman
    'RCET 0265
    'Fall 2020
    'Accumulate Messages
    'https://github.com/colelane/WisdomsLC.git

    Sub Main()
        Dim randomNumber As Integer
        Dim quit As String
        'This initializes the random number seed to be changed each time the program will run.
        'Without this, the same pattern of "randomness" would appear every time the program was run. That's not very random.
        Randomize()
        Do


            Console.WriteLine($"Press enter to gain wisdom")
            quit = Console.ReadLine()
            If quit = "q" Then
                Exit Sub
            End If

            randomNumber = GetRandomNumber(1, 2)


            Select Case randomNumber
                Case 1
                    Console.WriteLine($"The early bird gets worm but the second mouse gets the cheese{vbNewLine}")
                Case 2
                    Console.WriteLine($"Don't be dumb.{vbNewLine}")
                Case 3
                    Console.WriteLine($"If it ain't broke don't fix it{vbNewLine}")
            End Select

            'The case structure works similarly to the if statements below. They are interchangable

            'If randomNumber = 1 Then
            '    Console.WriteLine($"wisdom1{vbNewLine}")

            'ElseIf randomNumber = 2 Then
            '    Console.WriteLine($"wisdom2{vbNewLine}")

            'ElseIf randomNumber = 3 Then
            '    Console.WriteLine($"wisdom3{vbNewLine}")

            'End If
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub
    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        'ByVal makes a copy of whatever you point it at. each variable looks to the getrandomnumbers(1, 2)  the comma is the separator.
        Dim value As Single
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        'rnd is a random number between 0 and 1
        Return CInt(value)
    End Function

End Module

