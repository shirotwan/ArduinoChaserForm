Imports System.ComponentModel.Design.Serialization
Imports System.Data.Common

Public Class Form1
    Dim ingame As Boolean
    Dim t As Integer
    Public Function Restart()
        Cat.Location = New Point(500, 250)
        Sprite1.Location = New Point(12, 250)
        Meta.Location = New Point(570, 400 * Rnd())
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ingame = True Then
            Dim vex As Double
            Dim vey As Double
            Dim dist As Double
            Dim pasox As Double
            Dim pasoy As Double

            Dim vel As Integer
            vel = Val(Level.Text) * 2

            t = 0

            vex = (Val(Sprite1.Location.X) - Val(Cat.Location.X))
            vey = (Val(Sprite1.Location.Y) - Val(Cat.Location.Y))
            dist = (vex * vex + vey * vey) ^ (0.5)

            pasox = vel * (vex / dist)
            pasoy = vel * (vey / dist)

            If dist > 20 Then
                Cat.Location = New Point(Cat.Location.X + pasox, Cat.Location.Y + pasoy)
                t += 1
            Else
                Restart()
                ingame = False
                MsgBox("Fin del juego")
            End If

            Dim ladox As Integer
            Dim ladoy As Integer

            Dim sigx As Integer
            Dim sigy As Integer

            Dim chanx As Integer
            Dim chany As Integer

            Dim velp As Integer

            velp = 5 * Level.Text ^ 0.5

            ladox = (Val(Mid(SerialPort1.ReadLine, 1, 3)) - 100) / 100
            ladoy = (Val(Mid(SerialPort1.ReadLine, 7, 3)) - 100) / 100
            sigx = Val(Mid(SerialPort1.ReadLine, 5, 1))
            sigy = Val(Mid(SerialPort1.ReadLine, 11, 1))

            Select Case sigx
                Case 0
                    chanx = velp * ladox * (-1)
                Case 1
                    chanx = velp * ladox
            End Select

            Select Case sigy
                Case 0
                    chany = velp * ladoy * (-1)
                Case 1
                    chany = velp * ladoy
            End Select

            Sprite1.Location = New Point(Sprite1.Location.X + chanx, Sprite1.Location.Y + chany)

            Dim srx As Integer
            Dim sry As Integer
            Dim detect As Integer

            srx = (Val(Sprite1.Location.X) - Val(Meta.Location.X))
            sry = (Val(Sprite1.Location.Y) - Val(Meta.Location.Y))
            detect = (srx * srx + sry * sry) ^ (0.5)

            If detect < 20 Then
                Restart()
                Level.Text += 1
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
        Timer1.Enabled = True
        Timer1.Interval = 10
        Level.Text = 1
        Restart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ingame = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        SerialPort1.Close()
    End Sub
End Class
