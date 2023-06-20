using System.Collections.ObjectModel;

namespace ExamScoreChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { Subject = "Verbal", ExamType = "GRE", ChatGPT_35 = 63, ChatGPT_4 = 99 });
            Data.Add(new Model() { Subject = "Evidence-based Reading&Writing", ExamType = "SAT", ChatGPT_35 = 87, ChatGPT_4 = 93 });
            Data.Add(new Model() { Subject = "Uniform Bar Exam", ExamType = "Law", ChatGPT_35 = 10, ChatGPT_4 = 90 });
            Data.Add(new Model() { Subject = "Math", ExamType = "SAT", ChatGPT_35 = 70, ChatGPT_4 = 89 });
            Data.Add(new Model() { Subject = "LSAT", ExamType = "Law", ChatGPT_35 = 40, ChatGPT_4 = 88 });
            Data.Add(new Model() { Subject = "Biology", ExamType = "Advanced Placement", ChatGPT_35 = 62, ChatGPT_4 = 85 });
            Data.Add(new Model() { Subject = "Psychology", ExamType = "Advanced Placement", ChatGPT_35 = 83, ChatGPT_4 = 83 });
            Data.Add(new Model() { Subject = "Quantitative", ExamType = "GRE", ChatGPT_35 = 25, ChatGPT_4 = 80 });
            Data.Add(new Model() { Subject = "Chemistry", ExamType = "Advanced Placement", ChatGPT_35 = 22, ChatGPT_4 = 71 });
            Data.Add(new Model() { Subject = "Physics-2", ExamType = "Advanced Placement", ChatGPT_35 = 30, ChatGPT_4 = 66 });
            Data.Add(new Model() { Subject = "English Language", ExamType = "Advanced Placement", ChatGPT_35 = 14, ChatGPT_4 = 14 });
        }
    }

}