namespace Task6
{
    partial class ExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.studentsView = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 460);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(377, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentsView
            // 
            this.studentsView.FullRowSelect = true;
            this.studentsView.GridLines = true;
            this.studentsView.Location = new System.Drawing.Point(12, 11);
            this.studentsView.Margin = new System.Windows.Forms.Padding(2);
            this.studentsView.Name = "studentsView";
            this.studentsView.Size = new System.Drawing.Size(377, 414);
            this.studentsView.TabIndex = 0;
            this.studentsView.UseCompatibleStateImageBehavior = false;
            this.studentsView.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 431);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(376, 23);
            this.progressBar.TabIndex = 2;
            // 
            // ExamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 505);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.studentsView);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "ExamForm";
            this.Text = "Exam";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.ListView studentsView;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

