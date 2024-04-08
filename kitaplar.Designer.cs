namespace Kütüphane_Yönet
{
    partial class kitaplar
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
            dataGridView1 = new DataGridView();
            ekle = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 403);
            dataGridView1.TabIndex = 0;
            // 
            // ekle
            // 
            ekle.Location = new Point(2, 254);
            ekle.Name = "ekle";
            ekle.Size = new Size(75, 23);
            ekle.TabIndex = 1;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(83, 254);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "silme";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(164, 254);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Yazar İsmi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 57);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 27);
            textBox5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 9;
            label3.Text = "Sayfa Sayısı";
            // 
            // kitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ekle);
            Controls.Add(dataGridView1);
            Name = "kitaplar";
            Text = "kitaplar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
