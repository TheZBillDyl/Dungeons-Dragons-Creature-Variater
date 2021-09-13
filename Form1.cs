using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace DungeonsAndDragonsCreatureVariator
{
    public partial class mainWindow : Form
    {
        Workbook wbook;
        Worksheet worksheet;
        Range excelRange;
        int selectedRow = 2;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void openCreatureFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                wbook = excel.Workbooks.Open(openFileDialog1.FileName,
                      Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing);
                worksheet = wbook.Sheets[1];
                excelRange = worksheet.UsedRange;
                selectedCreature.Text = excelRange.Cells[selectedRow, 3].Value.ToString();
            }

        }

        private void nextCreatureButton_Click(object sender, EventArgs e)
        {
            if(excelRange != null)
                selectedCreature.Text = excelRange.Cells[++selectedRow, 3].Value.ToString();
        }

        private void previousCreatureButton_Click(object sender, EventArgs e)
        {
            if (excelRange != null)
                selectedCreature.Text = excelRange.Cells[--selectedRow, 3].Value.ToString();
        }
    }
}
