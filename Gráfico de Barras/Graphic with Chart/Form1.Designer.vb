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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(165, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load Chart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Legend1.BorderColor = System.Drawing.Color.Black
        Legend1.Name = "Legend1"
        Legend1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 28)
        Me.Chart1.Name = "Chart1"
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Age"
        Series1.YValuesPerPoint = 2
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.Name = "Nº de Filhos"
        Series2.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(451, 222)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 300)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Form1"
        Me.Text = "Gráfico de Barras"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
