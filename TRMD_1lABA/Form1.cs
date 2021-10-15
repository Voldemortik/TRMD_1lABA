using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRMD_1lABA.Entities;

namespace TRMD_1lABA
{
    public partial class Form1 : Form
    {
        public List<User> testUsers { get; set; } 
        public Form1()
        {
            InitializeComponent();
            testUsers = new List<User>()
            {
                new User()
                {
                    Login = "testUser1",
                    Password = "testUser1",
                    Rememberme = false
                },
                 new User()
                {
                    Login = "testUser2",
                    Password = "testUser2",
                    Rememberme = false
                },
                  new User()
                {
                    Login = "testUser3",
                    Password = "testUser3",
                    Rememberme = false
                },
                   new User()
                {
                    Login = "testUser4",
                    Password = "testUser4",
                    Rememberme = false
                },
                    new User()
                {
                    Login = "testUser5",
                    Password = "testUser5",
                    Rememberme = false
                },
            };
            this.label2.Visible = false;
            this.label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label3.Visible = false;
            this.label2.Visible = false;
            string loginFromControl =    this.textBox1.Text;
            string passwordFromControl = this.textBox2.Text;
            bool rememberMeFromControl = this.checkBox1.Checked;
            var needFullUser = testUsers
                .FirstOrDefault(x => x.Login == loginFromControl && passwordFromControl == x.Password);
            if (needFullUser==null)
            {
                this.label2.Visible = true;
                ClearForm();
                return;
            }
            needFullUser.Rememberme = rememberMeFromControl;
            this.label3.Visible = true;
            this.label3.Text = $"Welcome on board {loginFromControl}";
            ClearForm();
        }
        private void ClearForm()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.checkBox1.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
