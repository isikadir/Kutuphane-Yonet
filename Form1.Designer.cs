namespace Kütüphane_Yönet
{
    partial class Yonetim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            kisi = new DataGridViewTextBoxColumn();
            kitap = new DataGridViewTextBoxColumn();
            alimTarihi = new DataGridViewTextBoxColumn();
            iadeTarihi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 103);
            button1.Name = "button1";
            button1.Size = new Size(175, 66);
            button1.TabIndex = 0;
            button1.Text = "Kişiler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 214);
            button2.Name = "button2";
            button2.Size = new Size(175, 66);
            button2.TabIndex = 1;
            button2.Text = "Kitaplar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(39, 323);
            button3.Name = "button3";
            button3.Size = new Size(175, 66);
            button3.TabIndex = 2;
            button3.Text = "Emanetler";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kisi, kitap, alimTarihi, iadeTarihi });
            dataGridView1.Location = new Point(233, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 508);
            dataGridView1.TabIndex = 3;
            // 
            // kisi
            // 
            kisi.HeaderText = "KİSİLER";
            kisi.MinimumWidth = 6;
            kisi.Name = "kisi";
            kisi.Width = 125;
            // 
            // kitap
            // 
            kitap.HeaderText = "KİTAPLAR";
            kitap.MinimumWidth = 6;
            kitap.Name = "kitap";
            kitap.Width = 125;
            // 
            // alimTarihi
            // 
            alimTarihi.HeaderText = "ALİM TARİHİ";
            alimTarihi.MinimumWidth = 6;
            alimTarihi.Name = "alimTarihi";
            alimTarihi.Width = 125;
            // 
            // iadeTarihi
            // 
            iadeTarihi.HeaderText = "İADE TARİHİ";
            iadeTarihi.MinimumWidth = 6;
            iadeTarihi.Name = "iadeTarihi";
            iadeTarihi.Width = 125;
            // 
            // Yonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Yonetim";
            Text = "Kutuphane Yonetım";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kisi;
        private DataGridViewTextBoxColumn kitap;
        private DataGridViewTextBoxColumn alimTarihi;
        private DataGridViewTextBoxColumn iadeTarihi;
    }
}
