'Link do Video -> https://www.youtube.com/watch?v=0HtVVbuV0mI

'NOTAS: Para ligar a base de dados local tenho de ir a Server Explorer
'Clicar com o botão direito do rato sobre a base de dade neste caso "SchoolDatabase.mdf"
'Clicar em "Modify Connection" e clicar em "OK"

Public Class Form1
    Private Sub SchoolTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SchoolTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SchoolTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDataSet.SchoolTable' table. You can move, or remove it, as needed.
        Me.SchoolTableTableAdapter.Fill(Me.SchoolDataSet.SchoolTable)
        Me.WindowState = FormWindowState.Normal

        If ComboBox1.Text = Nothing Then
            Try
                Me.SchoolTableBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    'Button Exit
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Se o utilizador responder sim o programa fecha
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Button Save
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Validate()
            Me.SchoolTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
            MessageBox.Show("Informação guardada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.SchoolTableBindingSource.AddNew()
            NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button Primeiro Formulário
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.SchoolTableBindingSource.MoveFirst()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button Último Formulário
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.SchoolTableBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button <
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Me.SchoolTableBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button >
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Me.SchoolTableBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button Add New
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.SchoolTableBindingSource.AddNew()
            NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Button Delete
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iDelete As DialogResult
        iDelete = MessageBox.Show("Deseja apanhar estes valores?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Se o utilizador responder sim o programa fecha
        If iDelete = DialogResult.Yes Then
            Try
                Me.SchoolTableBindingSource.RemoveCurrent()
            Catch ex As Exception

            End Try
        ElseIf iDelete = DialogResult.No Then
            'Não acontece nada
        End If
    End Sub

    'Button Clear
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
                a.Text = ""
            End If
        Next
    End Sub
End Class
