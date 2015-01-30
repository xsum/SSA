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
    public partial class FormXiugaixueshengmima : Form
    {
        public FormXiugaixueshengmima(string xuehao)
        {
            InitializeComponent();
            this.Text = xuehao;
        }

        private void buttonQueding_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "UPDATE 学生 "
                + "SET 密码 = '" + textBoxXinmima.Text + "' "
                + "WHERE 密码 = '" + textBoxYuanmima.Text + "' "
                + "AND 学号 = '" + this.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                MessageBox.Show("修改失败");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonQuexiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
