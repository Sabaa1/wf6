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
    
    public partial class Form1 : Form
    {
        XmlDocument xmlauth = new XmlDocument();
        XmlDocument xmlcourse = new XmlDocument();
        int lastId = 0;
        List<User> registeredUsers = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadRegisteredUsers()
        {
            xmlauth.Load("../../XMLFile1.xml");

            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                try
                {
                    User registeredUser = new User();
                    registeredUser.id = int.Parse(user.SelectSingleNode("id").InnerText);
                    lastId = registeredUser.id;
                    registeredUser.username = user.SelectSingleNode("username").InnerText;
                    registeredUser.password = user.SelectSingleNode("password").InnerText;
                    registeredUsers.Add(registeredUser);
                }
                catch
                {

                }
            }
        }

  
            private void LoginButton_Click(object sender, EventArgs e){        

        
            bool success = false;
            foreach (User user in registeredUsers)
            {
                if (user.username == LogUsernameBox.Text && user.password == LogPassBox.Text)
                {
                    LogResponseLabel.ForeColor = Color.Green;
                    LogResponseLabel.Text = "Response: Log In Successful. ID - " + user.id;
                   if(user.status =="TeacherForm")
                    {
                        Form2 tcForm = new Form2(registeredUsers, user);
                        this.Hide();
                        tcForm.ShowDialog();
                        this.Show();

                    }
  }
            }
            if (!success)
            {
                LogResponseLabel.ForeColor = Color.Red;
                LogResponseLabel.Text = "Response: Could not log in";
            }
            LogResponseLabel.Show();
        }
            private void RegButton_Click(object sender, EventArgs e)
            {
            bool success = true;
            foreach (User user in registeredUsers)
            {
                if (user.username == RegUsernameBox.Text)
                {
                    RegResponseLabel.ForeColor = Color.Red;
                    RegResponseLabel.Text = "Response: Username already taken";
                    success = false;
                    break;
                }
            }
            if (RegPassBox.Text != RegRePassBox.Text)
            {
                RegResponseLabel.ForeColor = Color.Red;
                RegResponseLabel.Text = "Response: Passwords do not match";
                success = false;
            }
            if (RegRePassBox.Text == string.Empty || RegPassBox.Text == string.Empty || RegUsernameBox.Text == string.Empty || RegNameBox.Text == string.Empty || RegLastnameBox.Text == string.Empty)
            {
                RegResponseLabel.ForeColor = Color.Red;
                RegResponseLabel.Text = "Response: Some fields are not filled";
                success = false;
            }
            if (success)
            {
                RegResponseLabel.Show();

                XmlNode newUser = xmlauth.CreateElement("user");

                XmlNode newUserId = xmlauth.CreateElement("id");
                newUserId.InnerText = (lastId + 1).ToString();
                newUser.AppendChild(newUserId);

                XmlNode newUsername = xmlauth.CreateElement("username");
                newUsername.InnerText = RegUsernameBox.Text;
                newUser.AppendChild(newUsername);

                XmlNode newName = xmlauth.CreateElement("name");
                newName.InnerText = RegNameBox.Text;
                newUser.AppendChild(newName);

                XmlNode newLastname = xmlauth.CreateElement("lastname");
                newLastname.InnerText = RegLastnameBox.Text;
                newUser.AppendChild(newLastname);

                XmlNode newPassword = xmlauth.CreateElement("password");
                newPassword.InnerText = RegPassBox.Text;
                newUser.AppendChild(newPassword);

                XmlNode newStatus = xmlauth.CreateElement("status");
                newStatus.InnerText = RegStatusBox.Text;
                newUser.AppendChild(newStatus);

                XmlNode newCourse = xmlauth.CreateElement("course");
                newCourse.InnerText = RegCourseBox.Text;
                newUser.AppendChild(newCourse);

                xmlauth.DocumentElement.AppendChild(newUser);
                xmlauth.Save("../../Users.xml");

                if (RegStatusBox.Text == "student")
                {
                    XmlNode studentid = xmlcourse.CreateElement("studentid");
                    studentid.InnerText = (lastId + 1).ToString();
                    foreach (XmlNode course in xmlcourse.DocumentElement.ChildNodes)
                    {
                        if (course.SelectSingleNode("name").InnerText == RegCourseBox.Text)
                        {
                            course.SelectSingleNode("Students").AppendChild(studentid);
                        }
                    }
                    xmlcourse.Save("../../Courses.xml");
                }
            
                RegResponseLabel.ForeColor = Color.Green;
                RegResponseLabel.Text = "Response: Registration completed";
                RegRePassBox.Text = string.Empty;
                RegPassBox.Text = string.Empty;
                RegUsernameBox.Text = string.Empty;
                RegNameBox.Text = string.Empty;
                RegLastnameBox.Text = string.Empty;
                RegCourseBox.Text = string.Empty;
                RegStatusBox.Text = string.Empty;
                loadRegisteredUsers();
            }
               RegResponseLabel.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RegRePassBox.PasswordChar = '*';
            LogPassBox.PasswordChar = '*';
            RegPassBox.PasswordChar = '*';
            LogResponseLabel.Hide();
            RegResponseLabel.Hide();

            loadRegisteredUsers();
            
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            LogUsernameLabel.Parent = pictureBox1;
            LogUsernameLabel.BackColor = Color.Transparent;
            LogPassLabel.Parent = pictureBox1;
            LogPassLabel.BackColor = Color.Transparent;
            RegUsernameLabel.Parent = pictureBox1;
            RegUsernameLabel.BackColor = Color.Transparent;
            RegNameLabel.Parent = pictureBox1;
            RegNameLabel.BackColor = Color.Transparent;
            RegLastnameLabel.Parent = pictureBox1;
            RegLastnameLabel.BackColor = Color.Transparent;
            RegPassLabel.Parent = pictureBox1;
            RegPassLabel.BackColor = Color.Transparent;
            RegRePassLabel.Parent = pictureBox1;
            RegRePassLabel.BackColor = Color.Transparent;
            RegPassLabel.Parent = pictureBox1; 
            RegPassLabel.BackColor = Color.Transparent;
            RegStatusLabel.BackColor = Color.Transparent;
            RegStatusLabel.Parent = pictureBox1;
            RegCourseLabel.BackColor = Color.Transparent;
            RegCourseLabel.Parent = pictureBox1;
            RegResponseLabel.BackColor = Color.Transparent;
            RegResponseLabel.Parent = pictureBox1;
            LogResponseLabel.Parent = pictureBox1;
            LogResponseLabel.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
