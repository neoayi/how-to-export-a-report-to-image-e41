Namespace ExportToImageCS
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageBreak4 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageBreak3 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrPageBreak5 = New DevExpress.XtraReports.UI.XRPageBreak()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak5, Me.xrPageBreak1, Me.xrLabel2, Me.xrLabel3, Me.xrPageBreak2, Me.xrLabel4, Me.xrLabel5, Me.xrPageBreak3, Me.xrLabel6, Me.xrPageBreak4, Me.xrLabel1})
            Me.Detail.Height = 258
            Me.Detail.Name = "Detail"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Height = 30
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Height = 30
            Me.PageFooter.Name = "PageFooter"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
            Me.xrLabel1.Location = New System.Drawing.Point(25, 8)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.ParentStyleUsing.UseBackColor = False
            Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel1.Text = "1"
            ' 
            ' xrPageBreak4
            ' 
            Me.xrPageBreak4.Location = New System.Drawing.Point(0, 83)
            Me.xrPageBreak4.Name = "xrPageBreak4"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(128)))))
            Me.xrLabel6.Location = New System.Drawing.Point(25, 225)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.ParentStyleUsing.UseBackColor = False
            Me.xrLabel6.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel6.Text = "6"
            ' 
            ' xrPageBreak3
            ' 
            Me.xrPageBreak3.Location = New System.Drawing.Point(0, 217)
            Me.xrPageBreak3.Name = "xrPageBreak3"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
            Me.xrLabel5.Location = New System.Drawing.Point(25, 183)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.ParentStyleUsing.UseBackColor = False
            Me.xrLabel5.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel5.Text = "5"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(128)))))
            Me.xrLabel4.Location = New System.Drawing.Point(25, 142)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.ParentStyleUsing.UseBackColor = False
            Me.xrLabel4.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel4.Text = "4"
            ' 
            ' xrPageBreak2
            ' 
            Me.xrPageBreak2.Location = New System.Drawing.Point(0, 125)
            Me.xrPageBreak2.Name = "xrPageBreak2"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
            Me.xrLabel3.Location = New System.Drawing.Point(25, 100)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.ParentStyleUsing.UseBackColor = False
            Me.xrLabel3.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel3.Text = "3"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(128)))))
            Me.xrLabel2.Location = New System.Drawing.Point(25, 50)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.ParentStyleUsing.UseBackColor = False
            Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel2.Text = "2"
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.Location = New System.Drawing.Point(0, 33)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            ' 
            ' xrPageBreak5
            ' 
            Me.xrPageBreak5.Location = New System.Drawing.Point(0, 175)
            Me.xrPageBreak5.Name = "xrPageBreak5"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageBreak5 As DevExpress.XtraReports.UI.XRPageBreak
        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrPageBreak3 As DevExpress.XtraReports.UI.XRPageBreak
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrPageBreak4 As DevExpress.XtraReports.UI.XRPageBreak
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
