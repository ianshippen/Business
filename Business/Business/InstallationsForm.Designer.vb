<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallationsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallationsForm))
        Me.installationsDataGridView = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.resellerComboBox = New System.Windows.Forms.ComboBox
        Me.supportExpiredComboBox = New System.Windows.Forms.ComboBox
        Me.activeComboBox = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddInstallationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reseller = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Invoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.installationDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.paymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.annuaSupport = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supportExpires = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.activeCustomer = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.inSupport = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.installationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'installationsDataGridView
        '
        Me.installationsDataGridView.AllowUserToAddRows = False
        Me.installationsDataGridView.AllowUserToDeleteRows = False
        Me.installationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.installationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Reseller, Me.Customer, Me.Invoice, Me.Description, Me.installationDate, Me.paymentDate, Me.annuaSupport, Me.supportExpires, Me.price, Me.notes, Me.activeCustomer, Me.inSupport})
        Me.installationsDataGridView.Location = New System.Drawing.Point(30, 94)
        Me.installationsDataGridView.Name = "installationsDataGridView"
        Me.installationsDataGridView.RowHeadersWidth = 50
        Me.installationsDataGridView.Size = New System.Drawing.Size(1474, 299)
        Me.installationsDataGridView.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'resellerComboBox
        '
        Me.resellerComboBox.FormattingEnabled = True
        Me.resellerComboBox.Location = New System.Drawing.Point(129, 67)
        Me.resellerComboBox.Name = "resellerComboBox"
        Me.resellerComboBox.Size = New System.Drawing.Size(203, 21)
        Me.resellerComboBox.Sorted = True
        Me.resellerComboBox.TabIndex = 4
        '
        'supportExpiredComboBox
        '
        Me.supportExpiredComboBox.FormattingEnabled = True
        Me.supportExpiredComboBox.Items.AddRange(New Object() {"All ..", "Expired", "Non-Expired"})
        Me.supportExpiredComboBox.Location = New System.Drawing.Point(878, 67)
        Me.supportExpiredComboBox.Name = "supportExpiredComboBox"
        Me.supportExpiredComboBox.Size = New System.Drawing.Size(104, 21)
        Me.supportExpiredComboBox.Sorted = True
        Me.supportExpiredComboBox.TabIndex = 5
        '
        'activeComboBox
        '
        Me.activeComboBox.FormattingEnabled = True
        Me.activeComboBox.Items.AddRange(New Object() {"All ..", "Active", "Non-Active"})
        Me.activeComboBox.Location = New System.Drawing.Point(1279, 67)
        Me.activeComboBox.Name = "activeComboBox"
        Me.activeComboBox.Size = New System.Drawing.Size(55, 21)
        Me.activeComboBox.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1516, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddInstallationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddInstallationToolStripMenuItem
        '
        Me.AddInstallationToolStripMenuItem.Name = "AddInstallationToolStripMenuItem"
        Me.AddInstallationToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddInstallationToolStripMenuItem.Text = "Add Installation ..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(697, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1056, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'Reseller
        '
        Me.Reseller.HeaderText = "Reseller"
        Me.Reseller.Name = "Reseller"
        Me.Reseller.Width = 200
        '
        'Customer
        '
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        '
        'Invoice
        '
        Me.Invoice.HeaderText = "Invoice"
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Width = 50
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'installationDate
        '
        Me.installationDate.HeaderText = "Installation Date"
        Me.installationDate.Name = "installationDate"
        '
        'paymentDate
        '
        Me.paymentDate.HeaderText = "Payment Date"
        Me.paymentDate.Name = "paymentDate"
        '
        'annuaSupport
        '
        Me.annuaSupport.HeaderText = "Annual Support"
        Me.annuaSupport.Name = "annuaSupport"
        '
        'supportExpires
        '
        Me.supportExpires.HeaderText = "Support Expires"
        Me.supportExpires.Name = "supportExpires"
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        '
        'notes
        '
        Me.notes.HeaderText = "Notes"
        Me.notes.Name = "notes"
        Me.notes.Width = 200
        '
        'activeCustomer
        '
        Me.activeCustomer.HeaderText = "Active Customer"
        Me.activeCustomer.Name = "activeCustomer"
        Me.activeCustomer.ReadOnly = True
        '
        'inSupport
        '
        Me.inSupport.HeaderText = "In Support"
        Me.inSupport.Name = "inSupport"
        '
        'InstallationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 419)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.activeComboBox)
        Me.Controls.Add(Me.supportExpiredComboBox)
        Me.Controls.Add(Me.resellerComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.installationsDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InstallationsForm"
        Me.Text = "Installations"
        CType(Me.installationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents installationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents resellerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents supportExpiredComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents activeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddInstallationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reseller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Invoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents installationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents annuaSupport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supportExpires As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents activeCustomer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents inSupport As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
