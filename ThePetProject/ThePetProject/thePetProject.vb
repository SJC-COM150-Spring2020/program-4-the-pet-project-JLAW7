Public Class Pet

    'Define and initialize program

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click

        'Dim and initialize I as String, and A, B, C, and D as Integers 

        Dim I As String

        Dim A, B, C, D As Integer

        'Letting Inputbox equal I and inputting a Do until loop with If Then, If Else statements including message boxes. Then ouputing total votes to listbox

        Do
            I = InputBox("Type the Letter You wish to vote for. Then click ok.")
            If (I = "A") Then
                A = A + 1
            ElseIf (I = "B") Then
                B = B + 1
            ElseIf (I = "C") Then
                C = C + 1
            ElseIf (I = "D") Then
                D = D + 1
            ElseIf (I = "E") Then
                MessageBox.Show("Thank you for your votes! ")
            ElseIf (I = "") Then
                MessageBox.Show("Please input the letter associated with your animal, then click ""ok"". ")
            Else
                MessageBox.Show("I'm sorry, that is not a valid choice. Please try again.")
            End If
        Loop Until (I = "E")
        lstOut.Items.Add("Dog Votes " & A)
        lstOut.Items.Add("Cat Votes " & B)
        lstOut.Items.Add("Fish Votes " & C)
        lstOut.Items.Add("Bird Votes " & D)

        'After loop, placing additional If Then, elseIf statements comparing totals and listing winner into listbox revealing winner with a picture
        'In addition, inlcuding scenarios where ties occur and asking user to correct issue with additional voting


        If (A > B And A > C And A > D) Then
            lstOut.Items.Add("The winner is Dog!")
            picDog.Visible = True
            picCat.Visible = False
            picFish.Visible = False
            picBird.Visible = False
        ElseIf (B > A And B > C And B > D) Then
            lstOut.Items.Add("The winner is Cat!")
            picCat.Visible = True
            picDog.Visible = False
            picFish.Visible = False
            picBird.Visible = False
        ElseIf (C > A And C > B And C > D) Then
            lstOut.Items.Add("The winner is Fish!")
            picFish.Visible = True
            picCat.Visible = False
            picDog.Visible = False
            picBird.Visible = False
        ElseIf (D > A And D > B And D > C) Then
            lstOut.Items.Add("The winner is Bird!")
            picBird.Visible = True
            picCat.Visible = False
            picFish.Visible = False
            picDog.Visible = False
        ElseIf (A = B And A > C And A > D) Then
            lstOut.Items.Add("We have a tie between Dog and Cat!")
            lstOut.Items.Add("Next User, please place your vote for Dog or Cat to break the tie.")
        ElseIf (A = C And A > B And A > D) Then
            lstOut.Items.Add("We have a tie between Dog and Fish!")
            lstOut.Items.Add("Next User, please place your vote for Dog or Fish to break the tie.")
        ElseIf (A = D And A > B And A > C) Then
            lstOut.Items.Add("We have a tie between Dog and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Dog or Bird to break the tie.")
        ElseIf (B = C And B > A And B > D) Then
            lstOut.Items.Add("We have a tie between Cat and Fish!")
            lstOut.Items.Add("Next User, please place your vote for Cat or Fish to break the tie.")
        ElseIf (B = D And B > A And B > C) Then
            lstOut.Items.Add("We have a tie between Cat and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Cat or Bird to break the tie.")
        ElseIf (C = D And C > A And C > D) Then
            lstOut.Items.Add("We have a tie between Fish and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Fish or Bird to break the tie.")
        ElseIf (A = B And A = C And A > D) Then
            lstOut.Items.Add("We have a 3-Way tie between Dog, Cat, and Fish!")
            lstOut.Items.Add("Next User, please place your vote for Dog, Cat, or Fish to break the tie.")
        ElseIf (A = B And A = D And A > C) Then
            lstOut.Items.Add("We have a 3-way tie between Dog, Cat, and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Dog, Cat, or Bird to break the tie.")
        ElseIf (A = C And A = D And A > B) Then
            lstOut.Items.Add("We have a 3-way tie between Dog, Fish, and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Dog, Fish, or Bird to break the tie.")
        ElseIf (B = C And B = D And B > A) Then
            lstOut.Items.Add("We have a 3-way tie between Cat, Fish, and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Cat, Fish, or Bird to break the tie.")
        ElseIf (A = B And A = C And A = D) Then
            lstOut.Items.Add("We have a 4-way tie between Dog, Cat, Fish, and Bird!")
            lstOut.Items.Add("Next User, please place your vote for Dog, Cat, Fish, or Bird to break the tie.")
        End If

    End Sub

    'Initialize clear button for list box

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lstOut.Items.Clear()

    End Sub

    'initailize exit button for program

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Beep()
        Application.Exit()
    End Sub
End Class
