<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.exitButton = New System.Windows.Forms.Button()
        Me.normalButton = New System.Windows.Forms.Button()
        Me.restaurantButton = New System.Windows.Forms.Button()
        Me.onlineButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "Button1"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'normalButton
        '
        Me.normalButton.Location = New System.Drawing.Point(271, 202)
        Me.normalButton.Name = "normalButton"
        Me.normalButton.Size = New System.Drawing.Size(147, 54)
        Me.normalButton.TabIndex = 1
        Me.normalButton.Text = "Normal"
        Me.normalButton.UseVisualStyleBackColor = True
        '
        'restaurantButton
        '
        Me.restaurantButton.Location = New System.Drawing.Point(203, 322)
        Me.restaurantButton.Name = "restaurantButton"
        Me.restaurantButton.Size = New System.Drawing.Size(123, 59)
        Me.restaurantButton.TabIndex = 2
        Me.restaurantButton.Text = "Restruant"
        Me.restaurantButton.UseVisualStyleBackColor = True
        '
        'onlineButton
        '
        Me.onlineButton.Location = New System.Drawing.Point(361, 322)
        Me.onlineButton.Name = "onlineButton"
        Me.onlineButton.Size = New System.Drawing.Size(128, 59)
        Me.onlineButton.TabIndex = 3
        Me.onlineButton.Text = "Online Shopping"
        Me.onlineButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 76)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price Split"
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(653, 595)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.onlineButton)
        Me.Controls.Add(Me.restaurantButton)
        Me.Controls.Add(Me.normalButton)
        Me.Controls.Add(Me.exitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents normalButton As System.Windows.Forms.Button
    Friend WithEvents restaurantButton As System.Windows.Forms.Button
    Friend WithEvents onlineButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
