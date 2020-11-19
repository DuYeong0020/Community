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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbWriter = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소하기";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(610, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 44);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "작성하기";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbWriter);
            this.panel2.Controls.Add(this.rtbContent);
            this.panel2.Controls.Add(this.tbNo);
            this.panel2.Controls.Add(this.tbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 371);
            this.panel2.TabIndex = 1;
            // 
            // tbWriter
            // 
            this.tbWriter.Location = new System.Drawing.Point(586, 29);
            this.tbWriter.Name = "tbWriter";
            this.tbWriter.Size = new System.Drawing.Size(100, 28);
            this.tbWriter.TabIndex = 0;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(225, 124);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(357, 155);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(33, 29);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(100, 28);
            this.tbNo.TabIndex = 0;
            this.tbNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(293, 29);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 28);
            this.tbTitle.TabIndex = 0;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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