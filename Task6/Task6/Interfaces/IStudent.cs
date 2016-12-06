using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Interfaces
{
    interface IStudent
    {
        void PassExam(object sender, ExamEvent e);
    }
}
