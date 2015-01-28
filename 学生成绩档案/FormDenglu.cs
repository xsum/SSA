using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生成绩档案
{
    public partial class FormDenglu : Form
    {
        public FormDenglu()
        {
            InitializeComponent();
        }

        private void radioButtonXuesheng_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "学号";
        }

        private void radioButtonJiaoshi_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "工号";
        }

        private void buttonDenglu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            if (this.radioButtonXuesheng.Checked)
            {
                string sql = "SELECT 学号, 密码 FROM 学生 "
                    + "WHERE 学号 = '" + textBoxHaoma.Text + "'"
                    + "AND 密码 ='" + textBoxMima.Text + "'";
                SqlCommand com1 = new SqlCommand();
                com1.CommandText = sql;
                com1.Connection = con;
                con.Open();
                SqlDataReader sdr = com1.ExecuteReader();
                if (sdr.Read())
                {
                    string xuehao = textBoxHaoma.Text;
                    new FormXuesheng(xuehao).Show();
                    con.Close();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("学号或密码错误");
                }
            }
            else if (this.radioButtonJiaoshi.Checked)
            {
                string sql = "SELECT 工号, 密码 FROM 教师 "
                    + "WHERE 工号 = '" + textBoxHaoma.Text + "'"
                    + "AND 密码 ='" + textBoxMima.Text + "'";
                SqlCommand com1 = new SqlCommand();
                com1.CommandText = sql;
                com1.Connection = con;
                con.Open();
                SqlDataReader sdr = com1.ExecuteReader();
                if (sdr.Read())
                {
                    string gonghao = textBoxHaoma.Text;
                    new FormJiaoshi(gonghao).Show();
                    con.Close();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("工号或密码错误");
                }
            }
            else
            {
                MessageBox.Show("请选择身份");
            }
        }

        private void buttonTuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
