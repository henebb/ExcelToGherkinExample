namespace ExcelToGherkinExample
{
    public class ExcelColumn
    {
        private int _id;
        private int _width;

        public ExcelColumn(int id)
        {
            _id = id;
        }

        public int Id { get { return _id; } }

        public int Width { get { return _width; } set { _width = value; } }
    }
}