namespace Bai3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnComGaTender = new System.Windows.Forms.Button();
            this.btnGaRanPhan = new System.Windows.Forms.Button();
            this.btnGaVienCola = new System.Windows.Forms.Button();
            this.btnTomVienCola = new System.Windows.Forms.Button();
            this.btnPMCa = new System.Windows.Forms.Button();
            this.btnPMTom = new System.Windows.Forms.Button();
            this.btnPMGa = new System.Windows.Forms.Button();
            this.btnPMBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(130, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhoaiTayChien);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btn7Up);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnComGaTender);
            this.groupBox1.Controls.Add(this.btnGaRanPhan);
            this.groupBox1.Controls.Add(this.btnGaVienCola);
            this.groupBox1.Controls.Add(this.btnTomVienCola);
            this.groupBox1.Controls.Add(this.btnPMCa);
            this.groupBox1.Controls.Add(this.btnPMTom);
            this.groupBox1.Controls.Add(this.btnPMGa);
            this.groupBox1.Controls.Add(this.btnPMBo);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 140);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoaiTayChien.ForeColor = System.Drawing.Color.Green;
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(229, 106);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(122, 23);
            this.btnKhoaiTayChien.TabIndex = 34;
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            this.btnKhoaiTayChien.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(293, 77);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(58, 23);
            this.btnCam.TabIndex = 33;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(293, 48);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(58, 23);
            this.btnLipton.TabIndex = 32;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(293, 19);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(58, 23);
            this.btnCoca.TabIndex = 31;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(229, 77);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(58, 23);
            this.btnCafe.TabIndex = 30;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7Up
            // 
            this.btn7Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Up.ForeColor = System.Drawing.Color.Red;
            this.btn7Up.Location = new System.Drawing.Point(229, 48);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(58, 23);
            this.btn7Up.TabIndex = 29;
            this.btn7Up.Text = "7-Up";
            this.btn7Up.UseVisualStyleBackColor = true;
            this.btn7Up.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(229, 19);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(58, 23);
            this.btnPepsi.TabIndex = 28;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnComGaTender
            // 
            this.btnComGaTender.ForeColor = System.Drawing.Color.Blue;
            this.btnComGaTender.Location = new System.Drawing.Point(125, 106);
            this.btnComGaTender.Name = "btnComGaTender";
            this.btnComGaTender.Size = new System.Drawing.Size(98, 23);
            this.btnComGaTender.TabIndex = 27;
            this.btnComGaTender.Text = "Cơm gà Tender";
            this.btnComGaTender.UseVisualStyleBackColor = true;
            this.btnComGaTender.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGaRanPhan
            // 
            this.btnGaRanPhan.ForeColor = System.Drawing.Color.Blue;
            this.btnGaRanPhan.Location = new System.Drawing.Point(124, 77);
            this.btnGaRanPhan.Name = "btnGaRanPhan";
            this.btnGaRanPhan.Size = new System.Drawing.Size(99, 23);
            this.btnGaRanPhan.TabIndex = 26;
            this.btnGaRanPhan.Text = "Gà rán phần";
            this.btnGaRanPhan.UseVisualStyleBackColor = true;
            this.btnGaRanPhan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGaVienCola
            // 
            this.btnGaVienCola.ForeColor = System.Drawing.Color.Blue;
            this.btnGaVienCola.Location = new System.Drawing.Point(125, 48);
            this.btnGaVienCola.Name = "btnGaVienCola";
            this.btnGaVienCola.Size = new System.Drawing.Size(98, 23);
            this.btnGaVienCola.TabIndex = 25;
            this.btnGaVienCola.Text = "Gà viên Cola";
            this.btnGaVienCola.UseVisualStyleBackColor = true;
            this.btnGaVienCola.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTomVienCola
            // 
            this.btnTomVienCola.ForeColor = System.Drawing.Color.Blue;
            this.btnTomVienCola.Location = new System.Drawing.Point(125, 19);
            this.btnTomVienCola.Name = "btnTomVienCola";
            this.btnTomVienCola.Size = new System.Drawing.Size(98, 23);
            this.btnTomVienCola.TabIndex = 24;
            this.btnTomVienCola.Text = "Tôm viên Cola";
            this.btnTomVienCola.UseVisualStyleBackColor = true;
            this.btnTomVienCola.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPMCa
            // 
            this.btnPMCa.ForeColor = System.Drawing.Color.Red;
            this.btnPMCa.Location = new System.Drawing.Point(6, 106);
            this.btnPMCa.Name = "btnPMCa";
            this.btnPMCa.Size = new System.Drawing.Size(112, 23);
            this.btnPMCa.TabIndex = 23;
            this.btnPMCa.Text = "Burger Phô mai Cá";
            this.btnPMCa.UseVisualStyleBackColor = true;
            this.btnPMCa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPMTom
            // 
            this.btnPMTom.ForeColor = System.Drawing.Color.Red;
            this.btnPMTom.Location = new System.Drawing.Point(6, 77);
            this.btnPMTom.Name = "btnPMTom";
            this.btnPMTom.Size = new System.Drawing.Size(112, 23);
            this.btnPMTom.TabIndex = 22;
            this.btnPMTom.Text = "Burger Phô mai Tôm";
            this.btnPMTom.UseVisualStyleBackColor = true;
            this.btnPMTom.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPMGa
            // 
            this.btnPMGa.ForeColor = System.Drawing.Color.Red;
            this.btnPMGa.Location = new System.Drawing.Point(6, 48);
            this.btnPMGa.Name = "btnPMGa";
            this.btnPMGa.Size = new System.Drawing.Size(112, 23);
            this.btnPMGa.TabIndex = 21;
            this.btnPMGa.Text = "Burger Phô mai Gà";
            this.btnPMGa.UseVisualStyleBackColor = true;
            this.btnPMGa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPMBo
            // 
            this.btnPMBo.ForeColor = System.Drawing.Color.Red;
            this.btnPMBo.Location = new System.Drawing.Point(6, 19);
            this.btnPMBo.Name = "btnPMBo";
            this.btnPMBo.Size = new System.Drawing.Size(112, 23);
            this.btnPMBo.TabIndex = 20;
            this.btnPMBo.Text = "Burger Phô mai Bò";
            this.btnPMBo.UseVisualStyleBackColor = true;
            this.btnPMBo.ClientSizeChanged += new System.EventHandler(this.btn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(18, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên bàn";
            // 
            // cbBoxBan
            // 
            this.cbBoxBan.FormattingEnabled = true;
            this.cbBoxBan.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4"});
            this.cbBoxBan.Location = new System.Drawing.Point(148, 225);
            this.cbBoxBan.Name = "cbBoxBan";
            this.cbBoxBan.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBan.TabIndex = 22;
            this.cbBoxBan.SelectedIndexChanged += new System.EventHandler(this.cbBoxBan_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(294, 223);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 267);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(351, 202);
            this.dataGridView.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 481);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbBoxBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "E-Order Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnComGaTender;
        private System.Windows.Forms.Button btnGaRanPhan;
        private System.Windows.Forms.Button btnGaVienCola;
        private System.Windows.Forms.Button btnTomVienCola;
        private System.Windows.Forms.Button btnPMCa;
        private System.Windows.Forms.Button btnPMTom;
        private System.Windows.Forms.Button btnPMGa;
        private System.Windows.Forms.Button btnPMBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

