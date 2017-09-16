namespace kursovoy_luc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1l = new System.Windows.Forms.TextBox();
            this.textBox2l = new System.Windows.Forms.TextBox();
            this.textBox3l = new System.Windows.Forms.TextBox();
            this.textBox4l = new System.Windows.Forms.TextBox();
            this.textBox5l = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(228, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 240);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox1l
            // 
            this.textBox1l.Location = new System.Drawing.Point(501, 231);
            this.textBox1l.Name = "textBox1l";
            this.textBox1l.Size = new System.Drawing.Size(49, 20);
            this.textBox1l.TabIndex = 5;
            // 
            // textBox2l
            // 
            this.textBox2l.Location = new System.Drawing.Point(501, 195);
            this.textBox2l.Name = "textBox2l";
            this.textBox2l.Size = new System.Drawing.Size(49, 20);
            this.textBox2l.TabIndex = 6;
            // 
            // textBox3l
            // 
            this.textBox3l.Location = new System.Drawing.Point(501, 148);
            this.textBox3l.Name = "textBox3l";
            this.textBox3l.Size = new System.Drawing.Size(49, 20);
            this.textBox3l.TabIndex = 7;
            // 
            // textBox4l
            // 
            this.textBox4l.Location = new System.Drawing.Point(501, 106);
            this.textBox4l.Name = "textBox4l";
            this.textBox4l.Size = new System.Drawing.Size(49, 20);
            this.textBox4l.TabIndex = 8;
            // 
            // textBox5l
            // 
            this.textBox5l.Location = new System.Drawing.Point(501, 65);
            this.textBox5l.Name = "textBox5l";
            this.textBox5l.Size = new System.Drawing.Size(49, 20);
            this.textBox5l.TabIndex = 9;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(12, 65);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 10;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 103);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "начать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 472);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox5l);
            this.Controls.Add(this.textBox4l);
            this.Controls.Add(this.textBox3l);
            this.Controls.Add(this.textBox2l);
            this.Controls.Add(this.textBox1l);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1l;
        private System.Windows.Forms.TextBox textBox2l;
        private System.Windows.Forms.TextBox textBox3l;
        private System.Windows.Forms.TextBox textBox4l;
        private System.Windows.Forms.TextBox textBox5l;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
    }
}

