using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task6.Interfaces;

namespace Task6
{
    public class Student : IStudent
    {
        public string Name;
        public string Family;
        private readonly Deanery _deanery;

        public Student(Deanery deanery, string name, string family)
        {
            _deanery = deanery;
            Name = name;
            Family = family;
            deanery.ExamHandler += PassExam;
        }

        public void PassExam(object sender, ExamEvent e)
        {
            ThreadPool.QueueUserWorkItem(PassExam);
        }
        public void PassExam(Object stateInfo)
        {
            Thread.Sleep(RandomHelper.RandomTimeSleep);
            _deanery.TakeExam(this);
        }
    }
}
