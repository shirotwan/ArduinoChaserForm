<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Sprite1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cat = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Meta = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        CType(Me.Sprite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Meta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sprite1
        '
        Me.Sprite1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Sprite1.Location = New System.Drawing.Point(12, 200)
        Me.Sprite1.Name = "Sprite1"
        Me.Sprite1.Size = New System.Drawing.Size(25, 24)
        Me.Sprite1.TabIndex = 0
        Me.Sprite1.TabStop = False
        '
        'Timer1
        '
        '
        'Cat
        '
        Me.Cat.BackColor = System.Drawing.Color.Aqua
        Me.Cat.Location = New System.Drawing.Point(298, 200)
        Me.Cat.Name = "Cat"
        Me.Cat.Size = New System.Drawing.Size(24, 24)
        Me.Cat.TabIndex = 2
        Me.Cat.TabStop = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Iniciar juego"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Meta
        '
        Me.Meta.BackColor = System.Drawing.Color.Yellow
        Me.Meta.Location = New System.Drawing.Point(783, 200)
        Me.Meta.Name = "Meta"
        Me.Meta.Size = New System.Drawing.Size(25, 24)
        Me.Meta.TabIndex = 5
        Me.Meta.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nivel:"
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Location = New System.Drawing.Point(286, 21)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(14, 16)
        Me.Level.TabIndex = 7
        Me.Level.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 503)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Meta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cat)
        Me.Controls.Add(Me.Sprite1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Sprite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Meta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sprite1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cat As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Meta As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Level As Label
End Class
