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
            string sql = "SELECT  成绩.学号, 学生.姓名, 学生.班级, 课程.课程名称 as 科目, 成绩.回数, 成绩.成绩 "
                    + "FROM 成绩 "
                    + "JOIN 学生 "
                    + "ON 成绩.学号 = 学生.学号 "
                    + "JOIN 课程 "
                    + "ON 成绩.课程编号 = 课程.课程编号 "
                    + "WHERE 成绩.学号 = '" + textBoxGerenXuehao.Text + "' "
                    + "AND 成绩.回数 =  '" + textBoxGerenHuishu.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonFenshu_Click(object sender, EventArgs e)
        {

        }

        private void buttonChengjiXinzeng_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd.Connection = con;
                cmd.CommandText = @"insert into 
                成绩 values('" + a + "','" + b + "','" + c + "','" + d + "','" + f + "')";
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("添加失败");
                }
                else
                {
                    string sql = "select 学号, 姓名 from 成绩";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                    this.textBox3.Clear();
                    this.textBox4.Clear();
                    this.textBox5.Clear();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }*/
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
