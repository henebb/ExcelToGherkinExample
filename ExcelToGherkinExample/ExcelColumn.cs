namespace ExcelToGherkinExample
{
    public class ExcelColumn
    {
        private int _id;

        public ExcelColumn(int id)
        {
            _id = id;
        }

        public int Id { get { return _id; } }

        public int Width { get; set; }
    }
}