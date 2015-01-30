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
    public partial class FormJiaoshi : Form
    {
        string gonghao;

        public FormJiaoshi(string gonghao)
        {
            InitializeComponent();
            this.gonghao = gonghao;
        }

        private void FormJiaoshi_Load(object sender, EventArgs e)
        {
            labelGonghao.Text = gonghao;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT 姓名 FROM 教师 WHERE 工号 = '" + labelGonghao.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.labelXingming.Text = ds.Tables[0].Rows[0][0].ToString();

            string sql2 = "SELECT  成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                    + "FROM 成绩 "
                    + "JOIN 学生 "
                    + "ON 成绩.学号 = 学生.学号 "
                    + "JOIN 课程 "
                    + "ON 成绩.课程编号 = 课程.课程编号";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            this.dataGridView1.DataSource = ds2.Tables[0].DefaultView;

            this.toolStripStatusLabel1.Text = "欢迎使用";
        }

        private void buttonBanji_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT  成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                    + "FROM 成绩 "
                    + "JOIN 学生 "
                    + "ON 成绩.学号 = 学生.学号 "
                    + "JOIN 课程 "
                    + "ON 成绩.课程编号 = 课程.课程编号 "
                    + "WHERE 学生.班级 = '" + textBoxBanjiBanji.Text + "' "
                    + "AND 课程.课程名称 =  '" + comboBoxBanjiKemu.Text + "' "
                    + "AND 成绩.回数 =  '" + textBoxBanjiHuishu.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonGeren_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT 回数, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='101' AND 学号='" + textBoxGerenXuehao.Text + "' AND t1.回数=t2.回数) AS 语文, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='102' AND 学号='" + textBoxGerenXuehao.Text + "' AND t1.回数=t2.回数) AS 数学, "
                    + "(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='103' AND 学号='" + textBoxGerenXuehao.Text + "' AND t1.回数=t2.回数) AS 英语 "
                    + "FROM 成绩 AS t2 "
                    + "GROUP BY 回数";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            string sql2 = "SELECT 班级, 姓名 FROM 学生 WHERE 学号='" + textBoxGerenXuehao.Text + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            this.textBoxGerenXinxi.Text = ds2.Tables[0].Rows[0][0].ToString() + "班 " + ds2.Tables[0].Rows[0][1].ToString();
        }

        private void buttonFenshu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "SELECT  成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                    + "FROM 成绩 "
                    + "JOIN 学生 "
                    + "ON 成绩.学号 = 学生.学号 "
                    + "JOIN 课程 "
                    + "ON 成绩.课程编号 = 课程.课程编号 "
                    + "WHERE 成绩.成绩 >='" + textBoxFenshuFanwei1.Text + "' "
                    + "AND 成绩.成绩 <='" + textBoxFenshuFanwei2.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonChengjiXinzeng_Click(object sender, EventArgs e)
        {
            string a = comboBoxChengjiKemu.Text;
            if(a == "语文")
            {
                a = "101";
            }
            if (a == "数学")
            {
                a = "102";
            }
            if (a == "英语")
            {
                a = "103";
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql3 = "SELECT COUNT(*) "
                    + "FROM 成绩 "
                    + "WHERE 学号 = '" + textBoxChengjiXuehao.Text + "' "
                    + "AND 课程编号 = '" + a + "' "
                    + "AND 回数 = '" + textBoxChengjiHuishu.Text + "'";
            SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            string j = ds3.Tables[0].Rows[0][0].ToString();
            if(j!="0")
            {
                MessageBox.Show("分数已存在");
            }
            else
            {
                string sql = "INSERT 成绩 "
                        + "VALUES ('" + textBoxChengjiXuehao.Text + "', "
                        + "'" + a + "', "
                        + "'" + textBoxChengjiHuishu.Text + "', "
                        + "'" + textBoxChengjiChengji.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("添加失败");
                }
                else
                {
                    string sql2 = "SELECT 成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                        + "FROM 成绩 "
                        + "JOIN 学生 "
                        + "ON 成绩.学号 = 学生.学号 "
                        + "JOIN 课程 "
                        + "ON 成绩.课程编号 = 课程.课程编号 "
                        + "WHERE 成绩.学号 = '" + textBoxChengjiXuehao.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql2, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    this.textBoxChengjiChengji.Clear();
                }
            }
        }

        private void buttonChengjiXiugai_Click(object sender, EventArgs e)
        {
            string a = comboBoxChengjiKemu.Text;
            if (a == "语文")
            {
                a = "101";
            }
            if (a == "数学")
            {
                a = "102";
            }
            if (a == "英语")
            {
                a = "103";
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql3 = "SELECT COUNT(*) "
                    + "FROM 成绩 "
                    + "WHERE 学号 = '" + textBoxChengjiXuehao.Text + "' "
                    + "AND 课程编号 = '" + a + "' "
                    + "AND 回数 = '" + textBoxChengjiHuishu.Text + "'";
            SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            string j = ds3.Tables[0].Rows[0][0].ToString();
            if (j == "0")
            {
                MessageBox.Show("分数不存在");
            }
            else
            {
                string sql = "UPDATE 成绩 "
                        + "SET 成绩 = '" + textBoxChengjiChengji.Text + "' "
                        + "WHERE 学号 = '" + textBoxChengjiXuehao.Text + "' "
                        + "AND 课程编号 = '" + a + "' "
                        + "AND 回数 = '" + textBoxChengjiHuishu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("修改失败");
                }
                else
                {
                    string sql2 = "SELECT 成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                        + "FROM 成绩 "
                        + "JOIN 学生 "
                        + "ON 成绩.学号 = 学生.学号 "
                        + "JOIN 课程 "
                        + "ON 成绩.课程编号 = 课程.课程编号 "
                        + "WHERE 成绩.学号 = '" + textBoxChengjiXuehao.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql2, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    this.textBoxChengjiChengji.Clear();
                }
            }
        }

        private void buttonChengjiShanchu_Click(object sender, EventArgs e)
        {
            string a = comboBoxChengjiKemu.Text;
            if (a == "语文")
            {
                a = "101";
            }
            if (a == "数学")
            {
                a = "102";
            }
            if (a == "英语")
            {
                a = "103";
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql3 = "SELECT COUNT(*) "
                    + "FROM 成绩 "
                    + "WHERE 学号 = '" + textBoxChengjiXuehao.Text + "' "
                    + "AND 课程编号 = '" + a + "' "
                    + "AND 回数 = '" + textBoxChengjiHuishu.Text + "'";
            SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, con);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            string j = ds3.Tables[0].Rows[0][0].ToString();
            if (j == "0")
            {
                MessageBox.Show("分数不存在");
            }
            else
            {
                string sql = "DELETE 成绩 "
                        + "WHERE 学号 = '" + textBoxChengjiXuehao.Text + "' "
                        + "AND 课程编号 = '" + a + "' "
                        + "AND 回数 = '" + textBoxChengjiHuishu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("删除失败");
                }
                else
                {
                    string sql2 = "SELECT 成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                        + "FROM 成绩 "
                        + "JOIN 学生 "
                        + "ON 成绩.学号 = 学生.学号 "
                        + "JOIN 课程 "
                        + "ON 成绩.课程编号 = 课程.课程编号 "
                        + "WHERE 成绩.学号 = '" + textBoxChengjiXuehao.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql2, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    this.textBoxChengjiChengji.Clear();
                }
            }
        }

        private void buttonXinxiXinzeng_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            string sql = "INSERT  学生 "
                    + "VALUES ('" + textBoxXinxiXuehao.Text + "', "
                    + "'" + textBoxXinxiXingming.Text + "', "
                    + "'" + textBoxXinxiBanji.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                MessageBox.Show("添加失败");
            }
            else
            {
                string sql2 = "SELECT  * "
                    + "FROM 学生 "
                    + "WHERE 学生.班级 = '" + textBoxXinxiBanji.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql2, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                this.textBoxXinxiXuehao.Clear();
                this.textBoxXinxiXingming.Clear();
                this.textBoxXinxiBanji.Clear();
            }
        }

        private void buttonXingxinXiugai_Click(object sender, EventArgs e)
        {

        }

        private void buttonXinxiShanchu_Click(object sender, EventArgs e)
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
    }
}
