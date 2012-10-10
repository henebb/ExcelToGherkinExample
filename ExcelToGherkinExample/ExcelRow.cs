namespace ExcelToGherkinExample
{
    public class ExcelRow
    {
        private int _id;

        public ExcelRow(int id)
        {
            _id = id;
        }

        public int Id { get { return _id; } }
    }
}