namespace recite
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.vocabulary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Second);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Minute);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Hour);
            this.panel1.Controls.Add(this.Chinese);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.vocabulary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 414);
            this.panel1.TabIndex = 0;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(147, 21);
            this.Second.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(26, 18);
            this.Second.TabIndex = 15;
            this.Second.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Location = new System.Drawing.Point(87, 21);
            this.Minute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(26, 18);
            this.Minute.TabIndex = 13;
            this.Minute.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(27, 21);
            this.Hour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(26, 18);
            this.Hour.TabIndex = 11;
            this.Hour.Text = "00";
            // 
            // Chinese
            // 
            this.Chinese.AutoSize = true;
            this.Chinese.Location = new System.Drawing.Point(69, 264);
            this.Chinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(0, 18);
            this.Chinese.TabIndex = 10;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(520, 13);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 34);
            this.start.TabIndex = 6;
            this.start.Text = "Start!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(537, 340);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 34);
            this.next.TabIndex = 5;
            this.next.Text = "下一个";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // vocabulary
            // 
            this.vocabulary.Location = new System.Drawing.Point(424, 183);
            this.vocabulary.Margin = new System.Windows.Forms.Padding(4);
            this.vocabulary.Name = "vocabulary";
            this.vocabulary.Size = new System.Drawing.Size(199, 28);
            this.vocabulary.TabIndex = 3;
            this.vocabulary.TextChanged += new System.EventHandler(this.vocabulary_TextChanged);
            this.vocabulary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vocabulary_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(90, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入以下中文对应的英文单词：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox vocabulary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Chinese;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Timer timer1;
    }
}

