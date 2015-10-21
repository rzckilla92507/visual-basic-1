Public Class Form1

Dim userNumber As Integer

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        userNumber = Val(usrInput.Text)

        If userNumber = 60 Then

            'labelResult.Text = "You're the Lucky Winner"
            'labelResult.BackColor = Color.Green
            labelResultWinner.Visible = True

        ElseIf userNumber > 0 And userNumber < 60 Then

            labelResultLoser.Text = "Dude, you are way to low."
            labelResultLoser.Visible = True

        ElseIf userNumber > 60 And userNumber < 101 Then

            labelResultLoser.Text = "Your guess is to High, Try again"
            labelResultLoser.Visible = True

        Else
            labelResultLoser.Text = "Your guess is out of the scope of the game."
            labelResultLoser.Visible = True

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        usrInput.Text = ""
        labelResultWinner.Visible = False
        labelResultLoser.Visible = False

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        usrInput.Text = ""
        labelResultWinner.Visible = False
        labelResultLoser.Visible = False

    End Sub
End Class
