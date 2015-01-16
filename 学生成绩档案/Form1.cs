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
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
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

        private void button_按班级查询_Click(object sender, EventArgs e)
        {/*
            string a = textBox1.Text.ToString();
            string b = textBox2.Text.ToString();
            string c = textBox3.Text.ToString();
            string d = textBox4.Text.ToString();
            string f = textBox5.Text.ToString();
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

        private void button_按个人查询_Click(object sender, EventArgs e)
        {/*
            string name = this.textBox6.Text.ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩 where 姓名 like '%" + name + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }*/
        }

        private void button_按分数查询_Click(object sender, EventArgs e)
        {/*
            int a = Int32.Parse(this.textBox7.Text);
            int b = Int32.Parse(this.textBox8.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=MX-WIN8\\SQLEXPRESS;database=学生成绩档案;Integrated Security=true";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }*/
        }
    }
}
