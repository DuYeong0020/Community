namespace Community
{
    partial class Detail
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
            this.lbWriter = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnRevise = new System.Windows.Forms.Button();
            this.lbNo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.btnRevise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Font = new System.Drawing.Font("굴림", 10F);
            this.lbWriter.Location = new System.Drawing.Point(720, 6);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(90, 20);
            this.lbWriter.TabIndex = 1;
            this.lbWriter.Text = "작성자 : ";
            this.lbWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(626, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "삭제하기";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("휴먼모음T", 13F);
            this.lbTitle.Location = new System.Drawing.Point(133, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(468, 34);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "제목 : ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.PowderBlue;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(724, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(92, 46);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "목록가기";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnRevise_Click_1);
            // 
            // btnRevise
            // 
            this.btnRevise.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRevise.FlatAppearance.BorderSize = 0;
            this.btnRevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevise.Location = new System.Drawing.Point(528, 12);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(92, 46);
            this.btnRevise.TabIndex = 0;
            this.btnRevise.Text = "수정하기";
            this.btnRevise.UseVisualStyleBackColor = false;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click_1);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Font = new System.Drawing.Font("굴림", 10F);
            this.lbNo.Location = new System.Drawing.Point(16, 6);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(70, 20);
            this.lbNo.TabIndex = 1;
            this.lbNo.Text = "번호 : ";
            this.lbNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNo.Click += new System.EventHandler(this.lbNo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(804, 328);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.lbNo);
            this.panel2.Controls.Add(this.lbWriter);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 385);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "접속한 아이디 : ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("굴림", 10F);
            this.lbUser.Location = new System.Drawing.Point(165, 24);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(20, 20);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "-";
            this.lbUser.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Detail";
            this.Text = "Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.Label lbWriter;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
    }
}