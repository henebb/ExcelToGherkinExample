using System.Collections.Generic;
using System.Linq;

namespace ExcelToGherkinExample
{
    public class ExcelData
    {
        private ExcelCellList _cells = new ExcelCellList();

        public void AddCell(int colIndex, int rowIndex, string value)
        {
            _cells.AddCell(colIndex, rowIndex, value);
        }

        public List<string> GetRowValues(int rowIndex)
        {
            CalculateMaxColumnWidths();

            IEnumerable<ExcelCell> excelCells = _cells.Where(c => c.Row.Id == rowIndex);
            return excelCells.Select(c => c.Value.PadRight(c.Column.Width)).ToList();
        }

        private void CalculateMaxColumnWidths()
        {
            foreach (int colIndex in _cells.ColIndexes)
            {
                int index = colIndex;
                IList<ExcelCell> excelCells = _cells.Where(c => c.Column.Id == index).ToList();
                int maxWidth = excelCells.Max(c => c.Value.Length);
                foreach (ExcelCell cell in excelCells)
                {
                    cell.Column.Width = maxWidth;
                }
            }
        }
    }
}