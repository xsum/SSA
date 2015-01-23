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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "SELECT  成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                    +"FROM 成绩 "
                    +"JOIN 学生 "
                    +"ON 成绩.学号 = 学生.学号 "
                    +"JOIN 课程 "
                    +"ON 成绩.课程编号 = 课程.课程编号";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
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

        private void buttonChengjiXiugai_Click(object sender, EventArgs e)
        {

        }

        private void buttonChengjiShanchu_Click(object sender, EventArgs e)
        {

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

    }
}
