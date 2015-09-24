Module Module1

    Sub Main()

        'Dim myNewCar As Car = New 
        Dim myNewCar As New Car

        myNewCar.Make = "Oldsmobile"
        myNewCar.Model = "Cutlas Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "Silver"

        'With myNewCar
        '    .Make = "Oldsmobile"
        '    .Model = "Cutlas"
        '    .Year = 1986
        '    .Color = "Silver"
        'End With

        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year.toString())

        Console.WriteLine(determineMarketValue(myNewCar))

        Console.ReadLine()

    End Sub

    Function determineMarketValue(ByVal myCar As Car) As Double

        'Super secret formula

        Return 100.0
    End Function

End Module

Public Class Car

    Public Make As String
    Public Model As String
    Public Year As Integer
    Public Color As String


End Class
