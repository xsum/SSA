namespace 学生成绩档案
{
    partial class FormDenglu
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
            this.textBoxHaoma = new System.Windows.Forms.TextBox();
            this.textBoxMima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDenglu = new System.Windows.Forms.Button();
            this.buttonTuichu = new System.Windows.Forms.Button();
            this.radioButtonXuesheng = new System.Windows.Forms.RadioButton();
            this.radioButtonJiaoshi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHaoma
            // 
            this.textBoxHaoma.Location = new System.Drawing.Point(107, 27);
            this.textBoxHaoma.Name = "textBoxHaoma";
            this.textBoxHaoma.Size = new System.Drawing.Size(123, 21);
            this.textBoxHaoma.TabIndex = 0;
            // 
            // textBoxMima
            // 
            this.textBoxMima.Location = new System.Drawing.Point(107, 79);
            this.textBoxMima.Name = "textBoxMima";
            this.textBoxMima.Size = new System.Drawing.Size(123, 21);
            this.textBoxMima.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // buttonDenglu
            // 
            this.buttonDenglu.Location = new System.Drawing.Point(46, 156);
            this.buttonDenglu.Name = "buttonDenglu";
            this.buttonDenglu.Size = new System.Drawing.Size(75, 23);
            this.buttonDenglu.TabIndex = 4;
            this.buttonDenglu.Text = "登录";
            this.buttonDenglu.UseVisualStyleBackColor = true;
            this.buttonDenglu.Click += new System.EventHandler(this.buttonDenglu_Click);
            // 
            // buttonTuichu
            // 
            this.buttonTuichu.Location = new System.Drawing.Point(155, 156);
            this.buttonTuichu.Name = "buttonTuichu";
            this.buttonTuichu.Size = new System.Drawing.Size(75, 23);
            this.buttonTuichu.TabIndex = 5;
            this.buttonTuichu.Text = "退出";
            this.buttonTuichu.UseVisualStyleBackColor = true;
            this.buttonTuichu.Click += new System.EventHandler(this.buttonTuichu_Click);
            // 
            // radioButtonXuesheng
            // 
            this.radioButtonXuesheng.AutoSize = true;
            this.radioButtonXuesheng.Location = new System.Drawing.Point(107, 120);
            this.radioButtonXuesheng.Name = "radioButtonXuesheng";
            this.radioButtonXuesheng.Size = new System.Drawing.Size(47, 16);
            this.radioButtonXuesheng.TabIndex = 6;
            this.radioButtonXuesheng.TabStop = true;
            this.radioButtonXuesheng.Text = "学生";
            this.radioButtonXuesheng.UseVisualStyleBackColor = true;
            this.radioButtonXuesheng.CheckedChanged += new System.EventHandler(this.radioButtonXuesheng_CheckedChanged);
            // 
            // radioButtonJiaoshi
            // 
            this.radioButtonJiaoshi.AutoSize = true;
            this.radioButtonJiaoshi.Location = new System.Drawing.Point(183, 120);
            this.radioButtonJiaoshi.Name = "radioButtonJiaoshi";
            this.radioButtonJiaoshi.Size = new System.Drawing.Size(47, 16);
            this.radioButtonJiaoshi.TabIndex = 7;
            this.radioButtonJiaoshi.TabStop = true;
            this.radioButtonJiaoshi.Text = "教师";
            this.radioButtonJiaoshi.UseVisualStyleBackColor = true;
            this.radioButtonJiaoshi.CheckedChanged += new System.EventHandler(this.radioButtonJiaoshi_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "身份";
            // 
            // FormDenglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 201);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonJiaoshi);
            this.Controls.Add(this.radioButtonXuesheng);
            this.Controls.Add(this.buttonTuichu);
            this.Controls.Add(this.buttonDenglu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMima);
            this.Controls.Add(this.textBoxHaoma);
            this.Name = "FormDenglu";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHaoma;
        private System.Windows.Forms.TextBox textBoxMima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDenglu;
        private System.Windows.Forms.Button buttonTuichu;
        private System.Windows.Forms.RadioButton radioButtonXuesheng;
        private System.Windows.Forms.RadioButton radioButtonJiaoshi;
        private System.Windows.Forms.Label label3;
    }
}