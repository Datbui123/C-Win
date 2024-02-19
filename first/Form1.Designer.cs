
namespace first
{
    partial class Form1
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
            this.btXinchao = new System.Windows.Forms.Button();
            this.lbHoten = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbXinchao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btXinchao
            // 
            this.btXinchao.BackColor = System.Drawing.Color.Violet;
            this.btXinchao.Location = new System.Drawing.Point(243, 67);
            this.btXinchao.Name = "btXinchao";
            this.btXinchao.Size = new System.Drawing.Size(81, 32);
            this.btXinchao.TabIndex = 0;
            this.btXinchao.Text = "Xin chào";
            this.btXinchao.UseVisualStyleBackColor = false;
            this.btXinchao.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(39, 62);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(39, 13);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ tên";
            this.lbHoten.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(118, 58);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(100, 20);
            this.tbHoten.TabIndex = 2;
            this.tbHoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLop
            // 
            this.tbLop.Location = new System.Drawing.Point(118, 83);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(100, 20);
            this.tbLop.TabIndex = 3;
            this.tbLop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(39, 86);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(25, 13);
            this.lbLop.TabIndex = 4;
            this.lbLop.Text = "Lớp";
            // 
            // lbXinchao
            // 
            this.lbXinchao.AutoSize = true;
            this.lbXinchao.Location = new System.Drawing.Point(49, 122);
            this.lbXinchao.Name = "lbXinchao";
            this.lbXinchao.Size = new System.Drawing.Size(58, 13);
            this.lbXinchao.TabIndex = 5;
            this.lbXinchao.Text = "Xin chào :)";
            this.lbXinchao.Visible = false;
            this.lbXinchao.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(523, 334);
            this.Controls.Add(this.lbXinchao);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.tbLop);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.lbHoten);
            this.Controls.Add(this.btXinchao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xin chào :)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXinchao;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbXinchao;
    }
}

