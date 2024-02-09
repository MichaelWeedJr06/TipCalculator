<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.lblTipp = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculateTip = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 452)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tip Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Bill:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Percentage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total:"
        '
        'txtBill
        '
        Me.txtBill.Location = New System.Drawing.Point(593, 133)
        Me.txtBill.Multiline = True
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(145, 32)
        Me.txtBill.TabIndex = 3
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(593, 185)
        Me.txtPercentage.Multiline = True
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(145, 34)
        Me.txtPercentage.TabIndex = 5
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(593, 258)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(0, 0)
        Me.lblTip.TabIndex = 7
        Me.lblTip.Text = "Label6"
        '
        'lblTipp
        '
        Me.lblTipp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipp.Location = New System.Drawing.Point(593, 235)
        Me.lblTipp.Name = "lblTipp"
        Me.lblTipp.Size = New System.Drawing.Size(145, 37)
        Me.lblTipp.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(593, 288)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(145, 37)
        Me.lblTotal.TabIndex = 9
        '
        'btnCalculateTip
        '
        Me.btnCalculateTip.Location = New System.Drawing.Point(477, 379)
        Me.btnCalculateTip.Name = "btnCalculateTip"
        Me.btnCalculateTip.Size = New System.Drawing.Size(261, 109)
        Me.btnCalculateTip.TabIndex = 10
        Me.btnCalculateTip.Text = "&Calculate Tip"
        Me.btnCalculateTip.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 526)
        Me.Controls.Add(Me.btnCalculateTip)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTipp)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBill As TextBox
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents lblTip As Label
    Friend WithEvents lblTipp As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculateTip As Button
End Class
