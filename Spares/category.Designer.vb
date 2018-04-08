<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Me.namecategory = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.categoryTable = New System.Windows.Forms.DataGridView()
        CType(Me.categoryTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namecategory
        '
        Me.namecategory.Location = New System.Drawing.Point(68, 31)
        Me.namecategory.Name = "namecategory"
        Me.namecategory.Size = New System.Drawing.Size(161, 20)
        Me.namecategory.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'categoryTable
        '
        Me.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.categoryTable.Location = New System.Drawing.Point(13, 108)
        Me.categoryTable.Name = "categoryTable"
        Me.categoryTable.Size = New System.Drawing.Size(704, 182)
        Me.categoryTable.TabIndex = 2
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 302)
        Me.Controls.Add(Me.categoryTable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.namecategory)
        Me.Name = "category"
        Me.Text = "category"
        CType(Me.categoryTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namecategory As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents categoryTable As DataGridView
End Class
