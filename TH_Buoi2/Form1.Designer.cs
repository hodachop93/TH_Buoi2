namespace TH_Buoi2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblXRay = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(118, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.Location = new System.Drawing.Point(145, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 26);
            this.txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkClean.Location = new System.Drawing.Point(17, 105);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(76, 23);
            this.chkClean.TabIndex = 3;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleanCost.Location = new System.Drawing.Point(368, 105);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(65, 19);
            this.lblCleanCost.TabIndex = 4;
            this.lblCleanCost.Text = "$100000";
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkWhitening.Location = new System.Drawing.Point(17, 135);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(85, 23);
            this.chkWhitening.TabIndex = 5;
            this.chkWhitening.Text = "Tẩy trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblWhiteningCost.Location = new System.Drawing.Point(360, 136);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(73, 19);
            this.lblWhiteningCost.TabIndex = 6;
            this.lblWhiteningCost.Text = "$1200000";
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkXRay.Location = new System.Drawing.Point(17, 165);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(119, 23);
            this.chkXRay.TabIndex = 7;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblXRay
            // 
            this.lblXRay.AutoSize = true;
            this.lblXRay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblXRay.Location = new System.Drawing.Point(368, 166);
            this.lblXRay.Name = "lblXRay";
            this.lblXRay.Size = new System.Drawing.Size(65, 19);
            this.lblXRay.TabIndex = 8;
            this.lblXRay.Text = "$200000";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblFilling.Location = new System.Drawing.Point(13, 191);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(70, 19);
            this.lblFilling.TabIndex = 9;
            this.lblFilling.Text = "Trám răng";
            // 
            // numFilling
            // 
            this.numFilling.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.numFilling.Location = new System.Drawing.Point(98, 190);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(83, 26);
            this.numFilling.TabIndex = 10;
            this.numFilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblFillCost.Location = new System.Drawing.Point(355, 197);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(78, 19);
            this.lblFillCost.TabIndex = 11;
            this.lblFillCost.Text = "$80000/cái";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTotal.Location = new System.Drawing.Point(224, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 19);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTotal.Location = new System.Drawing.Point(269, 250);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 26);
            this.txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExit.Location = new System.Drawing.Point(17, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCalc.Location = new System.Drawing.Point(299, 295);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(141, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 337);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.lblXRay);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.Label lblXRay;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
    }
}

