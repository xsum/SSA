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
    public partial class FormXuesheng : Form
    {
        string xuehao;

        public FormXuesheng(string xuehao)
        {
            InitializeComponent();
            this.xuehao = xuehao;
        }

        private void FormXuesheng_Load(object sender, EventArgs e)
        {
            labelXuehao.Text = xuehao;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT 姓名 FROM 学生 WHERE 学号 = '" + labelXuehao.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.labelXingming.Text = ds.Tables[0].Rows[0][0].ToString();

            string sql2 = "SELECT 回数, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='101' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 语文, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='102' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 数学, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='103' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 英语 "
                    + "FROM 成绩 AS t2 "
                    + "GROUP BY 回数";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            this.dataGridView1.DataSource = ds2.Tables[0].DefaultView;

            string sql3 = "SELECT 密码 FROM 学生 WHERE 学号 = '" + labelXuehao.Text + "'";
            SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            string mima = ds3.Tables[0].Rows[0][0].ToString();
            if (mima == "          ")
            {
                this.toolStripStatusLabel1.Text = "您的密码为空，请立即设置密码";
                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
                this.toolStripStatusLabel2.Text = "点我立即设置密码";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "欢迎使用";
                this.toolStripStatusLabel2.Visible = false;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonZhuxiao_Click(object sender, EventArgs e)
        {
            FormDenglu frdl = new FormDenglu();
            frdl.Show();
            this.Close();
        }

        private void buttonTuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormXiugaimima frxgmm = new FormXiugaimima();
            frxgmm.Show();
            this.Close();
        }
    }
    
}
