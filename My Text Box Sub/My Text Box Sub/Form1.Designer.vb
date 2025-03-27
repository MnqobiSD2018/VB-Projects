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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtMKT = New System.Windows.Forms.TextBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblMKT = New System.Windows.Forms.Label()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnMKT = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(15, 78)
        Me.txtSales.Multiline = True
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSales.Size = New System.Drawing.Size(217, 156)
        Me.txtSales.TabIndex = 0
        Me.txtSales.TabStop = False
        '
        'txtMKT
        '
        Me.txtMKT.Location = New System.Drawing.Point(247, 78)
        Me.txtMKT.Multiline = True
        Me.txtMKT.Name = "txtMKT"
        Me.txtMKT.ReadOnly = True
        Me.txtMKT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMKT.Size = New System.Drawing.Size(227, 156)
        Me.txtMKT.TabIndex = 1
        Me.txtMKT.TabStop = False
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(12, 33)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(38, 13)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "Sales"
        '
        'lblMKT
        '
        Me.lblMKT.AutoSize = True
        Me.lblMKT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMKT.Location = New System.Drawing.Point(244, 33)
        Me.lblMKT.Name = "lblMKT"
        Me.lblMKT.Size = New System.Drawing.Size(63, 13)
        Me.lblMKT.TabIndex = 3
        Me.lblMKT.Text = "Marketing"
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(54, 259)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(75, 23)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = "Add Name"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnMKT
        '
        Me.btnMKT.Location = New System.Drawing.Point(373, 259)
        Me.btnMKT.Name = "btnMKT"
        Me.btnMKT.Size = New System.Drawing.Size(75, 23)
        Me.btnMKT.TabIndex = 5
        Me.btnMKT.Text = "Add Name"
        Me.btnMKT.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(196, 319)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 379)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMKT)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.lblMKT)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.txtMKT)
        Me.Controls.Add(Me.txtSales)
        Me.Name = "Form1"
        Me.Text = "Assign Depertment Teams "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents txtMKT As System.Windows.Forms.TextBox
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents lblMKT As System.Windows.Forms.Label
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnMKT As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
