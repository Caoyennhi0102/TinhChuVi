namespace TinhChuVi
{
    partial class Form1
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
            txtRong = new Label();
            txtdai = new Label();
            txtKetQua = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btTinh = new Button();
            btdientich = new Button();
            btchuvi = new Button();
            btThoat = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // txtRong
            // 
            txtRong.AutoSize = true;
            txtRong.Location = new Point(97, 44);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(175, 40);
            txtRong.TabIndex = 0;
            txtRong.Text = "Chiều Rộng";
            // 
            // txtdai
            // 
            txtdai.AutoSize = true;
            txtdai.Location = new Point(97, 102);
            txtdai.Name = "txtdai";
            txtdai.Size = new Size(147, 40);
            txtdai.TabIndex = 1;
            txtdai.Text = "Chiều Dài";
            // 
            // txtKetQua
            // 
            txtKetQua.AutoSize = true;
            txtKetQua.Location = new Point(108, 165);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(127, 40);
            txtKetQua.TabIndex = 2;
            txtKetQua.Text = "Kết Quả";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 46);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 46);
            textBox2.TabIndex = 4;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(64, 245);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(124, 62);
            btTinh.TabIndex = 6;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // btdientich
            // 
            btdientich.Location = new Point(50, 353);
            btdientich.Name = "btdientich";
            btdientich.Size = new Size(185, 70);
            btdientich.TabIndex = 7;
            btdientich.Text = "Diện Tích ";
            btdientich.UseVisualStyleBackColor = true;
            // 
            // btchuvi
            // 
            btchuvi.Location = new Point(299, 362);
            btchuvi.Name = "btchuvi";
            btchuvi.Size = new Size(171, 52);
            btchuvi.TabIndex = 8;
            btchuvi.Text = "Chu Vi ";
            btchuvi.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(583, 362);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(149, 56);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(287, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(522, 46);
            textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 881);
            Controls.Add(textBox3);
            Controls.Add(btThoat);
            Controls.Add(btchuvi);
            Controls.Add(btdientich);
            Controls.Add(btTinh);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtKetQua);
            Controls.Add(txtdai);
            Controls.Add(txtRong);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRong;
        private Label txtdai;
        private Label txtKetQua;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btTinh;
        private Button btdientich;
        private Button btchuvi;
        private Button btThoat;
        private TextBox textBox3;
    }
}
