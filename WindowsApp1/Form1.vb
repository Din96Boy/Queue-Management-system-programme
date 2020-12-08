Imports QRCoder
Imports ZXing

Public Class Form1
    Dim generate As New MessagingToolkit.Barcode.BarcodeEncoder


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

        'TODO: This line of code loads data into the 'Supermarket_Data_2DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter2.Fill(Me.Supermarket_Data_2DataSet1.Table1)
        'TODO: This line of code loads data into the 'Supermarket_Data_2DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.Supermarket_Data_2DataSet.Table1)
        'TODO: This line of code loads data into the 'Supermarket_DataDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Supermarket_DataDataSet.Table1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource1.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource1.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource1.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error GoTo SaveErr
        Table1BindingSource1.EndEdit()
        Table1TableAdapter1.Update(Supermarket_Data_2DataSet.Table1)
        MessageBox.Show("Data saved successfully")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        pic.Image = writer.Write(txtinput.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(pic.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToString("dd MMM yyyyy   hh:mm")
    End Sub
End Class
