<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAvslutt2 = New System.Windows.Forms.Button()
        Me.btnTilmeny = New System.Windows.Forms.Button()
        Me.txtBokstav = New System.Windows.Forms.TextBox()
        Me.btnSjekkbokstav = New System.Windows.Forms.Button()
        Me.txtLosningsOrd = New System.Windows.Forms.TextBox()
        Me.lblSvar = New System.Windows.Forms.Label()
        Me.lblRettGalt = New System.Windows.Forms.Label()
        Me.btnBekreftord = New System.Windows.Forms.Button()
        Me.btnNullstill = New System.Windows.Forms.Button()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lblTest2 = New System.Windows.Forms.Label()
        Me.lblTest3 = New System.Windows.Forms.Label()
        Me.lblGjettetbokstav = New System.Windows.Forms.Label()
        Me.lblOverskriftinput = New System.Windows.Forms.Label()
        Me.lblOverskriftbokstav = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAvslutt2
        '
        Me.btnAvslutt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAvslutt2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAvslutt2.FlatAppearance.BorderSize = 3
        Me.btnAvslutt2.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt2.Location = New System.Drawing.Point(802, 485)
        Me.btnAvslutt2.Name = "btnAvslutt2"
        Me.btnAvslutt2.Size = New System.Drawing.Size(150, 40)
        Me.btnAvslutt2.TabIndex = 5
        Me.btnAvslutt2.Text = "Avslutt"
        Me.btnAvslutt2.UseVisualStyleBackColor = False
        '
        'btnTilmeny
        '
        Me.btnTilmeny.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTilmeny.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTilmeny.FlatAppearance.BorderSize = 3
        Me.btnTilmeny.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilmeny.Location = New System.Drawing.Point(802, 35)
        Me.btnTilmeny.Name = "btnTilmeny"
        Me.btnTilmeny.Size = New System.Drawing.Size(150, 40)
        Me.btnTilmeny.TabIndex = 6
        Me.btnTilmeny.Text = "Til meny"
        Me.btnTilmeny.UseVisualStyleBackColor = False
        '
        'txtBokstav
        '
        Me.txtBokstav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBokstav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBokstav.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBokstav.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtBokstav.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBokstav.Location = New System.Drawing.Point(99, 458)
        Me.txtBokstav.MaxLength = 1
        Me.txtBokstav.Name = "txtBokstav"
        Me.txtBokstav.Size = New System.Drawing.Size(75, 85)
        Me.txtBokstav.TabIndex = 7
        Me.txtBokstav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSjekkbokstav
        '
        Me.btnSjekkbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSjekkbokstav.Location = New System.Drawing.Point(205, 503)
        Me.btnSjekkbokstav.Name = "btnSjekkbokstav"
        Me.btnSjekkbokstav.Size = New System.Drawing.Size(75, 40)
        Me.btnSjekkbokstav.TabIndex = 8
        Me.btnSjekkbokstav.Text = "OK"
        Me.btnSjekkbokstav.UseVisualStyleBackColor = True
        '
        'txtLosningsOrd
        '
        Me.txtLosningsOrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLosningsOrd.Location = New System.Drawing.Point(554, 128)
        Me.txtLosningsOrd.MaxLength = 10
        Me.txtLosningsOrd.Name = "txtLosningsOrd"
        Me.txtLosningsOrd.Size = New System.Drawing.Size(100, 20)
        Me.txtLosningsOrd.TabIndex = 9
        '
        'lblSvar
        '
        Me.lblSvar.AutoSize = True
        Me.lblSvar.Location = New System.Drawing.Point(96, 384)
        Me.lblSvar.Name = "lblSvar"
        Me.lblSvar.Size = New System.Drawing.Size(0, 13)
        Me.lblSvar.TabIndex = 10
        '
        'lblRettGalt
        '
        Me.lblRettGalt.AutoSize = True
        Me.lblRettGalt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRettGalt.Location = New System.Drawing.Point(680, 395)
        Me.lblRettGalt.Name = "lblRettGalt"
        Me.lblRettGalt.Size = New System.Drawing.Size(50, 13)
        Me.lblRettGalt.TabIndex = 11
        Me.lblRettGalt.Text = "rett / galt"
        '
        'btnBekreftord
        '
        Me.btnBekreftord.Location = New System.Drawing.Point(554, 164)
        Me.btnBekreftord.Name = "btnBekreftord"
        Me.btnBekreftord.Size = New System.Drawing.Size(75, 23)
        Me.btnBekreftord.TabIndex = 12
        Me.btnBekreftord.Text = "Bekreft ord"
        Me.btnBekreftord.UseVisualStyleBackColor = True
        '
        'btnNullstill
        '
        Me.btnNullstill.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNullstill.Location = New System.Drawing.Point(802, 113)
        Me.btnNullstill.Name = "btnNullstill"
        Me.btnNullstill.Size = New System.Drawing.Size(150, 40)
        Me.btnNullstill.TabIndex = 13
        Me.btnNullstill.Text = "Nullstill alt"
        Me.btnNullstill.UseVisualStyleBackColor = True
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(680, 432)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(46, 13)
        Me.lblTest.TabIndex = 14
        Me.lblTest.Text = "testlabel"
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.Location = New System.Drawing.Point(680, 471)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(52, 13)
        Me.lblTest2.TabIndex = 15
        Me.lblTest2.Text = "testlabel2"
        '
        'lblTest3
        '
        Me.lblTest3.AutoSize = True
        Me.lblTest3.Location = New System.Drawing.Point(680, 512)
        Me.lblTest3.Name = "lblTest3"
        Me.lblTest3.Size = New System.Drawing.Size(52, 13)
        Me.lblTest3.TabIndex = 16
        Me.lblTest3.Text = "testlabel3"
        '
        'lblGjettetbokstav
        '
        Me.lblGjettetbokstav.AutoSize = True
        Me.lblGjettetbokstav.Location = New System.Drawing.Point(202, 458)
        Me.lblGjettetbokstav.Name = "lblGjettetbokstav"
        Me.lblGjettetbokstav.Size = New System.Drawing.Size(0, 13)
        Me.lblGjettetbokstav.TabIndex = 17
        '
        'lblOverskriftinput
        '
        Me.lblOverskriftinput.AutoSize = True
        Me.lblOverskriftinput.Location = New System.Drawing.Point(551, 100)
        Me.lblOverskriftinput.Name = "lblOverskriftinput"
        Me.lblOverskriftinput.Size = New System.Drawing.Size(78, 13)
        Me.lblOverskriftinput.TabIndex = 18
        Me.lblOverskriftinput.Text = "Skriv inn et ord"
        '
        'lblOverskriftbokstav
        '
        Me.lblOverskriftbokstav.AutoSize = True
        Me.lblOverskriftbokstav.Location = New System.Drawing.Point(96, 432)
        Me.lblOverskriftbokstav.Name = "lblOverskriftbokstav"
        Me.lblOverskriftbokstav.Size = New System.Drawing.Size(104, 13)
        Me.lblOverskriftbokstav.TabIndex = 19
        Me.lblOverskriftbokstav.Text = "Skriv inn en bokstav"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.lblOverskriftbokstav)
        Me.Controls.Add(Me.lblOverskriftinput)
        Me.Controls.Add(Me.lblGjettetbokstav)
        Me.Controls.Add(Me.lblTest3)
        Me.Controls.Add(Me.lblTest2)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.btnNullstill)
        Me.Controls.Add(Me.btnBekreftord)
        Me.Controls.Add(Me.lblRettGalt)
        Me.Controls.Add(Me.lblSvar)
        Me.Controls.Add(Me.txtLosningsOrd)
        Me.Controls.Add(Me.btnSjekkbokstav)
        Me.Controls.Add(Me.txtBokstav)
        Me.Controls.Add(Me.btnTilmeny)
        Me.Controls.Add(Me.btnAvslutt2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAvslutt2 As Button
    Friend WithEvents btnTilmeny As Button
    Friend WithEvents txtBokstav As TextBox
    Friend WithEvents btnSjekkbokstav As Button
    Friend WithEvents txtLosningsOrd As TextBox
    Friend WithEvents lblSvar As Label
    Friend WithEvents lblRettGalt As Label
    Friend WithEvents btnBekreftord As Button
    Friend WithEvents btnNullstill As Button
    Friend WithEvents lblTest As Label
    Friend WithEvents lblTest2 As Label
    Friend WithEvents lblTest3 As Label
    Friend WithEvents lblGjettetbokstav As Label
    Friend WithEvents lblOverskriftinput As Label
    Friend WithEvents lblOverskriftbokstav As Label
End Class
