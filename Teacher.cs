using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
   public partial class Teacherform : Form1
    {
        List<User> Users = new List<User>();
        User self = new User();
        public Teacherform(List<User>registeredUsers, User self)
        {
            this.Users = registeredUsers;
            this.self = self;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public User findUserById(int id)
        {
            foreach(User user in Users)
            
                if (user.id == id)
               return user;
               return null; 
        }
    }
}
