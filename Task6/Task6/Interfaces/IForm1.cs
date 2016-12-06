﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task6.Events;

namespace Task6
{
    public interface IForm1
    {
        event EventHandler<ExamTimeEvent> ExamTimeHandler;
        void DisplayStudentName(Student student);
        void DisplayStudentMark(int mark);
    }
}