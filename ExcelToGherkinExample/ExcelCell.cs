namespace ExcelToGherkinExample
{
    public class ExcelCell
    {
        private ExcelColumn _column;
        private ExcelRow _row;
        private string _value;

        public ExcelColumn Column { get { return _column; } }
        public ExcelRow Row { get { return _row; } }

        public string Value { get { return _value; } }

        public ExcelCell(int colIndex, int rowIndex, string value)
        {
            _column = new ExcelColumn(colIndex);
            _row = new ExcelRow(rowIndex);
            _value = value;
        }
    }
}