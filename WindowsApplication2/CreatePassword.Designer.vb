Imports System.Web.Security
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePassword
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
        Me.Length = New System.Windows.Forms.NumericUpDown()
        Me.NonAlpha = New System.Windows.Forms.NumericUpDown()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.GeneratePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Length
        '
        Me.Length.Location = New System.Drawing.Point(131, 34)
        Me.Length.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(43, 20)
        Me.Length.TabIndex = 0
        Me.Length.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'NonAlpha
        '
        Me.NonAlpha.Location = New System.Drawing.Point(131, 63)
        Me.NonAlpha.Name = "NonAlpha"
        Me.NonAlpha.Size = New System.Drawing.Size(43, 20)
        Me.NonAlpha.TabIndex = 1
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(26, 148)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(134, 20)
        Me.Password.TabIndex = 2
        '
        'GeneratePassword
        '
        Me.GeneratePassword.Location = New System.Drawing.Point(22, 102)
        Me.GeneratePassword.Name = "GeneratePassword"
        Me.GeneratePassword.Size = New System.Drawing.Size(138, 23)
        Me.GeneratePassword.TabIndex = 3
        Me.GeneratePassword.Text = "Generate Password"
        Me.GeneratePassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Min Non AlphaNumric"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password Generator"
        '
        'CreatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 195)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GeneratePassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.NonAlpha)
        Me.Controls.Add(Me.Length)
        Me.Name = "CreatePassword"
        Me.Text = "Create Password"
        CType(Me.Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Length As System.Windows.Forms.NumericUpDown
    Friend WithEvents NonAlpha As System.Windows.Forms.NumericUpDown
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents GeneratePassword As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

    Private Sub GeneratePassword_Click(sender As Object, e As EventArgs) Handles GeneratePassword.Click
        Password.Text = Membership.GeneratePassword(Length.Value, NonAlpha.Value)
    End Sub
End Class
