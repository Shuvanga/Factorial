Imports System

Module Program
    Sub Main()
        Dim i, num, fact As Integer
        Console.WriteLine("Enter the number:")
        num = Console.ReadLine
        fact = factorial(num)
        Console.WriteLine("The factorial equals:")
        For i = 1 To (num - 1)
            Console.Write(i & "*")
        Next
        Console.Write(num & "=" & fact)
        Console.ReadKey()
    End Sub
    Function factorial(ByVal num As Integer)
        If num = 1 Then
            Return 1
        Else
            Return factorial(num - 1) * num
        End If

    End Function
End Module
