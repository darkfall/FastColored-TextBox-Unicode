Public Class MainForm

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim form As PowerfulSample = New PowerfulSample()
        Form.ShowDialog()
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        Dim form As AutocompleteSample = New AutocompleteSample()
        form.ShowDialog()
    End Sub

    Private Sub button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button16.Click
        Dim form As BookmarksSample = New BookmarksSample()
        form.ShowDialog()
    End Sub

    Private Sub button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button15.Click
        Dim form As AutoIndentSample = New AutoIndentSample()
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form As AutocompleteSample2 = New AutocompleteSample2()
        form.ShowDialog()
    End Sub
End Class