namespace UniversityApp
{
    partial class CourseEnrollmentUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regNoCourseTextBox = new System.Windows.Forms.TextBox();
            this.nameCourseTextBox = new System.Windows.Forms.TextBox();
            this.emailCourseTextBox = new System.Windows.Forms.TextBox();
            this.courseCourseComboBox = new System.Windows.Forms.ComboBox();
            this.findCourseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enrolledCoursesListView = new System.Windows.Forms.ListView();
            this.courseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enrollButton = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enrollment Date";
            // 
            // regNoCourseTextBox
            // 
            this.regNoCourseTextBox.Location = new System.Drawing.Point(152, 46);
            this.regNoCourseTextBox.Name = "regNoCourseTextBox";
            this.regNoCourseTextBox.Size = new System.Drawing.Size(157, 20);
            this.regNoCourseTextBox.TabIndex = 1;
            // 
            // nameCourseTextBox
            // 
            this.nameCourseTextBox.Location = new System.Drawing.Point(152, 77);
            this.nameCourseTextBox.Name = "nameCourseTextBox";
            this.nameCourseTextBox.Size = new System.Drawing.Size(273, 20);
            this.nameCourseTextBox.TabIndex = 1;
            // 
            // emailCourseTextBox
            // 
            this.emailCourseTextBox.Location = new System.Drawing.Point(152, 105);
            this.emailCourseTextBox.Name = "emailCourseTextBox";
            this.emailCourseTextBox.Size = new System.Drawing.Size(273, 20);
            this.emailCourseTextBox.TabIndex = 1;
            // 
            // courseCourseComboBox
            // 
            this.courseCourseComboBox.FormattingEnabled = true;
            this.courseCourseComboBox.Location = new System.Drawing.Point(152, 139);
            this.courseCourseComboBox.Name = "courseCourseComboBox";
            this.courseCourseComboBox.Size = new System.Drawing.Size(273, 21);
            this.courseCourseComboBox.TabIndex = 2;
            // 
            // findCourseButton
            // 
            this.findCourseButton.Location = new System.Drawing.Point(326, 44);
            this.findCourseButton.Name = "findCourseButton";
            this.findCourseButton.Size = new System.Drawing.Size(75, 23);
            this.findCourseButton.TabIndex = 3;
            this.findCourseButton.Text = "Find";
            this.findCourseButton.UseVisualStyleBackColor = true;
            this.findCourseButton.Click += new System.EventHandler(this.findCourseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enrolledCoursesListView);
            this.groupBox1.Location = new System.Drawing.Point(16, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrolled Courses";
            // 
            // enrolledCoursesListView
            // 
            this.enrolledCoursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.enrolledCoursesListView.GridLines = true;
            this.enrolledCoursesListView.Location = new System.Drawing.Point(6, 30);
            this.enrolledCoursesListView.Name = "enrolledCoursesListView";
            this.enrolledCoursesListView.Size = new System.Drawing.Size(502, 173);
            this.enrolledCoursesListView.TabIndex = 0;
            this.enrolledCoursesListView.UseCompatibleStateImageBehavior = false;
            this.enrolledCoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // courseDateTimePicker
            // 
            this.courseDateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy";
            this.courseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseDateTimePicker.Location = new System.Drawing.Point(152, 178);
            this.courseDateTimePicker.Name = "courseDateTimePicker";
            this.courseDateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.courseDateTimePicker.TabIndex = 5;
            this.courseDateTimePicker.Value = new System.DateTime(2014, 10, 18, 19, 42, 0, 0);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(353, 167);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(125, 47);
            this.enrollButton.TabIndex = 6;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course Title";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Course Name";
            this.columnHeader5.Width = 245;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Enrollment Date";
            this.columnHeader6.Width = 170;
            // 
            // CourseEnrollmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 460);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.courseDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.findCourseButton);
            this.Controls.Add(this.courseCourseComboBox);
            this.Controls.Add(this.emailCourseTextBox);
            this.Controls.Add(this.nameCourseTextBox);
            this.Controls.Add(this.regNoCourseTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CourseEnrollmentUI";
            this.Text = "Course Enrollment";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regNoCourseTextBox;
        private System.Windows.Forms.TextBox nameCourseTextBox;
        private System.Windows.Forms.TextBox emailCourseTextBox;
        private System.Windows.Forms.ComboBox courseCourseComboBox;
        private System.Windows.Forms.Button findCourseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView enrolledCoursesListView;
        private System.Windows.Forms.DateTimePicker courseDateTimePicker;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

