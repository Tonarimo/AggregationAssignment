using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggregationAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCoursesListBox();
        }

        private void PopulateCoursesListBox()
        {
            List<Course> courses = Course.GetCourses();
            foreach (var item in courses)
            {
                lstClassList.Items.Add(item.Number);
            }
        }

        private void btnViewInstructor_Click(object sender, EventArgs e)
        {
            string course = (string)lstClassList.SelectedItem;

            Instructor i = Course.GetInstructor(course);
            if (i != null)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void btnViewRoster_Click(object sender, EventArgs e)
        {
            string course = (string)lstClassList.SelectedItem;
            List<Student> students = Course.LoadRoster(course);
            if (students != null)
            {
                string stu = "";
                for (int i = 0; i < students.Count; ++i)
                {
                    stu += students[i].ToString() + "\n";
                }
                MessageBox.Show(stu);
            }
        }
    }
}
