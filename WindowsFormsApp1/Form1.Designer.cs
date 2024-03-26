
namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btThem);
            this.tabPage1.Controls.Add(this.bt5);
            this.tabPage1.Controls.Add(this.bt4);
            this.tabPage1.Controls.Add(this.bt6);
            this.tabPage1.Controls.Add(this.bt3);
            this.tabPage1.Controls.Add(this.bt7);
            this.tabPage1.Controls.Add(this.bt2);
            this.tabPage1.Controls.Add(this.bt8);
            this.tabPage1.Controls.Add(this.bt1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bán vé";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.textBox2_Changed);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên khách";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(395, 29);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(92, 75);
            this.btThem.TabIndex = 46;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.button7_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(283, 188);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(45, 38);
            this.bt5.TabIndex = 38;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.button7_Click);
            this.bt5.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(334, 188);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(45, 38);
            this.bt4.TabIndex = 37;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button7_Click);
            this.bt4.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(283, 144);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(45, 38);
            this.bt6.TabIndex = 28;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.button7_Click);
            this.bt6.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(334, 144);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(45, 38);
            this.bt3.TabIndex = 27;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button7_Click);
            this.bt3.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(283, 71);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(45, 38);
            this.bt7.TabIndex = 18;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.button7_Click);
            this.bt7.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(334, 71);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(45, 38);
            this.bt2.TabIndex = 17;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button7_Click);
            this.bt2.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(283, 27);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(45, 38);
            this.bt8.TabIndex = 8;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.button7_Click);
            this.bt8.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(334, 27);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(45, 38);
            this.bt1.TabIndex = 7;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button7_Click);
            this.bt1.Leave += new System.EventHandler(this.Form1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn vị trí ngồi:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3,
            this.cl4});
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(593, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // cl1
            // 
            this.cl1.HeaderText = "Vị trí ngồi";
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            // 
            // cl2
            // 
            this.cl2.HeaderText = "Tên khách";
            this.cl2.Name = "cl2";
            this.cl2.ReadOnly = true;
            // 
            // cl3
            // 
            this.cl3.HeaderText = "Tuổi";
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            // 
            // cl4
            // 
            this.cl4.HeaderText = "Thành tiền";
            this.cl4.Name = "cl4";
            this.cl4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng (Bùi Tiến Đạt - 2051063915)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

