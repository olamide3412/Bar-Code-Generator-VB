Imports ZXing

Public Class Form1
    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        PictureBox1.Image = writer.Write(txtEncode.Text)

    End Sub

    Private Sub btnDecode_Click(sender As Object, e As EventArgs) Handles btnDecode.Click
        Dim reader As New BarcodeReader
        Dim result = reader.Decode(CType(PictureBox1.Image, Bitmap))
        If result IsNot Nothing Then
            txtDecode.Text = result.Text
        End If
    End Sub
End Class
