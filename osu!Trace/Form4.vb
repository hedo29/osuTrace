Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "v" + Application.ProductVersion
    End Sub
End Class