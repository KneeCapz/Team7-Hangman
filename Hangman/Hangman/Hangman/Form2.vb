Public Class Form2
    Dim losningsOrd As String
    Dim bokstav As Char

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32

    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt2.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

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

        Dim svar As String = ""
        Dim i As Integer
        Dim x As Boolean = False
        Dim lengdeOrd As Integer = losningsOrd.Length - 1
        lblTest3.Text = lengdeOrd

        Dim Count As Integer = 0
        For Each Character As Char In losningsOrd
            If Character = bokstav Then
                temp.Chars(Count) = Character
                x = True
                Count = +1
            Else
                Count = +1
            End If
        Next
        lblSvar.Text = temp.ToString()

        If x = False Then
            lblRettGalt.Text = "GALT"
            lblTest2.Text = "feil kjøres"
        End If

    End Sub
    'Henter det inntastede ordet og lagrer det, og lager en string med antall _ lik løsningsordet
    Private Sub btnBekreftord_Click(sender As Object, e As EventArgs) Handles btnBekreftord.Click

        losningsOrd = txtLosningsOrd.Text
        lblSvar.Text = ""
        txtLosningsOrd.Hide()
        btnBekreftord.Hide()

        Dim temp As New System.Text.StringBuilder
        For Each Character As Char In losningsOrd
            temp.Append("_")
        Next

        lblSvar.Text = temp.ToString

    End Sub

    'tømmer alle felt og viser knapper for bekreft ord, løsningsord. Setter løsningsord og bokstav til null
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNullstill.Click

        btnBekreftord.Show()
        txtLosningsOrd.Show()
        txtLosningsOrd.Text = Nothing
        txtBokstav.Text = Nothing
        lblSvar.Text = "**********"
        losningsOrd = Nothing
        bokstav = Nothing
        lblTest.Text = "test1"
        lblTest2.Text = "test2"
        lblTest3.Text = "test3"

    End Sub


End Class