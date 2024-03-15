namespace password_creator
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
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.coppy_bt = new System.Windows.Forms.Button();
            this.create_pass_bt = new System.Windows.Forms.Button();
            this.ktdacbiet_cb = new System.Windows.Forms.CheckBox();
            this.socb = new System.Windows.Forms.CheckBox();
            this.chuthuongcb = new System.Windows.Forms.CheckBox();
            this.chuhoa_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.hidepass = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass_tb.ForeColor = System.Drawing.Color.Red;
            this.pass_tb.Location = new System.Drawing.Point(12, 277);
            this.pass_tb.Multiline = true;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(623, 44);
            this.pass_tb.TabIndex = 0;
            this.pass_tb.Text = "Mật khẩu chưa được tạo ...";
            this.pass_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(227, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu của bạn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hidepass);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.coppy_bt);
            this.groupBox1.Controls.Add(this.create_pass_bt);
            this.groupBox1.Controls.Add(this.ktdacbiet_cb);
            this.groupBox1.Controls.Add(this.socb);
            this.groupBox1.Controls.Add(this.chuthuongcb);
            this.groupBox1.Controls.Add(this.chuhoa_cb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chỉnh";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.Location = new System.Drawing.Point(237, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 26);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // coppy_bt
            // 
            this.coppy_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.coppy_bt.Location = new System.Drawing.Point(388, 102);
            this.coppy_bt.Name = "coppy_bt";
            this.coppy_bt.Size = new System.Drawing.Size(217, 73);
            this.coppy_bt.TabIndex = 2;
            this.coppy_bt.Text = "Coppy ";
            this.coppy_bt.UseVisualStyleBackColor = true;
            this.coppy_bt.Click += new System.EventHandler(this.coppy_bt_Click);
            // 
            // create_pass_bt
            // 
            this.create_pass_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.create_pass_bt.Location = new System.Drawing.Point(388, 19);
            this.create_pass_bt.Name = "create_pass_bt";
            this.create_pass_bt.Size = new System.Drawing.Size(217, 73);
            this.create_pass_bt.TabIndex = 2;
            this.create_pass_bt.Text = "Tạo mật khẩu";
            this.create_pass_bt.UseVisualStyleBackColor = true;
            this.create_pass_bt.Click += new System.EventHandler(this.create_pass_bt_Click);
            // 
            // ktdacbiet_cb
            // 
            this.ktdacbiet_cb.AutoSize = true;
            this.ktdacbiet_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ktdacbiet_cb.Location = new System.Drawing.Point(42, 151);
            this.ktdacbiet_cb.Name = "ktdacbiet_cb";
            this.ktdacbiet_cb.Size = new System.Drawing.Size(195, 24);
            this.ktdacbiet_cb.TabIndex = 1;
            this.ktdacbiet_cb.Text = "Ký tự đặc biệt (@, +_ ...)";
            this.ktdacbiet_cb.UseVisualStyleBackColor = true;
            this.ktdacbiet_cb.CheckedChanged += new System.EventHandler(this.chuhoa_cb_CheckedChanged);
            // 
            // socb
            // 
            this.socb.AutoSize = true;
            this.socb.Checked = true;
            this.socb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.socb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.socb.Location = new System.Drawing.Point(42, 121);
            this.socb.Name = "socb";
            this.socb.Size = new System.Drawing.Size(85, 24);
            this.socb.TabIndex = 1;
            this.socb.Text = "Số (0-9)";
            this.socb.UseVisualStyleBackColor = true;
            this.socb.CheckedChanged += new System.EventHandler(this.chuhoa_cb_CheckedChanged);
            // 
            // chuthuongcb
            // 
            this.chuthuongcb.AutoSize = true;
            this.chuthuongcb.Checked = true;
            this.chuthuongcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chuthuongcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chuthuongcb.Location = new System.Drawing.Point(42, 91);
            this.chuthuongcb.Name = "chuthuongcb";
            this.chuthuongcb.Size = new System.Drawing.Size(163, 24);
            this.chuthuongcb.TabIndex = 1;
            this.chuthuongcb.Text = "Chữ in thường (a-z)";
            this.chuthuongcb.UseVisualStyleBackColor = true;
            this.chuthuongcb.CheckedChanged += new System.EventHandler(this.chuhoa_cb_CheckedChanged);
            // 
            // chuhoa_cb
            // 
            this.chuhoa_cb.AutoSize = true;
            this.chuhoa_cb.Checked = true;
            this.chuhoa_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chuhoa_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chuhoa_cb.Location = new System.Drawing.Point(42, 61);
            this.chuhoa_cb.Name = "chuhoa_cb";
            this.chuhoa_cb.Size = new System.Drawing.Size(144, 24);
            this.chuhoa_cb.TabIndex = 1;
            this.chuhoa_cb.Text = "Chữ in hoa (A-Z)";
            this.chuhoa_cb.UseVisualStyleBackColor = true;
            this.chuhoa_cb.CheckedChanged += new System.EventHandler(this.chuhoa_cb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(233, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Độ dài:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thành phần mật khẩu:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(461, 326);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@YangKlee 2024 BETAv1.0";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // hidepass
            // 
            this.hidepass.AutoSize = true;
            this.hidepass.Location = new System.Drawing.Point(237, 102);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(135, 17);
            this.hidepass.TabIndex = 4;
            this.hidepass.Text = "Hide pass when create";
            this.hidepass.UseVisualStyleBackColor = true;
            this.hidepass.CheckedChanged += new System.EventHandler(this.hidepass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 351);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_tb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Trình tạo mật khẩu mạnh [BETA]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chuhoa_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ktdacbiet_cb;
        private System.Windows.Forms.CheckBox socb;
        private System.Windows.Forms.CheckBox chuthuongcb;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button coppy_bt;
        private System.Windows.Forms.Button create_pass_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox hidepass;
    }
}

