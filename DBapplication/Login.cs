using System.Data;
using System;
using System.Windows.Forms;

namespace DBapplication
{
    internal class Login : Form
    {
        Controller C=new Controller();
        private Button button2;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private object controller;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(124, 57);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 22);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(124, 98);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 22);
            this.passwordtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t Have an account";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 62);
            this.button3.TabIndex = 9;
            this.button3.Text = "Button for testing the vhane password form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(625, 391);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        public Login(int user)
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';


        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (usernametxt.Text == "")
            {
                MessageBox.Show("enter username");
                return;
            }
            if (passwordtxt.Text == "")
            {
                MessageBox.Show("enter password");
                return;
            }
            // Get the username and password from text boxes
            string email = usernametxt.Text; // Replace with your text box variable
            string password = passwordtxt.Text;

            DataTable result = C.CheckEmailAndPassword(email, password);

            if (result != null && result.Rows.Count > 0)
            {
                // Login successful
                MessageBox.Show("Login successful!");
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changepassword change = new changepassword();
            change.Show();
            this.Hide();
        }
    } 
}