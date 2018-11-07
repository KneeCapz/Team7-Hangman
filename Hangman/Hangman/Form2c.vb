Public Class Form2
    Dim losningsOrd As String
    Dim bokstav As Char
    Dim letterpos As Integer = 0



    Private Declare Function HideCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTest.Visible = False
        lblTest2.Visible = False
        lblTest3.Visible = False
        lblRettGalt.Visible = False


        'BackgroundImage = My.Resources.spill_start
        PictureBox1.Image = My.Resources.spill_start






    End Sub

    'avslutter spillet
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt2.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    'tilbake til meny
    Private Sub btnTilmeny_Click(sender As Object, e As EventArgs) Handles btnTilmeny.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub txtBokstav_TextChanged(sender As Object, e As EventArgs) Handles txtBokstav.TextChanged
        Call HideCaret(txtBokstav.Handle)
    End Sub

    Dim temp As New System.Text.StringBuilder



    'Sjekker inntastet bokstav mot bokstaver i løsningsord og skriver rett eller galt og fyller ut eventuelt rett bokstav i ordet, eller legger til på hangman
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSjekkbokstav.Click

        bokstav = txtBokstav.Text
        'teller = lblSvar.Text

        Dim lengdeOrd As Integer = losningsOrd.Length()
        lblTest3.Text = lengdeOrd

        'sjekker om bokstaven finnes i ordet, om ikke legges bokstaven til linjen for brukte bokstaver
        If losningsOrd.Contains(bokstav) = False Then
            If lblGjettetbokstav.Text.Contains(bokstav) Then

            Else
                lblGjettetbokstav.Text &= bokstav
            End If


            'kjøres om bokstaven finnes i ordet. sjekker fra bokstav 1 og gjennom hele ordet. Bytter ut "?" med bokstav i rett posisjon i label med skjult ord
        Else
            letterpos = 0
            Do While InStr(letterpos + 1, losningsOrd, bokstav) > 0
                letterpos = InStr(letterpos + 1, losningsOrd, bokstav)
                'MsgBox(letterpos)
                Mid(lblSvar.Text, letterpos, 1) = bokstav
            Loop

        End If



        If lblSvar.Text.Contains("?") Then
        Else MsgBox("Du vant!")
        End If



        'If x = True Then
        'lblRettGalt.Text = "rett"
        'lblTest.Text = "rett kjøres"
        'End If

        'If x = False Then
        'lblRettGalt.Text = "GALT"
        'lblTest2.Text = "feil kjøres"
        'End If

    End Sub

    'Henter det inntastede ordet og lagrer det, og lager en string med antall "?" lik løsningsordet som skrives til label
    Private Sub btnBekreftord_Click(sender As Object, e As EventArgs) Handles btnBekreftord.Click

        losningsOrd = txtLosningsOrd.Text
        lblSvar.Text = ""
        txtLosningsOrd.Hide()
        btnBekreftord.Hide()

        Dim temp As New System.Text.StringBuilder
        For Each Character As Char In losningsOrd
            temp.Append("?")
        Next

        lblSvar.Text = temp.ToString

    End Sub

    'tømmer alle felt og viser knapper for bekreft ord, løsningsord. Setter løsningsord og bokstav til null
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNullstill.Click

        btnBekreftord.Show()
        txtLosningsOrd.Show()
        txtLosningsOrd.Text = Nothing
        txtBokstav.Text = Nothing
        lblSvar.Text = "?"
        losningsOrd = Nothing
        bokstav = Nothing
        lblGjettetbokstav.Text = ""
        lblTest.Text = "test1"
        lblTest2.Text = "test2"
        lblTest3.Text = "test3"

    End Sub

    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        If btnLyd.Text() = "Lyd Av" Then
            btnLyd.Text() = "Lyd På"
            My.Computer.Audio.Stop() ' stopper melodien

        ElseIf btnLyd.Text() = "Lyd På" Then
            btnLyd.Text() = "Lyd Av"
            My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.BackgroundLoop) 'starter avspilling igjen.
        End If
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub








    ' for å telle bokstaver i en string =  TextBox1.Text.Count(Function(x) Char.IsLetter(x) = True)






End Class