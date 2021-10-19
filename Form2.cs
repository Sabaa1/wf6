using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp6
{

    public partial class Form2 : Form
    {
        List<User> Users = new List<User>();
        User self = new User();
        public Form2(List<User> registeredUsers, User self)
        {
            this.Users = registeredUsers;
            this.self = self;
            InitializeComponent();
        }
        XmlDocument xmlcourses = new XmlDocument();
        Course Course = new Course();
        public User findUserById(int id)
        {
            foreach (User user in Users)

                if (user.id == id)
                    return user;
            return null;
        }

        public void loadCourses()
        {
            Course.name = self.course;
            Course.teacher = self;
            xmlcourses.Load("../../Courses.xml");
            foreach (XmlNode course in xmlcourses.SelectSingleNode("Courses").ChildNodes)
            {
                try
                {
                    if (course.SelectSingleNode("name").InnerText == Course.name)
                    {
                        foreach (XmlNode studentid in xmlcourses.SelectSingleNode("Students").ChildNodes)
                        {
                            User student = findUserById(int.Parse(studentid.InnerText));
                            Course.students.Add(student);
                        }
                        foreach (XmlNode studentGrade in xmlcourses.SelectSingleNode("Grades").ChildNodes)
                        {
                            Grade grade = new Grade();
                            grade.mark = int.Parse(studentGrade.SelectSingleNode("mark").InnerText);
                            grade.studentid = int.Parse(studentGrade.SelectSingleNode("studentid").InnerText);
                            grade.date = studentGrade.SelectSingleNode("date").InnerText;
                            Course.grades.Add(grade);
                        }
                    }
                }
                catch
                {
                }

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            StatsChart.Hide();
            loadCourses();
            foreach (User student in Course.students)
            {
                StatsView.Rows.Add(false, student.id, student.name, student.lastname);
            }

        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            string selectedStudent = string.Empty;
            int selectedid = 0;
            bool search = false;
            for (int i = 0; i < StatsView.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(StatsView.Rows[i].Cells[0].Value) == true)
                {
                    search = true;
                    selectedid = int.Parse(StatsView.Rows[i].Cells[1].Value.ToString());
                    selectedStudent += StatsView.Rows[i].Cells[2].Value.ToString() + " " + StatsView.Rows[i].Cells[3].Value.ToString();
                }
            }


            if (search)
            {
                StatsChart.Show();
                StatsChart.Titles[0].Text = selectedid.ToString();
                int k = 0;
                foreach(Grade grade in Course.grades)
                {
                    k += 1;
                    if (grade.studentid == selectedid)
                    {
                        StatsChart.Series[0].Points.AddXY(k, grade.mark);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select on of the students in DataGridView");
            }
                }
        private void StatsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
