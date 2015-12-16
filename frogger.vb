Dim lives, wins, answer As Integer

    Private Sub frmFrogger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        ' moves the frog left when the a or A key is pressed
        If (e.KeyChar = "a" Or e.KeyChar = "A") And (pctFrog.Left > 0) Then
            pctFrog.Left = pctFrog.Left - 50
        End If

        'moves the frog right when the d or D key is pressed
        If (e.KeyChar = "d" Or e.KeyChar = "D") And ((pctFrog.Left + pctFrog.Width) < frmFrogger.ActiveForm.Width) Then
            pctFrog.Left = pctFrog.Left + 50
        End If

        'moves the frog up when the w or W key is pressed
        If (e.KeyChar = "w" Or e.KeyChar = "W") And pctFrog.Top > 0 Then
            pctFrog.Top = pctFrog.Top - 50
            'Frog jumping into the first spot
            If pctFrog.Top = 0 Then
                If pctFrog.Left >= 120 And pctFrog.Left <= 170 Then
                    pctFakeSpot1.Visible = True
                    pctFrog.Top = 400
                    pctFrog.Left = 350
                    wins = wins + 1
                    If wins = 3 Then
                        winOrLose("You Win!!!!!!")
                    End If
                    'Frog jumping into the second spot
                ElseIf pctFrog.Top = 0 And pctFrog.Left >= 315 And pctFrog.Left <= 365 Then
                    pctFakeSpot2.Visible = True
                    pctFrog.Top = 400
                    pctFrog.Left = 350
                    wins = wins + 1
                    If wins = 3 Then
                        winOrLose("You Win!!!!!!")
                    End If
                    'Frog jumping into the third spot
                ElseIf pctFrog.Top = 0 And pctFrog.Left >= 530 And pctFrog.Left <= 580 Then
                    pctFakeSpot3.Visible = True
                    pctFrog.Top = 400
                    pctFrog.Left = 350
                    wins = wins + 1
                    If wins = 3 Then
                        winOrLose("You Win!!!!!!")
                    End If
                Else
                    Die()
                End If
            End If
        End If

        'moves the frog down when the s or S key is pressed
        If (e.KeyChar = "s" Or e.KeyChar = "S") And pctFrog.Top < 400 Then
            pctFrog.Top = pctFrog.Top + 50
        End If

    End Sub

    Private Sub tmrMoveCars_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveCars.Tick
        'moves bottom row of cars to the left and makes them circle back
        pctCar1.Left = pctCar1.Left - 10
        If (pctFrog.Top = 350) And (((pctFrog.Left > pctCar1.Left And pctFrog.Left < pctCar1.Left + pctCar1.Width) Or pctCar1.Left > pctFrog.Left And pctCar1.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If

        If pctCar1.Left + pctCar1.Width < 0 Then
            pctCar1.Left = frmFrogger.ActiveForm.Width
        End If

        pctCar2.Left = pctCar2.Left - 10
        If (pctFrog.Top = 350) And (((pctFrog.Left > pctCar2.Left And pctFrog.Left < pctCar2.Left + pctCar2.Width) Or pctCar2.Left > pctFrog.Left And pctCar2.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If

        If pctCar2.Left + pctCar2.Width < 0 Then
            pctCar2.Left = frmFrogger.ActiveForm.Width
        End If

        pctCar3.Left = pctCar3.Left - 20
        If (pctFrog.Top = 250) And (((pctFrog.Left > pctCar3.Left And pctFrog.Left < pctCar3.Left + pctCar3.Width) Or pctCar3.Left > pctFrog.Left And pctCar3.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If

        If pctCar3.Left + pctCar3.Width < 0 Then
            pctCar3.Left = frmFrogger.ActiveForm.Width
        End If

        pctCar4.Left = pctCar4.Left - 20
        If (pctFrog.Top = 250) And (((pctFrog.Left > pctCar4.Left And pctFrog.Left < pctCar4.Left + pctCar4.Width) Or pctCar4.Left > pctFrog.Left And pctCar4.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If

        If pctCar4.Left + pctCar4.Width < 0 Then
            pctCar4.Left = frmFrogger.ActiveForm.Width
        End If

        pctCar5.Left = pctCar5.Left - 20
        If (pctFrog.Top = 250) And (((pctFrog.Left > pctCar5.Left And pctFrog.Left < pctCar5.Left + pctCar5.Width) Or pctCar5.Left > pctFrog.Left And pctCar5.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If

        If pctCar5.Left + pctCar5.Width < 0 Then
            pctCar5.Left = frmFrogger.ActiveForm.Width
        End If
    End Sub

    Private Sub tmrMoveTrucks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveTrucks.Tick
        pctTruck1.Left = pctTruck1.Left + 10
        If (pctFrog.Top = 300) And (((pctFrog.Left > pctTruck1.Left And pctFrog.Left < pctTruck1.Left + pctTruck1.Width) Or pctTruck1.Left > pctFrog.Left And pctTruck1.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()
        End If
        If pctTruck1.Left > frmFrogger.ActiveForm.Width Then
            pctTruck1.Left = -pctTruck1.Width
        End If

        pctTruck2.Left = pctTruck2.Left + 10
        If (pctFrog.Top = 300) And (((pctFrog.Left > pctTruck2.Left And pctFrog.Left < pctTruck2.Left + pctTruck2.Width) Or pctTruck2.Left > pctFrog.Left And pctTruck2.Left < pctFrog.Left + pctFrog.Width)) Then
            Die()

        End If
        If pctTruck2.Left > frmFrogger.ActiveForm.Width Then
            pctTruck2.Left = -pctTruck2.Width
        End If
    End Sub

    Private Sub tmrMoveLogs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveLogs.Tick
        pctLog1.Left = pctLog1.Left + 10
        pctLog2.Left = pctLog2.Left + 10
        pctLog3.Left = pctLog3.Left + 10
        pctLog4.Left = pctLog4.Left + 10
        pctLog5.Left = pctLog5.Left + 15
        pctLog6.Left = pctLog6.Left + 15
        pctLog7.Left = pctLog7.Left + 15


        If pctLog1.Left > frmFrogger.ActiveForm.Width Then
            pctLog1.Left = -pctLog1.Width
        End If

        If pctLog2.Left > frmFrogger.ActiveForm.Width Then
            pctLog2.Left = -pctLog2.Width
        End If

        If pctLog3.Left > frmFrogger.ActiveForm.Width Then
            pctLog3.Left = -pctLog3.Width
        End If

        If pctLog4.Left > frmFrogger.ActiveForm.Width Then
            pctLog4.Left = -pctLog4.Width
        End If

        If pctLog5.Left > frmFrogger.ActiveForm.Width Then
            pctLog5.Left = -pctLog5.Width
        End If

        If pctLog6.Left > frmFrogger.ActiveForm.Width Then
            pctLog6.Left = -pctLog6.Width
        End If

        If pctLog7.Left > frmFrogger.ActiveForm.Width Then
            pctLog7.Left = -pctLog7.Width
        End If

        If (pctFrog.Top = 150) Then
            If (((pctFrog.Left > pctLog1.Left And pctFrog.Left < pctLog1.Left + pctLog1.Width) Or pctLog1.Left > pctFrog.Left And pctLog1.Left < pctFrog.Left + pctFrog.Width)) Then
                moveFastFrog(10)

            ElseIf (((pctFrog.Left > pctLog2.Left And pctFrog.Left < pctLog2.Left + pctLog2.Width) Or pctLog2.Left > pctFrog.Left And pctLog2.Left < pctFrog.Left + pctFrog.Width)) Then
                moveFastFrog(10)

            ElseIf (((pctFrog.Left > pctLog3.Left And pctFrog.Left < pctLog3.Left + pctLog3.Width) Or pctLog3.Left > pctFrog.Left And pctLog3.Left < pctFrog.Left + pctFrog.Width)) Then
                moveFastFrog(10)

            ElseIf (((pctFrog.Left > pctLog4.Left And pctFrog.Left < pctLog4.Left + pctLog4.Width) Or pctLog4.Left > pctFrog.Left And pctLog4.Left < pctFrog.Left + pctFrog.Width)) Then
                moveFastFrog(10)
            Else
                Die()
            End If
        End If

        If (pctFrog.Top = 50) Then
            If (((pctFrog.Left > pctLog5.Left And pctFrog.Left < (pctLog5.Left + pctLog5.Width)) Or pctLog5.Left > pctFrog.Left And pctLog5.Left < (pctFrog.Left + pctFrog.Width))) Then
                moveFastFrog(15)

            ElseIf (((pctFrog.Left > pctLog6.Left And pctFrog.Left < (pctLog6.Left + pctLog6.Width)) Or pctLog6.Left > pctFrog.Left And pctLog6.Left < (pctFrog.Left + pctFrog.Width))) Then
                moveFastFrog(15)

            ElseIf (((pctFrog.Left > pctLog7.Left And pctFrog.Left < (pctLog7.Left + pctLog7.Width)) Or pctLog7.Left > pctFrog.Left And pctLog7.Left < (pctFrog.Left + pctFrog.Width))) Then
                moveFastFrog(15)
            Else
                Die()
            End If
        End If

    End Sub

    Private Sub tmrMoveTurtles_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveTurtles.Tick

        ' all three turtles moving left
        pctTurtle1.Left = pctTurtle1.Left - 10
        pctTurtle2.Left = pctTurtle2.Left - 10
        pctTurtle3.Left = pctTurtle3.Left - 10

        'all three turtles circling back around
        If pctTurtle1.Left + pctTurtle1.Width < 0 Then
            pctTurtle1.Left = frmFrogger.ActiveForm.Width
        End If
        If pctTurtle2.Left + pctTurtle2.Width < 0 Then
            pctTurtle2.Left = frmFrogger.ActiveForm.Width
        End If
        If pctTurtle3.Left + pctTurtle3.Width < 0 Then
            pctTurtle3.Left = frmFrogger.ActiveForm.Width
        End If

        If (pctFrog.Top = 100) Then
            If (((pctFrog.Left > pctTurtle1.Left And pctFrog.Left < pctTurtle1.Left + pctTurtle1.Width) Or pctTurtle1.Left > pctFrog.Left And pctTurtle1.Left < pctFrog.Left + pctFrog.Width)) Then
                MoveLeft()
            ElseIf (pctFrog.Top = 100) And (((pctFrog.Left > pctTurtle2.Left And pctFrog.Left < pctTurtle2.Left + pctTurtle2.Width) Or pctTurtle2.Left > pctFrog.Left And pctTurtle2.Left < pctFrog.Left + pctFrog.Width)) Then
                MoveLeft()
            ElseIf (pctFrog.Top = 100) And (((pctFrog.Left > pctTurtle3.Left And pctFrog.Left < pctTurtle3.Left + pctTurtle3.Width) Or pctTurtle3.Left > pctFrog.Left And pctTurtle3.Left < pctFrog.Left + pctFrog.Width)) Then
                MoveLeft()
            Else
                Die()
            End If
        End If

    End Sub
    Private Sub MoveLeft()
        pctFrog.Left = pctFrog.Left - 10
        If pctFrog.Left < 0 Then
            Die()
        End If
    End Sub

    Private Sub Die()
        pctFrog.Top = 400
        pctFrog.Left = 350
        lives = lives - 1
        Select Case lives
            Case 3 : pctFakeLife3.Visible = False
            Case 2 : pctFakeLife2.Visible = False
            Case 1 : pctFakeLife1.Visible = False
            Case 0 : winOrLose("You Lose!!!!!!")


        End Select
    End Sub

    Private Sub winOrLose(ByVal word As String)
        tmrMoveCars.Enabled = False
        tmrMoveTrucks.Enabled = False
        tmrMoveLogs.Enabled = False
        tmrMoveTurtles.Enabled = False
        MsgBox(word)
        answer = MsgBox("Play Again?", MsgBoxStyle.YesNo)
        If answer = 6 Then
            Reset()
        Else
            Close()
        End If
    End Sub
    Private Sub Reset()
        lives = 4
        wins = 0
        pctFrog.Top = 400
        pctFrog.Left = 350
        pctFakeLife1.Visible = True
        pctFakeLife2.Visible = True
        pctFakeLife3.Visible = True
        pctFakeSpot1.Visible = False
        pctFakeSpot2.Visible = False
        pctFakeSpot3.Visible = False
        tmrMoveCars.Enabled = True
        tmrMoveTrucks.Enabled = True
        tmrMoveLogs.Enabled = True
        tmrMoveTurtles.Enabled = True
    End Sub

    Private Sub frmFrogger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub moveFastFrog(ByVal x As Integer)
        pctFrog.Left = pctFrog.Left + x
        If (pctFrog.Left + pctFrog.Width) > frmFrogger.ActiveForm.Width Then
            Die()
        End If
    End Sub

    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click
        Reset()
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Close()
    End Sub

    Private Sub mnuIncreaseSpeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIncreaseSpeed.Click
        If tmrMoveCars.Interval > 10 Then
            tmrMoveCars.Interval = tmrMoveCars.Interval - 10
        End If

        If tmrMoveTrucks.Interval > 10 Then
            tmrMoveTrucks.Interval = tmrMoveTrucks.Interval - 10
        End If

        If tmrMoveLogs.Interval > 10 Then
            tmrMoveLogs.Interval = tmrMoveLogs.Interval - 10
        End If

        If tmrMoveTurtles.Interval > 10 Then
            tmrMoveTurtles.Interval = tmrMoveTurtles.Interval - 10
        End If
    End Sub
    Private Sub mnuDecreaseSpeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDecreaseSpeed.Click
        tmrMoveCars.Interval = tmrMoveCars.Interval + 10
        tmrMoveTrucks.Interval = tmrMoveTrucks.Interval + 10
        tmrMoveLogs.Interval = tmrMoveLogs.Interval + 10
        tmrMoveTurtles.Interval = tmrMoveTurtles.Interval + 10
    End Sub

    Private Sub mnuOriginalSpeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOriginalSpeed.Click
        tmrMoveCars.Interval = 100
        tmrMoveTrucks.Interval = 80
        tmrMoveLogs.Interval = 70
        tmrMoveTurtles.Interval = 100
    End Sub









    Private Sub pctCar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCar2.Click

    End Sub
