using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task6.Events;
using Task6.Properties;

namespace Task6
{
    public partial class ExamForm : Form, IExamForm
    {
        public event EventHandler<ExamTimeEvent> ExamTimeHandler; 
        public ExamTimeEvent Ev = new ExamTimeEvent();
        private int students = 0;
        public ExamForm()
        {
            InitializeComponent();
            AddColumnsListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsView.Items.Clear();
            studentsView.Refresh();
            students = 0;
            startButton.Enabled = false;
            ExamTimeHandler?.Invoke(this, Ev);
        }
        public void DisplayStudentName(Student student)
        {
            if (student != null)
            {
                ListViewItem item1 = new ListViewItem(new[] {(students++).ToString(), student.Name, student.Family, ""})
                {
                    Checked = true
                };
                if (studentsView.InvokeRequired)
                {
                    studentsView.Invoke(new Action(() =>
                    {
                        studentsView.Items.Add(item1);
                        studentsView.Refresh();
                    }));
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void InformAboutFinish()
        {
            startButton.Enabled = true;
            MessageBox.Show(Resources.Finish);
        }

        public void DisplayStudentMark(int mark)
        {
            if (mark > 2 && mark < 5)
            {
                studentsView.Items[students - 1].SubItems[3] =
                    new ListViewItem.ListViewSubItem(studentsView.Items[studentsView.Items.Count - 1], mark.ToString());
                studentsView.Refresh();
                if (students == RandomHelper.RandomStudents)
                    InformAboutFinish();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        private void AddColumnsListView()
        {
            studentsView.Columns.Add("№", 25, HorizontalAlignment.Left);
            studentsView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            studentsView.Columns.Add("Family", 150, HorizontalAlignment.Left);
            studentsView.Columns.Add("Mark", -2, HorizontalAlignment.Center);
        }

        public void SetProgressBar(int numberOfStudents)
        {
            if (numberOfStudents >= 0)
            {
                this.progressBar.Maximum = numberOfStudents;
                this.progressBar.Refresh();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void ProgressUp()
        {
            progressBar.Increment(1);
            progressBar.Refresh();
        }
    }
}
