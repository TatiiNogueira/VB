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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ExcelBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.ExcelBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExcelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcelBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcelBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.BirthdateDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExcelBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'ExcelBindingSource1
        '
        Me.ExcelBindingSource1.DataSource = GetType(Read_Excel.Excel)
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Black
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBrowse.Location = New System.Drawing.Point(728, 293)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Search"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(9, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File Name:"
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFileName.ForeColor = System.Drawing.SystemColors.Info
        Me.txtFileName.Location = New System.Drawing.Point(82, 293)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(640, 20)
        Me.txtFileName.TabIndex = 3
        '
        'cboSheet
        '
        Me.cboSheet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboSheet.ForeColor = System.Drawing.SystemColors.Info
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(82, 333)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(167, 21)
        Me.cboSheet.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(9, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sheet:"
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.Black
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImport.Location = New System.Drawing.Point(255, 333)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'ExcelBindingSource2
        '
        Me.ExcelBindingSource2.DataSource = GetType(Read_Excel.Excel)
        '
        'ExcelBindingSource
        '
        Me.ExcelBindingSource.DataSource = GetType(Read_Excel.Excel)
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(Read_Excel.Form1)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AdressDataGridViewTextBoxColumn
        '
        Me.AdressDataGridViewTextBoxColumn.DataPropertyName = "Adress"
        Me.AdressDataGridViewTextBoxColumn.HeaderText = "Adress"
        Me.AdressDataGridViewTextBoxColumn.Name = "AdressDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(815, 365)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSheet)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Excel - Read and Import to Database SQL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcelBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcelBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExcelBindingSource As BindingSource
    Friend WithEvents ExcelBindingSource1 As BindingSource
    Friend WithEvents ExcelBindingSource2 As BindingSource
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
