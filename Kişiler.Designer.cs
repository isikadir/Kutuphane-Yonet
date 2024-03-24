namespace Kütüphane_Yönet
{
    partial class Kişiler
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
            kısıekle = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            kisiismi = new DataGridViewTextBoxColumn();
            kisisoyismi = new DataGridViewTextBoxColumn();
            kisinumarası = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kısıekle
            // 
            kısıekle.Location = new Point(309, 297);
            kısıekle.Name = "kısıekle";
            kısıekle.Size = new Size(94, 29);
            kısıekle.TabIndex = 0;
            kısıekle.Text = "KisiEkle";
            kısıekle.UseVisualStyleBackColor = true;
            kısıekle.Click += kısıekle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(309, 250);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "KisiSil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(309, 357);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Guncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kisiismi, kisisoyismi, kisinumarası });
            dataGridView1.Location = new Point(309, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 231);
            dataGridView1.TabIndex = 3;
            // 
            // kisiismi
            // 
            kisiismi.HeaderText = "Kisi İsmi";
            kisiismi.MinimumWidth = 6;
            kisiismi.Name = "kisiismi";
            kisiismi.Width = 125;
            // 
            // kisisoyismi
            // 
            kisisoyismi.HeaderText = "Kisi Soyismi";
            kisisoyismi.MinimumWidth = 6;
            kisisoyismi.Name = "kisisoyismi";
            kisisoyismi.Width = 125;
            // 
            // kisinumarası
            // 
            kisinumarası.HeaderText = "Kisi Numarası";
            kisinumarası.MinimumWidth = 6;
            kisinumarası.Name = "kisinumarası";
            kisinumarası.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Kişi İsmi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Kişi Soyismi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "Kişi Numarası";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // Kişiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(kısıekle);
            Name = "Kişiler";
            Text = "Kişiler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kısıekle;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kisiismi;
        private DataGridViewTextBoxColumn kisisoyismi;
        private DataGridViewTextBoxColumn kisinumarası;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}