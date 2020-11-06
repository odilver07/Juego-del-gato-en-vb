Public Class Form1
    Dim matriz(2, 2) As Integer
    Public jugadorX = 0
    Dim opcion
    Dim empate = 0
    Public jugadorO = 0
    Dim turno = 1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If turno = 1 Then
            Button1.Image = My.Resources.x
            Button1.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(0, 1) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button1.Image = My.Resources.o
            Button1.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(0, 1) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If turno = 1 Then
            Button5.Image = My.Resources.x
            Button5.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(0, 2) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button5.Image = My.Resources.o
            Button5.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(0, 2) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If turno = 1 Then
            Button6.Image = My.Resources.x
            Button6.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(1, 0) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button6.Image = My.Resources.o
            Button6.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(1, 0) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If turno = 1 Then
            Button2.Image = My.Resources.x
            Button2.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(1, 1) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button2.Image = My.Resources.o
            Button2.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(1, 1) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If turno = 1 Then
            Button4.Image = My.Resources.x
            Button4.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(1, 2) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button4.Image = My.Resources.o
            Button4.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(1, 2) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turno = 1 Then
            Button7.Image = My.Resources.x
            Button7.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(0, 0) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button7.Image = My.Resources.o
            Button7.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(0, 0) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If turno = 1 Then
            Button8.Image = My.Resources.x
            Button8.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(2, 0) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 1 Then
            Button8.Image = My.Resources.o
            Button8.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del x"
            matriz(2, 0) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If turno = 1 Then
            Button3.Image = My.Resources.x
            Button3.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(2, 1) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button3.Image = My.Resources.o
            Button3.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(2, 1) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If turno = 1 Then
            Button9.Image = My.Resources.x
            Button9.Enabled = False
            turno = 0
            Label1.Text = "Es el turno del O"
            matriz(2, 2) = 1
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        ElseIf turno = 0 Then
            Button9.Image = My.Resources.o
            Button9.Enabled = False
            turno = 1
            Label1.Text = "Es el turno del x"
            matriz(2, 2) = 2
            empate = empate + 1
            My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
        End If

        ganar(matriz)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Jugador X :" + Convert.ToString(jugadorX)
        Label3.Text = "Jugador O :" + Convert.ToString(jugadorO)
    End Sub
    Public Function ganar(matriz(,) As Integer)
        If matriz(0, 0) = 1 And matriz(0, 1) = 1 And matriz(0, 2) = 1 Or
            matriz(0, 0) = 1 And matriz(1, 0) = 1 And matriz(2, 0) = 1 Or
            matriz(1, 0) = 1 And matriz(1, 1) = 1 And matriz(1, 2) = 1 Or
            matriz(2, 0) = 1 And matriz(2, 1) = 1 And matriz(2, 2) = 1 Or
            matriz(0, 1) = 1 And matriz(1, 1) = 1 And matriz(2, 1) = 1 Or
            matriz(0, 2) = 1 And matriz(1, 2) = 1 And matriz(2, 2) = 1 Or
            matriz(0, 0) = 1 And matriz(1, 1) = 1 And matriz(2, 2) = 1 Or
            matriz(0, 2) = 1 And matriz(1, 1) = 1 And matriz(2, 0) = 1 Then
            jugadorX = jugadorX + 1
            Label2.Text = "Jugador X: " + Convert.ToString(jugadorX)
            opcion = MsgBox("Gano el jugador X", MsgBoxStyle.OkCancel)
            reiniciar(opcion)
        ElseIf matriz(0, 0) = 2 And matriz(0, 1) = 2 And matriz(0, 2) = 2 Or
            matriz(0, 0) = 2 And matriz(1, 0) = 2 And matriz(2, 0) = 2 Or
            matriz(1, 0) = 2 And matriz(1, 1) = 2 And matriz(1, 2) = 2 Or
            matriz(2, 0) = 2 And matriz(2, 1) = 2 And matriz(2, 2) = 2 Or
            matriz(0, 1) = 2 And matriz(1, 1) = 2 And matriz(2, 1) = 2 Or
            matriz(0, 2) = 2 And matriz(1, 2) = 2 And matriz(2, 2) = 2 Or
            matriz(0, 0) = 2 And matriz(1, 1) = 2 And matriz(2, 2) = 2 Or
            matriz(0, 2) = 2 And matriz(1, 1) = 2 And matriz(2, 0) = 2 Then
            jugadorO = jugadorO + 1
            Label3.Text = "Jugador O: " + Convert.ToString(jugadorO)
            opcion = MsgBox("Gano el jugador O", MsgBoxStyle.OkCancel)
            reiniciar(opcion)
        ElseIf empate = 9 Then
            opcion = MsgBox("¡Empate! ¿Desea reiniciar el juego?", MsgBoxStyle.OkCancel)
            reiniciar(opcion)
        End If
    End Function
    Public Function reiniciar(opcion)
        If opcion = MsgBoxResult.Ok Then
            Button7.Image = My.Resources.fondoboton
            Button7.Enabled = True
            Button1.Image = My.Resources.fondoboton
            Button1.Enabled = True
            Button5.Image = My.Resources.fondoboton
            Button5.Enabled = True
            Button6.Image = My.Resources.fondoboton
            Button6.Enabled = True
            Button2.Image = My.Resources.fondoboton
            Button2.Enabled = True
            Button4.Image = My.Resources.fondoboton
            Button4.Enabled = True
            Button8.Image = My.Resources.fondoboton
            Button8.Enabled = True
            Button3.Image = My.Resources.fondoboton
            Button3.Enabled = True
            Button9.Image = My.Resources.fondoboton
            Button9.Enabled = True
            empate = 0
            Erase matriz
            ReDim matriz(2, 2)
        ElseIf opcion = MsgBoxResult.Cancel Then
            Me.Close()
        End If
    End Function

End Class
