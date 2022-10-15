using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 회원가입_로그인
{
    public partial class Form1 : Form
    {
        string Conn = "Server=localhost;Database=signup;Uid=root;Pwd=dlalsrl2344@;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {

        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {
            
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc = new MySqlCommand("insert into ui(name,tall,weight) values('" + name_text.Text + "','" + tall_text.Text + "','"+weight_text.Text+"');", conn); ;
                    int insert = msc.ExecuteNonQuery();


                    if (insert == 1)
                    {
                    MessageBox.Show("입력 되었습니다");
                    }
                }
               
            }
        }
    }

