'Link do Video -> https://www.youtube.com/watch?v=fR3O77oIoNE

'Importações
Imports System.Data.SqlClient
Imports System.IO
Imports ExcelDataReader
Imports Z.Dapper.Plus

Public Class Form1
    Dim tables As DataTableCollection
    'Button Search
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook | *.xls|Excel Workbook|*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                'Caminho do ficheiro que colocamos na TextBox
                txtFileName.Text = ofd.FileName
                'Abrir o ficheiro
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        'Limpar a ComboBox
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    'ComboBox
    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        If dt IsNot Nothing Then
            Dim list As List(Of Excel) = New List(Of Excel)()
            'Campos da tabela SQL
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim excel As Excel = New Excel()
                excel.FirstName = dt.Rows(i)("First Name").ToString()
                excel.LastName = dt.Rows(i)("Last Name").ToString()
                excel.Birthdate = dt.Rows(i)("Birthdate").ToString()
                excel.Age = dt.Rows(i)("Age").ToString()
                excel.Gender = dt.Rows(i)("Gender").ToString()
                excel.Adress = dt.Rows(i)("Address").ToString()
                list.Add(excel)
            Next
            ExcelBindingSource.DataSource = list
        End If
    End Sub

    'Button Import
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim list As List(Of Excel) = TryCast(ExcelBindingSource.DataSource, List(Of Excel))
            If list IsNot Nothing Then
                DapperPlusManager.Entity(Of Excel).Table("Excel")
                Using db As IDbConnection = New SqlConnection("Server=.;Database=VB_Testes/Estudo;User Id=sa;Password=1234;")
                    db.BulkInsert(list)
                End Using
                MessageBox.Show("Dados Enviados para a base de dados com sucesso", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
