<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollLogin))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(405, 451)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(402, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 451)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(360, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 20)
        Label2.TabIndex = 16
        Label2.Text = "X"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(100, 356)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(211, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Not yet registered? | Create Account  >"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(79, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(253, 36)
        Button1.TabIndex = 3
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonShadow
        Panel3.Controls.Add(TextBox1)
        Panel3.Location = New Point(79, 152)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(253, 29)
        Panel3.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(0, -1)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(253, 29)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(150, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 22)
        Label1.TabIndex = 7
        Label1.Text = "User Login"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(79, 192)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(253, 29)
        Panel2.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(0, -1)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(253, 29)
        TextBox2.TabIndex = 2
        ' 
        ' PayrollLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "PayrollLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PayrollLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label

End Class
