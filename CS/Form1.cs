using System;
using System.Windows.Forms;

using System.Diagnostics;
using System.Drawing.Imaging;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...


namespace ExportToImageCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // A path to export a report.
            string reportPath = "c:\\Test.png";

            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Get its Image export options.
            ImageExportOptions imageOptions = report.ExportOptions.Image;

            // Set Image-specific export options.
            imageOptions.Format = ImageFormat.Png;

            // Export the report to Image.
            report.ExportToImage(reportPath);

            // Show the result.
            StartProcess(reportPath);
        }

        // Use this method if you want to automaically open
        // the created Image file in the default program.
        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }
    }
}