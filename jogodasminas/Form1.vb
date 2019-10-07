Public Class Form1
    Dim jogadas(9) As Integer
    Dim Matriz(9) As Integer
    Dim quadrados As PictureBox
End Class
Sub Imagem(quadro)
    Dim fig As New PictureBox
    Select Case Matriz(quadro)
        Case 0 : fig.BackgroundImage = My.Resources.f1
        Case 1 : fig.BackgroundImage = My.Resources.f2
        Case 2 : fig.BackgroundImage = My.Resources.f3
        Case 3 : fig.BackgroundImage = My.Resources.f4
        Case 4 : fig.BackgroundImage = My.Resources.f5
        Case 5 : fig.BackgroundImage = My.Resources.f6
    End Select
    Quadros(quadro).BackgroundImage = fig.BackgroundImage
    Refresh()
    Threading.Thread.Sleep(500)
    Jogadas(quadro) = 1
    If Passo = 1 Then : Anterior = quadro
    ElseIf Matriz(quadro) <> Matriz(Anterior) Then
        Jogadas(quadro) = 0
        Jogadas(Anterior) = 0
        Quadros(quadro).BackgroundImage = My.Resources.Nada
        Quadros(Anterior).BackgroundImage = My.Resources.Nada
    End If

End Sub
Sub Inicializa()
    Dim i As Integer
    For i = 0 To 11
        Quadros(i).BackgroundImage = My.Resources.Nada
        Matriz(i) = 0
        Jogadas(i) = 0
    Next

    For par = 0 To 5
        For x = 0 To 1
            Do : i = Int(Rnd() * 12)
            Loop While Matriz(i)
            Matriz(i) = par
        Next
    Next

    Passo = 1
End Sub
Private Sub clicar(sender As Object, e As EventArgs) Handles