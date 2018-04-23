Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click
        ' A path to export a report.
        Dim reportPath As String = "c:\\Test.png"

        ' Create a report instance.
        Dim report As New XtraReport1()

        ' Get its Image export options.
        Dim imageOptions As ImageExportOptions = report.ExportOptions.Image

        ' Set Image-specific export options.
        imageOptions.Format = ImageFormat.Png

        ' Export the report to Image.
        report.ExportToImage(reportPath)

        ' Show the result.
        StartProcess(reportPath)
    End Sub

    ' Use this method if you want to automaically open
    ' the created Image file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub
End Class
