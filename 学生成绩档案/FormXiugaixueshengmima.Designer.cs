namespace 学生成绩档案
{
    partial class FormXiugaixueshengmima
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYuanmima = new System.Windows.Forms.TextBox();
            this.textBoxXinmima = new System.Windows.Forms.TextBox();
            this.buttonQuexiao = new System.Windows.Forms.Button();
            this.buttonQueding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // textBoxYuanmima
            // 
            this.textBoxYuanmima.Location = new System.Drawing.Point(105, 23);
            this.textBoxYuanmima.Name = "textBoxYuanmima";
            this.textBoxYuanmima.Size = new System.Drawing.Size(100, 21);
            this.textBoxYuanmima.TabIndex = 2;
            // 
            // textBoxXinmima
            // 
            this.textBoxXinmima.Location = new System.Drawing.Point(105, 66);
            this.textBoxXinmima.Name = "textBoxXinmima";
            this.textBoxXinmima.Size = new System.Drawing.Size(100, 21);
            this.textBoxXinmima.TabIndex = 3;
            // 
            // buttonQuexiao
            // 
            this.buttonQuexiao.Location = new System.Drawing.Point(130, 112);
            this.buttonQuexiao.Name = "buttonQuexiao";
            this.buttonQuexiao.Size = new System.Drawing.Size(75, 23);
            this.buttonQuexiao.TabIndex = 4;
            this.buttonQuexiao.Text = "取消";
            this.buttonQuexiao.UseVisualStyleBackColor = true;
            this.buttonQuexiao.Click += new System.EventHandler(this.buttonQuexiao_Click);
            // 
            // buttonQueding
            // 
            this.buttonQueding.Location = new System.Drawing.Point(41, 112);
            this.buttonQueding.Name = "buttonQueding";
            this.buttonQueding.Size = new System.Drawing.Size(75, 23);
            this.buttonQueding.TabIndex = 5;
            this.buttonQueding.Text = "确定";
            this.buttonQueding.UseVisualStyleBackColor = true;
            this.buttonQueding.Click += new System.EventHandler(this.buttonQueding_Click);
            // 
            // FormXiugaixueshengmima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 162);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQueding);
            this.Controls.Add(this.buttonQuexiao);
            this.Controls.Add(this.textBoxXinmima);
            this.Controls.Add(this.textBoxYuanmima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormXiugaixueshengmima";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYuanmima;
        private System.Windows.Forms.TextBox textBoxXinmima;
        private System.Windows.Forms.Button buttonQuexiao;
        private System.Windows.Forms.Button buttonQueding;
    }
}