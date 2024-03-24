using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Yönet
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private Button ekle;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn kitapadı;
        private DataGridViewTextBoxColumn sayfasayısı;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn yazarismi;

        private void InitializeComponent()
        {
            ekle = new Button();
            dataGridView1 = new DataGridView();
            yazarismi = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            kitapadı = new DataGridViewTextBoxColumn();
            sayfasayısı = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ekle
            // 
            ekle.Location = new Point(440, 261);
            ekle.Name = "ekle";
            ekle.Size = new Size(94, 29);
            ekle.TabIndex = 0;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += this.ekle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { yazarismi, kitapadı, sayfasayısı });
            dataGridView1.Location = new Point(440, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(426, 227);
            dataGridView1.TabIndex = 1;
            // 
            // yazarismi
            // 
            yazarismi.HeaderText = "Yazar İsmi";
            yazarismi.MinimumWidth = 6;
            yazarismi.Name = "yazarismi";
            yazarismi.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(440, 335);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(440, 405);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // kitapadı
            // 
            kitapadı.HeaderText = "Kitap Adı";
            kitapadı.MinimumWidth = 6;
            kitapadı.Name = "kitapadı";
            kitapadı.Width = 125;
            // 
            // sayfasayısı
            // 
            sayfasayısı.HeaderText = "Sayfa Sayısı";
            sayfasayısı.MinimumWidth = 6;
            sayfasayısı.Name = "sayfasayısı";
            sayfasayısı.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Yazar İsmi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Kitap İsmi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "Sayfa Sayısı";
            // 
            // Kitaplar
            // 
            ClientSize = new Size(866, 638);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(ekle);
            Name = "Kitaplar";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
