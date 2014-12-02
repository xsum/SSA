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
            con.ConnectionString = "server=.;database=学生成绩档案;uid=sa;pwd=2001";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToString();
            string b = textBox2.Text.ToString();
            string c = textBox3.Text.ToString();
            string d = textBox4.Text.ToString();
            string f = textBox5.Text.ToString();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "server=.;database=学生成绩档案;uid=sa;pwd=2001";
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
                    string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩";
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
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string name = this.textBox6.Text.ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=学生成绩档案;uid=sa;pwd=2001";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩 where 姓名 like '%" + name + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button_inquiry_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(this.textBox7.Text);
            int b = Int32.Parse(this.textBox8.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=学生成绩档案;uid=sa;pwd=2001";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select 学号 as 学号, 姓名 as 姓名, 语文 as 语文, 数学 as 数学 , 英语 as 英语 from 成绩";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
