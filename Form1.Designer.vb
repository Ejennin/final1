<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoubleHalf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoubleHalf))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserNum = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(246, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter a number"
        '
        'txtUserNum
        '
        Me.txtUserNum.AcceptsTab = True
        Me.txtUserNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserNum.Location = New System.Drawing.Point(662, 72)
        Me.txtUserNum.Multiline = True
        Me.txtUserNum.Name = "txtUserNum"
        Me.txtUserNum.Size = New System.Drawing.Size(200, 40)
        Me.txtUserNum.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkRed
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(768, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 59)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit ?"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(418, 370)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(246, 43)
        Me.txtAnswer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 39)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Answer"
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(390, 186)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(141, 48)
        Me.btnDouble.TabIndex = 10
        Me.btnDouble.Text = "Double"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'btnHalf
        '
        Me.btnHalf.Location = New System.Drawing.Point(616, 186)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(141, 48)
        Me.btnHalf.TabIndex = 11
        Me.btnHalf.Text = "HALF"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'frmDoubleHalf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1140, 598)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtUserNum)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmDoubleHalf"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Multiply or Divide By 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserNum As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDouble As Button
    Friend WithEvents btnHalf As Button
End Class
