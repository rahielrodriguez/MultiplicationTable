'Rahiel Rodriguez
'RCET0265
'Spring 2024
'Multiplication Table
'https://github.com/rahielrodriguez/MultiplicationTable.git

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()
        Dim currentValue As Integer
        Dim currentString As String
        Dim userInput As String
        Dim selectedNumber As Integer
        Dim leave As Boolean = False

        Do
            Console.WriteLine("Please select a number for your multiplication table.")
            userInput = Console.ReadLine()
            Try
                selectedNumber = CInt(userInput)

                Console.WriteLine($"Enjoy your {userInput} x {userInput} multiplication table:")
                Console.WriteLine()

                For row = 1 To CInt(userInput)
                    For column = 1 To CInt(userInput)
                        currentValue = row * column
                        currentString = CStr(currentValue)
                        If Len(currentString) < 2 Then
                            currentString = "0" & currentString
                        End If
                        currentString = currentString.PadLeft(6)
                        Console.Write(currentString)
                    Next
                    Console.WriteLine()
                    Console.WriteLine(StrDup(66, " "))
                Next

                leave = True

            Catch ex As Exception
                Console.WriteLine("Please select a whole number.")

            End Try

        Loop Until leave = True

        Console.Read()

    End Sub

End Module
