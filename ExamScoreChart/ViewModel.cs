using System.Collections.ObjectModel;

namespace ExamScoreChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { Subject = "Verbal", ExamName = "GRE", ChatGPT3_5 = 63, ChatGPT4_0 = 99 });
            Data.Add(new Model() { Subject = "Evidence-based Reading&Writing", ExamName = "SAT", ChatGPT3_5 = 87, ChatGPT4_0 = 93 });
            Data.Add(new Model() { Subject = "Uniform Bar Exam", ExamName = "Law", ChatGPT3_5 = 10, ChatGPT4_0 = 90 });
            Data.Add(new Model() { Subject = "Math", ExamName = "SAT", ChatGPT3_5 = 70, ChatGPT4_0 = 89 });
            Data.Add(new Model() { Subject = "LSAT", ExamName = "Law", ChatGPT3_5 = 40, ChatGPT4_0 = 88 });
            Data.Add(new Model() { Subject = "Biology", ExamName = "Advanced Placement", ChatGPT3_5 = 62, ChatGPT4_0 = 85 });
            Data.Add(new Model() { Subject = "Psychology", ExamName = "Advanced Placement", ChatGPT3_5 = 83, ChatGPT4_0 = 83 });
            Data.Add(new Model() { Subject = "Quantitative", ExamName = "GRE", ChatGPT3_5 = 25, ChatGPT4_0 = 80 });
            Data.Add(new Model() { Subject = "Chemistry", ExamName = "Advanced Placement", ChatGPT3_5 = 22, ChatGPT4_0 = 71 });
            Data.Add(new Model() { Subject = "Physics-2", ExamName = "Advanced Placement", ChatGPT3_5 = 30, ChatGPT4_0 = 66 });
            Data.Add(new Model() { Subject = "English Language", ExamName = "Advanced Placement", ChatGPT3_5 = 14, ChatGPT4_0 = 14 });
        }
    }

    public class Model
    {
        private string _subject;
        private string _examName;
        private string _mainString;

        public string MainString
        {
            get { return _mainString; }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                _mainString = _subject + "\n" + _examName;
            }
        }

        public string? ExamName
        {
            get { return _examName; }
            set
            {
                _examName = value;
                _mainString = _subject + "\n" + _examName;
            }
        }

        public double ChatGPT4_0 { get; set; }
        public double ChatGPT3_5 { get; set; }
    }
}