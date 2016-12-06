using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    public class Deanery
    {
        public event EventHandler<ExamEvent> ExamHandler;
        private readonly ExamEvent _examEvent = new ExamEvent();
        private readonly IExamForm _examForm;
        private readonly List<Student> _studentsList = new List<Student>();
        private readonly object _locker = new object();

        public Deanery(IExamForm examForm)
        {
            this._examForm = examForm;
            examForm.ExamTimeHandler += StartExam;
        }
        protected virtual void StartExam(object sender, EventArgs e)
        {
            _studentsList.Clear();
            RandomHelper.Reset();
            _examForm.SetProgressBar(RandomHelper.RandomStudents);
            for (int i = 0; i < RandomHelper.RandomStudents; i++)
                _studentsList.Add(new Student(this, RandomHelper.RandomName, RandomHelper.RandomFamily));
            ExamHandler?.Invoke(this, _examEvent);
        }

        internal void TakeExam(Student student)
        {
            lock (_locker)
            {
                _examForm.DisplayStudentName(student);
                _examForm.ProgressUp();
                Thread.Sleep(RandomHelper.RandomTimeSleep);
                _examForm.DisplayStudentMark(RandomHelper.RandomMarks);
            }
        }
    }
}
