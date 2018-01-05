Public Class frmMaster
    Dim Xpos As New Integer
    Dim Ypos As New Integer
    Dim pos As New Point
    Private Sub frmMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboSize.Enabled = False
        btnPrint.Enabled = False
    End Sub
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblTitle.MouseDown
        Xpos = Cursor.Position.X - Me.Location.X
        Ypos = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblTitle.MouseMove
        If e.Button = MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - Xpos
            pos.Y = pos.Y - Ypos
            Me.Location = pos
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        ofdFile.Filter = "PDF File (*.pdf)|*.pdf"
        ofdFile.Multiselect = False
        ofdFile.FileName = ""
        ofdFile.ShowDialog()
        lblTitle.Text = ofdFile.SafeFileName + " - Simple PDF Reader"
        cboSize.Enabled = True
        btnPrint.Enabled = True
        txtPage.Text = 1
    End Sub

    Private Sub ofdFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdFile.FileOk
        AxAcroPDF1.src = ofdFile.FileName
        AxAcroPDF1.setZoom(75)
        cboSize.SelectedIndex = 3
    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        If cboSize.SelectedIndex = 0 Then
            AxAcroPDF1.setZoom(10)
        ElseIf cboSize.SelectedIndex = 1 Then
            AxAcroPDF1.setZoom(25)
        ElseIf cboSize.SelectedIndex = 2 Then
            AxAcroPDF1.setZoom(50)
        ElseIf cboSize.SelectedIndex = 3 Then
            AxAcroPDF1.setZoom(75)
        ElseIf cboSize.SelectedIndex = 4 Then
            AxAcroPDF1.setZoom(100)
        ElseIf cboSize.SelectedIndex = 5 Then
            AxAcroPDF1.setZoom(125)
        ElseIf cboSize.SelectedIndex = 6 Then
            AxAcroPDF1.setZoom(150)
        ElseIf cboSize.SelectedIndex = 7 Then
            AxAcroPDF1.setZoom(200)
        ElseIf cboSize.SelectedIndex = 8 Then
            AxAcroPDF1.setZoom(400)
        ElseIf cboSize.SelectedIndex = 9 Then
            AxAcroPDF1.setZoom(800)
        ElseIf cboSize.SelectedIndex = 10 Then
            AxAcroPDF1.setZoom(1600)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AxAcroPDF1.printWithDialog()
    End Sub

    Private Sub txtPage_TextChanged(sender As Object, e As EventArgs) Handles txtPage.TextChanged
        If txtPage.Text < 0 Then
            txtPage.Text = 1
        End If
        AxAcroPDF1.setCurrentPage(txtPage.Text)
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        AxAcroPDF1.gotoPreviousPage()
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        AxAcroPDF1.gotoNextPage()
    End Sub

    Private Sub btnSizeMinus_Click(sender As Object, e As EventArgs) Handles btnSizeMinus.Click
        Dim size As Int16 = Replace(cboSize.SelectedItem, "%", "") - 20
        If size < 1 Then
            size = 10
        End If
        AxAcroPDF1.setZoom(size)
    End Sub

    Private Sub btnSizePlus_Click(sender As Object, e As EventArgs) Handles btnSizePlus.Click
        Dim size As Int16 = Replace(cboSize.SelectedItem, "%", "") + 20
        If size < 1 Then
            size = 10
        End If
        AxAcroPDF1.setZoom(size)
    End Sub
End Class
