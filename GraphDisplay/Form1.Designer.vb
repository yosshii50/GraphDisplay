<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LinearBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QuadraticBtn = New System.Windows.Forms.Button()
        Me.CubicBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GraphPicture1 = New WindowsApplication2.GraphPicture()
        Me.Panel1.SuspendLayout()
        CType(Me.GraphPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinearBtn
        '
        Me.LinearBtn.Location = New System.Drawing.Point(12, 12)
        Me.LinearBtn.Name = "LinearBtn"
        Me.LinearBtn.Size = New System.Drawing.Size(82, 33)
        Me.LinearBtn.TabIndex = 2
        Me.LinearBtn.Text = "Linear"
        Me.LinearBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.CubicBtn)
        Me.Panel1.Controls.Add(Me.QuadraticBtn)
        Me.Panel1.Controls.Add(Me.LinearBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 80)
        Me.Panel1.TabIndex = 3
        '
        'QuadraticBtn
        '
        Me.QuadraticBtn.Location = New System.Drawing.Point(119, 12)
        Me.QuadraticBtn.Name = "QuadraticBtn"
        Me.QuadraticBtn.Size = New System.Drawing.Size(143, 33)
        Me.QuadraticBtn.TabIndex = 3
        Me.QuadraticBtn.Text = "Quadratic"
        Me.QuadraticBtn.UseVisualStyleBackColor = True
        '
        'CubicBtn
        '
        Me.CubicBtn.Location = New System.Drawing.Point(287, 12)
        Me.CubicBtn.Name = "CubicBtn"
        Me.CubicBtn.Size = New System.Drawing.Size(209, 33)
        Me.CubicBtn.TabIndex = 4
        Me.CubicBtn.Text = "Cubic"
        Me.CubicBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 19)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "500"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 19)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "10"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 19)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "-0.01"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(287, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(41, 19)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "0.0001"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(230, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(32, 19)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "50"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(464, 48)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(32, 19)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "-50"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "x+"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "x² +"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "x +"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(176, 48)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(32, 19)
        Me.TextBox7.TabIndex = 16
        Me.TextBox7.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "x³ +"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "x² +"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(354, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(32, 19)
        Me.TextBox8.TabIndex = 19
        Me.TextBox8.Text = "0.02"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "x +"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(411, 48)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(32, 19)
        Me.TextBox9.TabIndex = 21
        Me.TextBox9.Text = "0"
        '
        'GraphPicture1
        '
        Me.GraphPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GraphPicture1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GraphPicture1.Location = New System.Drawing.Point(0, 80)
        Me.GraphPicture1.Name = "GraphPicture1"
        Me.GraphPicture1.Size = New System.Drawing.Size(802, 387)
        Me.GraphPicture1.TabIndex = 4
        Me.GraphPicture1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 467)
        Me.Controls.Add(Me.GraphPicture1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GraphPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LinearBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents QuadraticBtn As System.Windows.Forms.Button
    Friend WithEvents CubicBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GraphPicture1 As WindowsApplication2.GraphPicture

End Class
