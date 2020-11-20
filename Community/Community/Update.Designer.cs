namespace Community
{
    partial class Update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbWriter = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbWriter);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.tbNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 63);
            this.panel1.TabIndex = 0;
            // 
            // tbWriter
            // 
            this.tbWriter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWriter.Font = new System.Drawing.Font("굴림", 10F);
            this.tbWriter.Location = new System.Drawing.Point(520, 11);
            this.tbWriter.Multiline = true;
            this.tbWriter.Name = "tbWriter";
            this.tbWriter.Size = new System.Drawing.Size(100, 46);
            this.tbWriter.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(626, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소하기";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(724, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 46);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "작성하기";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.White;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("굴림", 13F);
            this.tbTitle.Location = new System.Drawing.Point(105, 11);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(409, 46);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNo
            // 
            this.tbNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNo.Font = new System.Drawing.Font("굴림", 10F);
            this.tbNo.Location = new System.Drawing.Point(12, 11);
            this.tbNo.Multiline = true;
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(87, 46);
            this.tbNo.TabIndex = 0;
            this.tbNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbContent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 387);
            this.panel2.TabIndex = 1;
            // 
            // rtbContent
            // 
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Location = new System.Drawing.Point(12, 6);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(804, 353);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbWriter;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}