Public Class Form1
    Dim jogadas(9) As Integer
    Dim matriz(9) As Integer
    Dim quadrados As PictureBox
End Class
Sub Imagem(quadro)
    Dim fig As New PictureBox
    Select Case matriz(quadro)
        Case 0 : fig.BackgroundImage = My.Resources
        Case 1 : fig.BackgroundImage = My.Resources
        Case 2 : fig.BackgroundImage = My.Resources
        Case 3 : fig.BackgroundImage = My.Resources
        Case 4 : fig.BackgroundImage = My.Resources
        Case 5 : fig.BackgroundImage = My.Resources
    End Select