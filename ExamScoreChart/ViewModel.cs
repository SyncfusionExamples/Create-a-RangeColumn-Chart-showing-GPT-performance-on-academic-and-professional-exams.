using System.Collections.ObjectModel;

namespace ExamScoreChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {

            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { ExamName = "Verbal\n GRE", ChatGPT3_5 = 63, ChatGPT4_0 = 99 });
            Data.Add(new Model() { ExamName = "Evidence-based\n Reading&Writing\n SAT", ChatGPT3_5 = 87, ChatGPT4_0 = 93 });
            Data.Add(new Model() { ExamName = "Uniform Bar Exam\n Law", ChatGPT3_5 = 10, ChatGPT4_0 = 90 });
            Data.Add(new Model() { ExamName = "Math\n SAT", ChatGPT3_5 = 70, ChatGPT4_0 = 89 });
            Data.Add(new Model() { ExamName = "LSAT\n Law", ChatGPT3_5 = 40, ChatGPT4_0 = 88 });
            Data.Add(new Model() { ExamName = "Biology\n Advanced Placement", ChatGPT3_5 = 62, ChatGPT4_0 = 85 });
            Data.Add(new Model() { ExamName = "Psychology\n Advanced Placement", ChatGPT3_5 = 83, ChatGPT4_0 = 83 });
            Data.Add(new Model() { ExamName = "Quantitative\n GRE", ChatGPT3_5 = 25, ChatGPT4_0 = 80 });
            Data.Add(new Model() { ExamName = "Chemistry\n Advanced Placement", ChatGPT3_5 = 22, ChatGPT4_0 = 71 });
            Data.Add(new Model() { ExamName = "Physics-2\n Advanced Placement", ChatGPT3_5 = 30, ChatGPT4_0 = 66 });
            Data.Add(new Model() { ExamName = "English Language\n Advanced Placement", ChatGPT3_5 = 14, ChatGPT4_0 = 14 });
        }
    }

    public class Model
    {
        public string? ExamName { get; set; }
        public double ChatGPT4_0 { get; set; }
        public double ChatGPT3_5 { get; set; }
    }
}
