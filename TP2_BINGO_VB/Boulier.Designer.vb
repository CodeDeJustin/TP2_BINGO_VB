<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Boulier
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LbL_B = New System.Windows.Forms.Label()
        Me.Lbl_I = New System.Windows.Forms.Label()
        Me.Lbl_N = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbL_B
        '
        Me.LbL_B.BackColor = System.Drawing.Color.CadetBlue
        Me.LbL_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbL_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_B.Location = New System.Drawing.Point(3, 2)
        Me.LbL_B.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbL_B.Name = "LbL_B"
        Me.LbL_B.Size = New System.Drawing.Size(52, 47)
        Me.LbL_B.TabIndex = 0
        Me.LbL_B.Text = "B"
        Me.LbL_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_I
        '
        Me.Lbl_I.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_I.Location = New System.Drawing.Point(3, 49)
        Me.Lbl_I.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_I.Name = "Lbl_I"
        Me.Lbl_I.Size = New System.Drawing.Size(52, 47)
        Me.Lbl_I.TabIndex = 1
        Me.Lbl_I.Text = "I"
        Me.Lbl_I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_N
        '
        Me.Lbl_N.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_N.Location = New System.Drawing.Point(3, 96)
        Me.Lbl_N.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_N.Name = "Lbl_N"
        Me.Lbl_N.Size = New System.Drawing.Size(52, 47)
        Me.Lbl_N.TabIndex = 2
        Me.Lbl_N.Text = "N"
        Me.Lbl_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 47)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "G"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "O"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boulier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_N)
        Me.Controls.Add(Me.Lbl_I)
        Me.Controls.Add(Me.LbL_B)
        Me.Enabled = False
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Boulier"
        Me.Size = New System.Drawing.Size(1203, 245)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LbL_B As Label
    Friend WithEvents Lbl_I As Label
    Friend WithEvents Lbl_N As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
