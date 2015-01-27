using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生成绩档案
{
    public partial class FormXuesheng : Form
    {
        public FormXuesheng()
        {
            InitializeComponent();

        }

        private void FormXuesheng_Load(object sender, EventArgs e)
        {
            this.label4.Text = ((FormDenglu)this.Owner).passText;
        }
    }
    
}
