namespace Digital_Diary.Presentation_Layer
{
    partial class Login
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
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(179, 54);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(213, 20);
            this.usernametextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(179, 112);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(213, 20);
            this.passwordtextBox.TabIndex = 3;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Teal;
            this.loginbutton.Font = new System.Drawing.Font("Geometos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton.Location = new System.Drawing.Point(52, 161);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(340, 38);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.loginbutton);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.usernametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Geometos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(52, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign-up";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(830, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}