Dim counter As Integer
        Dim strResults As String = ""
        Dim sngScores As Single = 0
        Dim sngAverage As Single = 0
        Dim sngListCount As Single = 0

        'The number of items on the list is assigned to intListCount
        sngListCount = Convert.ToSingle(lstStudentInfo.Items.Count)

        'This for loop will iterate through each item in the list
        For counter = 0 To sngListCount - 1

            'Converts the student's score at the location of counter in the list and removes the percent sign
            sngScores = Convert.ToSingle(lstStudentInfo.Items(counter).SubItems(1).Text.Replace("%", ""))
            'Adds the scores to the average
            sngAverage += sngScores

        Next

        'Sets the average
        sngAverage = sngAverage / sngListCount

        'Outputs the results to a message box 
        strResults = "The average score is: " & Format(sngAverage, "0.00") & "%" & ControlChars.NewLine
        strResults &= "The number of scores: " & sngListCount
        MessageBox.Show(strResults, "Average Score")
