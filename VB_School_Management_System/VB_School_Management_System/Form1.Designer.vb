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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Number_StudentLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SchoolDataSet = New VB_School_Management_System.SchoolDataSet()
        Me.SchoolTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolTableTableAdapter = New VB_School_Management_System.SchoolDataSetTableAdapters.SchoolTableTableAdapter()
        Me.TableAdapterManager = New VB_School_Management_System.SchoolDataSetTableAdapters.TableAdapterManager()
        Me.SchoolTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchoolTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Number_StudentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        StudentIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Number_StudentLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolTableBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.BackColor = System.Drawing.Color.Transparent
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentIDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        StudentIDLabel.Location = New System.Drawing.Point(25, 58)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(72, 13)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        NameLabel.Location = New System.Drawing.Point(25, 84)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(43, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Transparent
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        AgeLabel.Location = New System.Drawing.Point(25, 110)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(33, 13)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        GenderLabel.Location = New System.Drawing.Point(25, 136)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(52, 13)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.Transparent
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        TelephoneLabel.Location = New System.Drawing.Point(25, 162)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(71, 13)
        TelephoneLabel.TabIndex = 9
        TelephoneLabel.Text = "Telephone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        AddressLabel.Location = New System.Drawing.Point(25, 188)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(56, 13)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        EmailLabel.Location = New System.Drawing.Point(25, 214)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(41, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'Number_StudentLabel
        '
        Number_StudentLabel.AutoSize = True
        Number_StudentLabel.BackColor = System.Drawing.Color.Transparent
        Number_StudentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_StudentLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Number_StudentLabel.Location = New System.Drawing.Point(25, 240)
        Number_StudentLabel.Name = "Number_StudentLabel"
        Number_StudentLabel.Size = New System.Drawing.Size(102, 13)
        Number_StudentLabel.TabIndex = 15
        Number_StudentLabel.Text = "Number Student:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Label1.Location = New System.Drawing.Point(25, 271)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 19
        Label1.Text = "Search:"
        '
        'SchoolDataSet
        '
        Me.SchoolDataSet.DataSetName = "SchoolDataSet"
        Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolTableBindingSource
        '
        Me.SchoolTableBindingSource.DataMember = "SchoolTable"
        Me.SchoolTableBindingSource.DataSource = Me.SchoolDataSet
        '
        'SchoolTableTableAdapter
        '
        Me.SchoolTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SchoolTableTableAdapter = Me.SchoolTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = VB_School_Management_System.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SchoolTableBindingNavigator
        '
        Me.SchoolTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SchoolTableBindingNavigator.BindingSource = Me.SchoolTableBindingSource
        Me.SchoolTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SchoolTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SchoolTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SchoolTableBindingNavigatorSaveItem})
        Me.SchoolTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SchoolTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SchoolTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SchoolTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SchoolTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SchoolTableBindingNavigator.Name = "SchoolTableBindingNavigator"
        Me.SchoolTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SchoolTableBindingNavigator.Size = New System.Drawing.Size(542, 25)
        Me.SchoolTableBindingNavigator.TabIndex = 0
        Me.SchoolTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SchoolTableBindingNavigatorSaveItem
        '
        Me.SchoolTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SchoolTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("SchoolTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SchoolTableBindingNavigatorSaveItem.Name = "SchoolTableBindingNavigatorSaveItem"
        Me.SchoolTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SchoolTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "StudentID", True))
        Me.StudentIDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.StudentIDTextBox.Location = New System.Drawing.Point(131, 55)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(124, 20)
        Me.StudentIDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Name", True))
        Me.NameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.NameTextBox.Location = New System.Drawing.Point(131, 81)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Age", True))
        Me.AgeTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.AgeTextBox.Location = New System.Drawing.Point(131, 107)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(124, 20)
        Me.AgeTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Gender", True))
        Me.GenderTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.GenderTextBox.Location = New System.Drawing.Point(131, 133)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(124, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Telephone", True))
        Me.TelephoneTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.TelephoneTextBox.Location = New System.Drawing.Point(131, 159)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(124, 20)
        Me.TelephoneTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Address", True))
        Me.AddressTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.AddressTextBox.Location = New System.Drawing.Point(131, 185)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(124, 20)
        Me.AddressTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Email", True))
        Me.EmailTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.EmailTextBox.Location = New System.Drawing.Point(131, 211)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'Number_StudentTextBox
        '
        Me.Number_StudentTextBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Number_StudentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Number_Student", True))
        Me.Number_StudentTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Number_StudentTextBox.Location = New System.Drawing.Point(131, 237)
        Me.Number_StudentTextBox.Name = "Number_StudentTextBox"
        Me.Number_StudentTextBox.Size = New System.Drawing.Size(124, 20)
        Me.Number_StudentTextBox.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(273, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 229)
        Me.Panel1.TabIndex = 17
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.Info
        Me.Button10.Location = New System.Drawing.Point(128, 172)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(27, 23)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.Info
        Me.Button9.Location = New System.Drawing.Point(95, 197)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.Info
        Me.Button7.Location = New System.Drawing.Point(96, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(27, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Info
        Me.Button6.Location = New System.Drawing.Point(128, 131)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lime
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Info
        Me.Button5.Location = New System.Drawing.Point(48, 131)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Info
        Me.Button4.Location = New System.Drawing.Point(128, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Info
        Me.Button3.Location = New System.Drawing.Point(48, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Info
        Me.Button2.Location = New System.Drawing.Point(49, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Último Formulário"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(49, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Primeiro Formulário"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox1.DataSource = Me.SchoolTableBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 263)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(542, 303)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Number_StudentLabel)
        Me.Controls.Add(Me.Number_StudentTextBox)
        Me.Controls.Add(Me.SchoolTableBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Name = "Form1"
        Me.Text = "Formulário"
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolTableBindingNavigator.ResumeLayout(False)
        Me.SchoolTableBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchoolDataSet As SchoolDataSet
    Friend WithEvents SchoolTableBindingSource As BindingSource
    Friend WithEvents SchoolTableTableAdapter As SchoolDataSetTableAdapters.SchoolTableTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SchoolTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SchoolTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Number_StudentTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
