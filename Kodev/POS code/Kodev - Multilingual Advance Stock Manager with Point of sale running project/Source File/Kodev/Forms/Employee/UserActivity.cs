using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodev.Forms.Employee
{
    public partial class UserActivity : Form
    {
        public UserActivity()
        {
            InitializeComponent();
            clsUtility.FillDataGrid(" SELECT users.USER_ID, fullName, Login_Datetime,Logout_Datetime FROM  login  inner JOIN users ON users.USER_ID = login.user_id " , useract);
        }
    }
}
