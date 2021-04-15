namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel_tree = new System.Windows.Forms.Panel();
            this.comboBox_rightAngle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_leftAngle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_rightLeng = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_depth = new System.Windows.Forms.ComboBox();
            this.comboBox_leftLeng = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_leng = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_pensize = new System.Windows.Forms.Panel();
            this.radioButton_large = new System.Windows.Forms.RadioButton();
            this.radioButton_middle = new System.Windows.Forms.RadioButton();
            this.radioButton_small = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_tree.SuspendLayout();
            this.panel_pensize.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(755, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_tree
            // 
            this.panel_tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tree.Controls.Add(this.comboBox_rightAngle);
            this.panel_tree.Controls.Add(this.label8);
            this.panel_tree.Controls.Add(this.comboBox_leftAngle);
            this.panel_tree.Controls.Add(this.label7);
            this.panel_tree.Controls.Add(this.comboBox_rightLeng);
            this.panel_tree.Controls.Add(this.label6);
            this.panel_tree.Controls.Add(this.comboBox_depth);
            this.panel_tree.Controls.Add(this.comboBox_leftLeng);
            this.panel_tree.Controls.Add(this.label4);
            this.panel_tree.Controls.Add(this.comboBox_leng);
            this.panel_tree.Controls.Add(this.label3);
            this.panel_tree.Controls.Add(this.label1);
            this.panel_tree.Location = new System.Drawing.Point(617, 40);
            this.panel_tree.Name = "panel_tree";
            this.panel_tree.Size = new System.Drawing.Size(267, 231);
            this.panel_tree.TabIndex = 1;
            // 
            // comboBox_rightAngle
            // 
            this.comboBox_rightAngle.FormattingEnabled = true;
            this.comboBox_rightAngle.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.comboBox_rightAngle.Location = new System.Drawing.Point(137, 200);
            this.comboBox_rightAngle.Name = "comboBox_rightAngle";
            this.comboBox_rightAngle.Size = new System.Drawing.Size(121, 26);
            this.comboBox_rightAngle.TabIndex = 13;
            this.comboBox_rightAngle.Text = "30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "右分支角度";
            // 
            // comboBox_leftAngle
            // 
            this.comboBox_leftAngle.FormattingEnabled = true;
            this.comboBox_leftAngle.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.comboBox_leftAngle.Location = new System.Drawing.Point(137, 160);
            this.comboBox_leftAngle.Name = "comboBox_leftAngle";
            this.comboBox_leftAngle.Size = new System.Drawing.Size(121, 26);
            this.comboBox_leftAngle.TabIndex = 11;
            this.comboBox_leftAngle.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "左分支角度";
            // 
            // comboBox_rightLeng
            // 
            this.comboBox_rightLeng.FormattingEnabled = true;
            this.comboBox_rightLeng.Items.AddRange(new object[] {
            "0.50",
            "0.60",
            "0.70",
            "0.80",
            "0.90"});
            this.comboBox_rightLeng.Location = new System.Drawing.Point(137, 120);
            this.comboBox_rightLeng.Name = "comboBox_rightLeng";
            this.comboBox_rightLeng.Size = new System.Drawing.Size(121, 26);
            this.comboBox_rightLeng.TabIndex = 9;
            this.comboBox_rightLeng.Text = "0.70";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "右分支长度比";
            // 
            // comboBox_depth
            // 
            this.comboBox_depth.FormattingEnabled = true;
            this.comboBox_depth.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_depth.Location = new System.Drawing.Point(137, 0);
            this.comboBox_depth.Name = "comboBox_depth";
            this.comboBox_depth.Size = new System.Drawing.Size(121, 26);
            this.comboBox_depth.TabIndex = 7;
            this.comboBox_depth.Text = "10";
            // 
            // comboBox_leftLeng
            // 
            this.comboBox_leftLeng.FormattingEnabled = true;
            this.comboBox_leftLeng.Items.AddRange(new object[] {
            "0.50",
            "0.60",
            "0.70",
            "0.80",
            "0.90"});
            this.comboBox_leftLeng.Location = new System.Drawing.Point(137, 80);
            this.comboBox_leftLeng.Name = "comboBox_leftLeng";
            this.comboBox_leftLeng.Size = new System.Drawing.Size(121, 26);
            this.comboBox_leftLeng.TabIndex = 5;
            this.comboBox_leftLeng.Text = "0.60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "左分支长度比";
            // 
            // comboBox_leng
            // 
            this.comboBox_leng.FormattingEnabled = true;
            this.comboBox_leng.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBox_leng.Location = new System.Drawing.Point(137, 40);
            this.comboBox_leng.Name = "comboBox_leng";
            this.comboBox_leng.Size = new System.Drawing.Size(121, 26);
            this.comboBox_leng.TabIndex = 3;
            this.comboBox_leng.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "主干长度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cayleys树参数";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "画笔颜色";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "画笔粗细";
            // 
            // panel_pensize
            // 
            this.panel_pensize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_pensize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pensize.Controls.Add(this.radioButton_large);
            this.panel_pensize.Controls.Add(this.radioButton_middle);
            this.panel_pensize.Controls.Add(this.radioButton_small);
            this.panel_pensize.Location = new System.Drawing.Point(755, 315);
            this.panel_pensize.Name = "panel_pensize";
            this.panel_pensize.Size = new System.Drawing.Size(129, 100);
            this.panel_pensize.TabIndex = 6;
            // 
            // radioButton_large
            // 
            this.radioButton_large.AutoSize = true;
            this.radioButton_large.Location = new System.Drawing.Point(15, 56);
            this.radioButton_large.Name = "radioButton_large";
            this.radioButton_large.Size = new System.Drawing.Size(78, 22);
            this.radioButton_large.TabIndex = 2;
            this.radioButton_large.Text = "large";
            this.radioButton_large.UseVisualStyleBackColor = true;
            this.radioButton_large.CheckedChanged += new System.EventHandler(this.radioButton_large_CheckedChanged);
            // 
            // radioButton_middle
            // 
            this.radioButton_middle.AutoSize = true;
            this.radioButton_middle.Location = new System.Drawing.Point(15, 30);
            this.radioButton_middle.Name = "radioButton_middle";
            this.radioButton_middle.Size = new System.Drawing.Size(87, 22);
            this.radioButton_middle.TabIndex = 1;
            this.radioButton_middle.Text = "middle";
            this.radioButton_middle.UseVisualStyleBackColor = true;
            this.radioButton_middle.CheckedChanged += new System.EventHandler(this.radioButton_middle_CheckedChanged);
            // 
            // radioButton_small
            // 
            this.radioButton_small.AutoSize = true;
            this.radioButton_small.Checked = true;
            this.radioButton_small.Location = new System.Drawing.Point(15, 4);
            this.radioButton_small.Name = "radioButton_small";
            this.radioButton_small.Size = new System.Drawing.Size(78, 22);
            this.radioButton_small.TabIndex = 0;
            this.radioButton_small.TabStop = true;
            this.radioButton_small.Text = "small";
            this.radioButton_small.UseVisualStyleBackColor = true;
            this.radioButton_small.CheckedChanged += new System.EventHandler(this.radioButton_small_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(617, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(617, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 64);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(896, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel_pensize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_tree);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_tree.ResumeLayout(false);
            this.panel_tree.PerformLayout();
            this.panel_pensize.ResumeLayout(false);
            this.panel_pensize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_rightAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_leftAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_rightLeng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_depth;
        private System.Windows.Forms.ComboBox comboBox_leftLeng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_leng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_pensize;
        private System.Windows.Forms.RadioButton radioButton_large;
        private System.Windows.Forms.RadioButton radioButton_middle;
        private System.Windows.Forms.RadioButton radioButton_small;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

