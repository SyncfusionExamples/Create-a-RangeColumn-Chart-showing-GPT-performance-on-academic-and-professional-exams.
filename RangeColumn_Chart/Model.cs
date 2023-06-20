namespace ExamScoreChart
{

    public class Model
    {
        private string _subject;
        private string _examType;
        private string _examName;

        public string ExamName
        {
            get { return _examName; }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                _examName = _subject + "\n" + _examType;
            }
        }

        public string? ExamType
        {
            get { return _examType; }
            set
            {
                _examType = value;
                _examName = _subject + "\n" + _examType;
            }
        }

        public double ChatGPT_4 { get; set; }
        public double ChatGPT_35 { get; set; }
    }
}
