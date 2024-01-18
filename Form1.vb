Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Add the word to the ListBox
        If Not String.IsNullOrWhiteSpace(txtWord.Text) Then

            lstWords.Items.Add(txtWord.Text)
            txtWord.Clear()

        End If

    End Sub

    Private Sub btnToUpperCase_Click(sender As Object, e As EventArgs) Handles btnToUpperCase.Click

        ' Change the selected word to uppercase

        If lstWords.SelectedIndex <> -1 Then

            lstWords.Items(lstWords.SelectedIndex) = lstWords.SelectedItem.ToString().ToUpper()

        End If

    End Sub

    Private Sub btnToLowerCase_Click(sender As Object, e As EventArgs) Handles btnToLowerCase.Click

        ' Change the selected word to lowercase

        If lstWords.SelectedIndex <> -1 Then

            lstWords.Items(lstWords.SelectedIndex) = lstWords.SelectedItem.ToString().ToLower()

        End If

    End Sub

    Private Sub lstWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWords.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        ' Delete the selected word

        If lstWords.SelectedIndex <> -1 Then

            lstWords.Items.RemoveAt(lstWords.SelectedIndex)

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear the form

        txtWord.Clear()
        lstWords.Items.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
