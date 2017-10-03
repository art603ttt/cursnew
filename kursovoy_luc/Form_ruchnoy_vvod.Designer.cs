namespace kursovoy_luc
{
    partial class Form_ruchnoy_vvod
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
            this.textBox_kolvo_etajey = new System.Windows.Forms.TextBox();
            this.groupBox_FLOOR = new System.Windows.Forms.GroupBox();
            this.textBox_count_people = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.textBox_skorost_lifta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_skorostb_chelika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_skorostb_posadki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ready = new System.Windows.Forms.Button();
            this.groupBox_FLOOR.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество этажей:";
            // 
            // textBox_kolvo_etajey
            // 
            this.textBox_kolvo_etajey.Location = new System.Drawing.Point(145, 23);
            this.textBox_kolvo_etajey.Name = "textBox_kolvo_etajey";
            this.textBox_kolvo_etajey.Size = new System.Drawing.Size(100, 20);
            this.textBox_kolvo_etajey.TabIndex = 1;
            // 
            // groupBox_FLOOR
            // 
            this.groupBox_FLOOR.Controls.Add(this.button_next);
            this.groupBox_FLOOR.Controls.Add(this.textBox_tog);
            this.groupBox_FLOOR.Controls.Add(this.label3);
            this.groupBox_FLOOR.Controls.Add(this.textBox_count_people);
            this.groupBox_FLOOR.Controls.Add(this.label2);
            this.groupBox_FLOOR.Location = new System.Drawing.Point(12, 61);
            this.groupBox_FLOOR.Name = "groupBox_FLOOR";
            this.groupBox_FLOOR.Size = new System.Drawing.Size(279, 129);
            this.groupBox_FLOOR.TabIndex = 2;
            this.groupBox_FLOOR.TabStop = false;
            this.groupBox_FLOOR.Text = "КХМ-КХМ этаж из КЕКЕ";
            // 
            // textBox_count_people
            // 
            this.textBox_count_people.Location = new System.Drawing.Point(133, 26);
            this.textBox_count_people.Name = "textBox_count_people";
            this.textBox_count_people.Size = new System.Drawing.Size(100, 20);
            this.textBox_count_people.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество жильцов:";
            // 
            // textBox_tog
            // 
            this.textBox_tog.Location = new System.Drawing.Point(133, 59);
            this.textBox_tog.Name = "textBox_tog";
            this.textBox_tog.Size = new System.Drawing.Size(100, 20);
            this.textBox_tog.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Макс время ожидания:";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(78, 85);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Дальше";
            this.button_next.UseVisualStyleBackColor = true;
            // 
            // textBox_skorost_lifta
            // 
            this.textBox_skorost_lifta.Location = new System.Drawing.Point(174, 219);
            this.textBox_skorost_lifta.Name = "textBox_skorost_lifta";
            this.textBox_skorost_lifta.Size = new System.Drawing.Size(100, 20);
            this.textBox_skorost_lifta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время передвижения лифта:";
            // 
            // textBox_skorostb_chelika
            // 
            this.textBox_skorostb_chelika.Location = new System.Drawing.Point(174, 251);
            this.textBox_skorostb_chelika.Name = "textBox_skorostb_chelika";
            this.textBox_skorostb_chelika.Size = new System.Drawing.Size(100, 20);
            this.textBox_skorostb_chelika.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Сред. время прихода к лифту:";
            // 
            // textBox_skorostb_posadki
            // 
            this.textBox_skorostb_posadki.Location = new System.Drawing.Point(174, 282);
            this.textBox_skorostb_posadki.Name = "textBox_skorostb_posadki";
            this.textBox_skorostb_posadki.Size = new System.Drawing.Size(100, 20);
            this.textBox_skorostb_posadki.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Среднее время посадки:";
            // 
            // button_ready
            // 
            this.button_ready.Location = new System.Drawing.Point(90, 327);
            this.button_ready.Name = "button_ready";
            this.button_ready.Size = new System.Drawing.Size(75, 23);
            this.button_ready.TabIndex = 9;
            this.button_ready.Text = "Готово!";
            this.button_ready.UseVisualStyleBackColor = true;
            // 
            // Form_ruchnoy_vvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 372);
            this.Controls.Add(this.button_ready);
            this.Controls.Add(this.textBox_skorostb_posadki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_skorostb_chelika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_skorost_lifta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox_FLOOR);
            this.Controls.Add(this.textBox_kolvo_etajey);
            this.Controls.Add(this.label1);
            this.Name = "Form_ruchnoy_vvod";
            this.Text = "Ручной ввод";
            this.Load += new System.EventHandler(this.Form_ruchnoy_vvod_Load);
            this.groupBox_FLOOR.ResumeLayout(false);
            this.groupBox_FLOOR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kolvo_etajey;
        private System.Windows.Forms.GroupBox groupBox_FLOOR;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.TextBox textBox_tog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_count_people;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_skorost_lifta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_skorostb_chelika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_skorostb_posadki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ready;
    }
}