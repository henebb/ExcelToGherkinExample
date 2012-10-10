using System.Collections.Generic;

namespace ExcelToGherkinExample
{
    public class ExcelCellList : List<ExcelCell>
    {
        private List<int> _rowIndexList = new List<int>(10);
        private List<int> _colIndexList = new List<int>(10);

        public List<int> ColIndexes { get { return _colIndexList;  } }

        public void AddCell(int colIndex, int rowIndex, string value)
        {
            if (!_colIndexList.Exists(il => il == colIndex))
            {
                _colIndexList.Add(colIndex);
            }
            if (!_rowIndexList.Exists(il => il == rowIndex))
            {
                _rowIndexList.Add(rowIndex);
            }

            Add(new ExcelCell(colIndex, rowIndex, value));
        }
    }
}