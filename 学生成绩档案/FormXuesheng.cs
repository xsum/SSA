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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT 回数, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='101' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 语文, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='102' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 数学, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='103' AND 学号='" + labelXuehao.Text + "' AND t1.回数=t2.回数) AS 英语 "
                    + "FROM 成绩 AS t2 "
                    + "GROUP BY 回数";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
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
            labelXingming.Text = ds.Tables[0].Rows[0][0].ToString();
        }
    }
    
}
