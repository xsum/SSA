namespace 学生成绩档案
{
    partial class FormXuesheng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelXuehao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelXingming = new System.Windows.Forms.Label();
            this.labelBanji = new System.Windows.Forms.Label();
            this.buttonZhuxiao = new System.Windows.Forms.Button();
            this.buttonTuichu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBanji);
            this.groupBox1.Controls.Add(this.labelXingming);
            this.groupBox1.Controls.Add(this.labelXuehao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // labelXuehao
            // 
            this.labelXuehao.AutoSize = true;
            this.labelXuehao.Location = new System.Drawing.Point(55, 26);
            this.labelXuehao.Name = "labelXuehao";
            this.labelXuehao.Size = new System.Drawing.Size(17, 12);
            this.labelXuehao.TabIndex = 3;
            this.labelXuehao.Text = "空";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(529, 501);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelXingming
            // 
            this.labelXingming.AutoSize = true;
            this.labelXingming.Location = new System.Drawing.Point(55, 50);
            this.labelXingming.Name = "labelXingming";
            this.labelXingming.Size = new System.Drawing.Size(17, 12);
            this.labelXingming.TabIndex = 4;
            this.labelXingming.Text = "空";
            // 
            // labelBanji
            // 
            this.labelBanji.AutoSize = true;
            this.labelBanji.Location = new System.Drawing.Point(55, 77);
            this.labelBanji.Name = "labelBanji";
            this.labelBanji.Size = new System.Drawing.Size(17, 12);
            this.labelBanji.TabIndex = 5;
            this.labelBanji.Text = "空";
            // 
            // buttonZhuxiao
            // 
            this.buttonZhuxiao.Location = new System.Drawing.Point(20, 490);
            this.buttonZhuxiao.Name = "buttonZhuxiao";
            this.buttonZhuxiao.Size = new System.Drawing.Size(75, 23);
            this.buttonZhuxiao.TabIndex = 2;
            this.buttonZhuxiao.Text = "注销";
            this.buttonZhuxiao.UseVisualStyleBackColor = true;
            // 
            // buttonTuichu
            // 
            this.buttonTuichu.Location = new System.Drawing.Point(122, 490);
            this.buttonTuichu.Name = "buttonTuichu";
            this.buttonTuichu.Size = new System.Drawing.Size(75, 23);
            this.buttonTuichu.TabIndex = 3;
            this.buttonTuichu.Text = "退出";
            this.buttonTuichu.UseVisualStyleBackColor = true;
            // 
            // FormXuesheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 525);
            this.Controls.Add(this.buttonTuichu);
            this.Controls.Add(this.buttonZhuxiao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormXuesheng";
            this.Text = "学生成绩档案";
            this.Load += new System.EventHandler(this.FormXuesheng_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelXuehao;
        private System.Windows.Forms.Label labelBanji;
        private System.Windows.Forms.Label labelXingming;
        private System.Windows.Forms.Button buttonZhuxiao;
        private System.Windows.Forms.Button buttonTuichu;
    }
}