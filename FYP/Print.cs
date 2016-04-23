using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    class Print
    {
        private StreamReader streamToPrint;
        private Font printFont;

        public void print(String fileName)
        {
            DateTime today = DateTime.Today;
            String todayString = today.ToString("dd-MM-yyyy");
            try
            {
                streamToPrint = new StreamReader
                   ("C:\\My Documents\\" + todayString + "\\" + fileName);

                try
                {
                    printFont = new Font("Arial", 20);
                    PrintDocument pd = new PrintDocument();
                    PaperSize paperSize = new PaperSize("My Envelope", 300, 370);
                    pd.DefaultPageSettings.Margins.Left = 20;
                    pd.DefaultPageSettings.Margins.Top = 10;
                    pd.DefaultPageSettings.PaperSize = paperSize;
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.PrinterSettings.PrinterName = "Bullzip PDF Printer";
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
