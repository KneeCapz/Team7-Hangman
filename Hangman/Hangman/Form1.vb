﻿Public Class Form1

    Dim bak1 As Image
    Dim bak2 As Image
    Public Shared teller As Integer = 1

    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bak1 = New Bitmap(Image.FromFile("E:\Dropbox\IT NTNU\teamarbeid\prosjekt\Spill\Hangman\hangman.jpg"))
        bak2 = New Bitmap(Image.FromFile("E:\Dropbox\IT NTNU\teamarbeid\prosjekt\Spill\Hangman\hangman2.jpg"))

    End Sub

    Private Sub btnBakgrunn_Click(sender As Object, e As EventArgs) Handles btnBakgrunn.Click


        If teller = 1 Then
            Me.BackgroundImage = bak1
            teller = teller + 1
        ElseIf teller = 2 Then
            Me.BackgroundImage = bak2
            teller = 1
        End If

        'Me.BackgroundImage = bak1

        If Me.BackgroundImage Is bak1 Then
            Me.BackgroundImage = bak2
        ElseIf Me.BackgroundImage Is bak2 Then
            Me.BackgroundImage = bak1
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblRegler.Click



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        If btnLyd.Text() = "Lyd Av" Then
            btnLyd.Text() = "Lyd På"
        ElseIf btnLyd.Text() = "Lyd På" Then
            btnLyd.Text() = "Lyd Av"
        End If
    End Sub
End Class
