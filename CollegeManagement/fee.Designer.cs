namespace CollegeManagement
{
    partial class fee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regId = new System.Windows.Forms.TextBox();
            this.feeTV = new System.Windows.Forms.TextBox();
            this.durationTV = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.fullNameTV = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Father\'s Name";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(113, 259);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 22);
            this.label.TabIndex = 4;
            this.label.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fees";
            // 
            // regId
            // 
            this.regId.Location = new System.Drawing.Point(313, 210);
            this.regId.Name = "regId";
            this.regId.Size = new System.Drawing.Size(134, 22);
            this.regId.TabIndex = 6;
            this.regId.TextChanged += new System.EventHandler(this.regId_TextChanged);
            // 
            // feeTV
            // 
            this.feeTV.Location = new System.Drawing.Point(313, 411);
            this.feeTV.Name = "feeTV";
            this.feeTV.Size = new System.Drawing.Size(134, 22);
            this.feeTV.TabIndex = 7;
            // 
            // durationTV
            // 
            this.durationTV.AutoSize = true;
            this.durationTV.Location = new System.Drawing.Point(328, 366);
            this.durationTV.Name = "durationTV";
            this.durationTV.Size = new System.Drawing.Size(70, 16);
            this.durationTV.TabIndex = 8;
            this.durationTV.Text = "_________";
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(328, 312);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(70, 16);
            this.fatherName.TabIndex = 9;
            this.fatherName.Text = "_________";
            // 
            // fullNameTV
            // 
            this.fullNameTV.AutoSize = true;
            this.fullNameTV.Location = new System.Drawing.Point(328, 263);
            this.fullNameTV.Name = "fullNameTV";
            this.fullNameTV.Size = new System.Drawing.Size(70, 16);
            this.fullNameTV.TabIndex = 10;
            this.fullNameTV.Text = "_________";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(313, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 492);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.fullNameTV);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.durationTV);
            this.Controls.Add(this.feeTV);
            this.Controls.Add(this.regId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regId;
        private System.Windows.Forms.TextBox feeTV;
        private System.Windows.Forms.Label durationTV;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label fullNameTV;
        private System.Windows.Forms.Button submitButton;
    }
}