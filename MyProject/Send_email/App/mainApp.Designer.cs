namespace Send_email
{
    partial class mainApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnViewEmails = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Body:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "From your";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(72, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your gmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(103, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Send email";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(107, 84);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(232, 22);
            this.txtFrom.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(107, 199);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(232, 22);
            this.txtTo.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(107, 248);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(283, 22);
            this.txtSubject.TabIndex = 16;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(108, 318);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(436, 219);
            this.txtBody.TabIndex = 17;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.Location = new System.Drawing.Point(333, 558);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 36);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send email";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(29, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "gmail acount:";
            // 
            // btnViewEmails
            // 
            this.btnViewEmails.BackColor = System.Drawing.Color.Gold;
            this.btnViewEmails.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmails.ForeColor = System.Drawing.Color.Blue;
            this.btnViewEmails.Location = new System.Drawing.Point(107, 558);
            this.btnViewEmails.Name = "btnViewEmails";
            this.btnViewEmails.Size = new System.Drawing.Size(192, 36);
            this.btnViewEmails.TabIndex = 22;
            this.btnViewEmails.Text = "Sharing all emails";
            this.btnViewEmails.UseVisualStyleBackColor = false;
            this.btnViewEmails.Click += new System.EventHandler(this.btnViewEmails_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App.Properties.Resources.google_symbol;
            this.pictureBox2.Location = new System.Drawing.Point(46, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 38);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Properties.Resources.email__2_;
            this.pictureBox1.Location = new System.Drawing.Point(367, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 169);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(588, 610);
            this.Controls.Add(this.btnViewEmails);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainApp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewEmails;
    }
}