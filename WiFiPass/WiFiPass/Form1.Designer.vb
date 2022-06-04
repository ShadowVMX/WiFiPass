<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWIFI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CMDSTART = New System.Windows.Forms.Button()
        Me.CMDLEAVE = New System.Windows.Forms.Button()
        Me.LBLTEXT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CMDSTART
        '
        Me.CMDSTART.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CMDSTART.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSTART.Location = New System.Drawing.Point(12, 115)
        Me.CMDSTART.Name = "CMDSTART"
        Me.CMDSTART.Size = New System.Drawing.Size(171, 34)
        Me.CMDSTART.TabIndex = 0
        Me.CMDSTART.Text = "START"
        Me.CMDSTART.UseVisualStyleBackColor = False
        '
        'CMDLEAVE
        '
        Me.CMDLEAVE.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CMDLEAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDLEAVE.Location = New System.Drawing.Point(333, 115)
        Me.CMDLEAVE.Name = "CMDLEAVE"
        Me.CMDLEAVE.Size = New System.Drawing.Size(171, 34)
        Me.CMDLEAVE.TabIndex = 1
        Me.CMDLEAVE.Text = "LEAVE"
        Me.CMDLEAVE.UseVisualStyleBackColor = False
        '
        'LBLTEXT
        '
        Me.LBLTEXT.AutoSize = True
        Me.LBLTEXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTEXT.Location = New System.Drawing.Point(63, 28)
        Me.LBLTEXT.Name = "LBLTEXT"
        Me.LBLTEXT.Size = New System.Drawing.Size(406, 27)
        Me.LBLTEXT.TabIndex = 2
        Me.LBLTEXT.Text = "What's my WiFi proffile PASSWORD?"
        '
        'FrmWIFI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 161)
        Me.Controls.Add(Me.LBLTEXT)
        Me.Controls.Add(Me.CMDLEAVE)
        Me.Controls.Add(Me.CMDSTART)
        Me.Name = "FrmWIFI"
        Me.Text = "Network Interface Keys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDSTART As System.Windows.Forms.Button
    Friend WithEvents CMDLEAVE As System.Windows.Forms.Button
    Friend WithEvents LBLTEXT As System.Windows.Forms.Label

End Class
