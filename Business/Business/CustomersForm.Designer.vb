<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersForm))
        Me.customersDataGridView = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.myName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reseller = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.active = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.customersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customersDataGridView
        '
        Me.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.myName, Me.Reseller, Me.active})
        Me.customersDataGridView.Location = New System.Drawing.Point(12, 47)
        Me.customersDataGridView.Name = "customersDataGridView"
        Me.customersDataGridView.Size = New System.Drawing.Size(594, 299)
        Me.customersDataGridView.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'myName
        '
        Me.myName.HeaderText = "Name"
        Me.myName.Name = "myName"
        Me.myName.ReadOnly = True
        Me.myName.Width = 200
        '
        'Reseller
        '
        Me.Reseller.HeaderText = "Reseller"
        Me.Reseller.Name = "Reseller"
        Me.Reseller.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'active
        '
        Me.active.HeaderText = "Active"
        Me.active.Name = "active"
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 433)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customersDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomersForm"
        Me.Text = "Customers"
        CType(Me.customersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents myName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reseller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents active As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
