<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInstallationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewInstallationForm))
        Me.okButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.priceTextBox = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.notesTextBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.invoiceDateTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.trainingDateTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.supportExpiresTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.annualSupportTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.paymentDateTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.installationDateTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.descriptionTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.invoiceTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.customerComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.resellerComboBox = New System.Windows.Forms.ComboBox
        Me.inSupportComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(517, 375)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "Add"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inSupportComboBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.notesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.invoiceDateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.trainingDateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.supportExpiresTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.annualSupportTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.paymentDateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.installationDateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.descriptionTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.invoiceTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.customerComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.resellerComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 346)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Details "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(467, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "In Support"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(467, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Price"
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(342, 190)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(119, 20)
        Me.priceTextBox.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(467, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Notes"
        '
        'notesTextBox
        '
        Me.notesTextBox.Location = New System.Drawing.Point(342, 153)
        Me.notesTextBox.Name = "notesTextBox"
        Me.notesTextBox.Size = New System.Drawing.Size(119, 20)
        Me.notesTextBox.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Invoice Date"
        '
        'invoiceDateTextBox
        '
        Me.invoiceDateTextBox.Location = New System.Drawing.Point(342, 113)
        Me.invoiceDateTextBox.Name = "invoiceDateTextBox"
        Me.invoiceDateTextBox.Size = New System.Drawing.Size(119, 20)
        Me.invoiceDateTextBox.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Training Date"
        '
        'trainingDateTextBox
        '
        Me.trainingDateTextBox.Location = New System.Drawing.Point(342, 76)
        Me.trainingDateTextBox.Name = "trainingDateTextBox"
        Me.trainingDateTextBox.Size = New System.Drawing.Size(119, 20)
        Me.trainingDateTextBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(467, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Support Expires"
        '
        'supportExpiresTextBox
        '
        Me.supportExpiresTextBox.Location = New System.Drawing.Point(342, 34)
        Me.supportExpiresTextBox.Name = "supportExpiresTextBox"
        Me.supportExpiresTextBox.Size = New System.Drawing.Size(119, 20)
        Me.supportExpiresTextBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Annual Support"
        '
        'annualSupportTextBox
        '
        Me.annualSupportTextBox.Location = New System.Drawing.Point(24, 264)
        Me.annualSupportTextBox.Name = "annualSupportTextBox"
        Me.annualSupportTextBox.Size = New System.Drawing.Size(119, 20)
        Me.annualSupportTextBox.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Payment Date"
        '
        'paymentDateTextBox
        '
        Me.paymentDateTextBox.Location = New System.Drawing.Point(24, 227)
        Me.paymentDateTextBox.Name = "paymentDateTextBox"
        Me.paymentDateTextBox.Size = New System.Drawing.Size(119, 20)
        Me.paymentDateTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Installation Date"
        '
        'installationDateTextBox
        '
        Me.installationDateTextBox.Location = New System.Drawing.Point(24, 190)
        Me.installationDateTextBox.Name = "installationDateTextBox"
        Me.installationDateTextBox.Size = New System.Drawing.Size(119, 20)
        Me.installationDateTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Description"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(24, 153)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(119, 20)
        Me.descriptionTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Invoice"
        '
        'invoiceTextBox
        '
        Me.invoiceTextBox.Location = New System.Drawing.Point(24, 117)
        Me.invoiceTextBox.Name = "invoiceTextBox"
        Me.invoiceTextBox.Size = New System.Drawing.Size(119, 20)
        Me.invoiceTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "New .."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer"
        '
        'customerComboBox
        '
        Me.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerComboBox.FormattingEnabled = True
        Me.customerComboBox.Location = New System.Drawing.Point(24, 76)
        Me.customerComboBox.Name = "customerComboBox"
        Me.customerComboBox.Size = New System.Drawing.Size(119, 21)
        Me.customerComboBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reseller"
        '
        'resellerComboBox
        '
        Me.resellerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.resellerComboBox.FormattingEnabled = True
        Me.resellerComboBox.Location = New System.Drawing.Point(24, 33)
        Me.resellerComboBox.Name = "resellerComboBox"
        Me.resellerComboBox.Size = New System.Drawing.Size(119, 21)
        Me.resellerComboBox.TabIndex = 0
        '
        'inSupportComboBox
        '
        Me.inSupportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inSupportComboBox.FormattingEnabled = True
        Me.inSupportComboBox.Items.AddRange(New Object() {"No", "Yes"})
        Me.inSupportComboBox.Location = New System.Drawing.Point(342, 227)
        Me.inSupportComboBox.Name = "inSupportComboBox"
        Me.inSupportComboBox.Size = New System.Drawing.Size(119, 21)
        Me.inSupportComboBox.TabIndex = 27
        '
        'NewInstallationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.okButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewInstallationForm"
        Me.Text = "New Installation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents customerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents resellerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents installationDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents descriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents invoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents invoiceDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents trainingDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents supportExpiresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents annualSupportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents paymentDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents notesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents inSupportComboBox As System.Windows.Forms.ComboBox
End Class
