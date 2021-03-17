'Link do Video -> https://www.youtube.com/watch?v=69qKg71SkjY

Imports System.Windows.Forms

Public Class MDIParent

    'Button open - Page 1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        frmpage1.MdiParent = Me
        frmpage1.WindowState = FormWindowState.Normal
        frmpage1.Show()
        'OU
        'With frmpage1 
        '.MdiParent = Me
        '.WindowState = FormWindowState.Normal
        '.Show()
        'End With
    End Sub

    'Button Page 1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmpage1.MdiParent = Me
        frmpage1.WindowState = FormWindowState.Normal
        frmpage2.Close()
        frmpage1.Show()
    End Sub

    'Button open - Page 2
    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        frmpage2.MdiParent = Me
        frmpage2.WindowState = FormWindowState.Normal
        frmpage2.Show()
    End Sub

    'Button Page 2
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmpage2.MdiParent = Me
        frmpage2.WindowState = FormWindowState.Normal
        frmpage1.Close()
        frmpage2.Show()
    End Sub

    'Button Close Page 1
    Private Sub ClosePage1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosePage1ToolStripMenuItem.Click
        frmpage1.Close()
    End Sub

    'Button Close Page 2
    Private Sub ClosePage2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosePage2ToolStripMenuItem.Click
        frmpage2.Close()
    End Sub
End Class
