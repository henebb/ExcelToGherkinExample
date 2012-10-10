using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelToGherkinExample
{
    public partial class GherkinExampleRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void CreateGherkinExampleButtonClick(object sender, RibbonControlEventArgs e)
        {
            Range selection = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;

            ExcelData excelData = new ExcelData();

            int numRows = selection.Rows.Count;
            int numCols = selection.Columns.Count;
            for (int colIndex = 1; colIndex <= numCols; colIndex++)
            {
                for (int rowIndex = 1; rowIndex <= numRows; rowIndex++)    
                {
                    var o = ((Range) selection.Cells[rowIndex, colIndex]).Value2;

                    excelData.AddCell(colIndex-1, rowIndex-1, o.ToString());

                }
            }

            StringBuilder sb = new StringBuilder();
            bool isFirstRow = true;
            for (int i = 0; i < numRows; i++)
            {
                List<string> rowValues = excelData.GetRowValues(i);

                bool isFirstColumn = true;
                foreach (string value in rowValues)
                {
                    if (isFirstColumn)
                    {
                        sb.Append("    ");
                        isFirstColumn = false;
                    }
                    if (isFirstRow)
                    {
                        sb.AppendFormat("| {0} ", value);
                    }
                    else
                    {
                        sb.AppendFormat("|  {0}", value);
                    }
                }
                isFirstRow = false;
                sb.Append("|\r\n");
            }


            Clipboard.SetText(sb.ToString());

            MessageBox.Show("Gherkin example added to clipboard. You can now paste it into the specification outline example", "Example added to clipboard", MessageBoxButtons.OK);
        }
    }
}
