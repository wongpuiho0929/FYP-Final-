using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        //private System.ComponentModel.Container components;
        private System.Windows.Forms.Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;
        public Form1()
        {
            InitializeComponent();
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                streamToPrint = new StreamReader
                   ("C:\\My Documents\\x.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    //PrintDialog pdi = new PrintDialog();
                    //pdi.Document = pd;
                    pd.PrinterSettings.PrinterName = "Bullzip PDF Printer";
                   
                    /*if (pdi.ShowDialog() == DialogResult.OK)
                    {
                        pd.Print();
                    }*/
                    pd.Print();
                    /*else
                    {
                        MessageBox.Show("Print Cancelled");
                    }*/
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
