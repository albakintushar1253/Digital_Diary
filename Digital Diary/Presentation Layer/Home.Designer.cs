namespace Digital_Diary.Presentation_Layer
{
    partial class Home
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
            this.createeventbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadCreateEventDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadCreateEventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createeventbutton
            // 
            this.createeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createeventbutton.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createeventbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createeventbutton.Location = new System.Drawing.Point(308, 54);
            this.createeventbutton.Name = "createeventbutton";
            this.createeventbutton.Size = new System.Drawing.Size(253, 51);
            this.createeventbutton.TabIndex = 0;
            this.createeventbutton.Text = "Create New Event";
            this.createeventbutton.UseVisualStyleBackColor = false;
            this.createeventbutton.Click += new System.EventHandler(this.createeventbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Red;
            this.deletebutton.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebutton.Location = new System.Drawing.Point(308, 111);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(125, 43);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            // 
            // modifybutton
            // 
            this.modifybutton.BackColor = System.Drawing.Color.Green;
            this.modifybutton.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifybutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifybutton.Location = new System.Drawing.Point(436, 111);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(125, 43);
            this.modifybutton.TabIndex = 2;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = false;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(362, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Diary";
            // 
            // loadCreateEventDataGridView
            // 
            this.loadCreateEventDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadCreateEventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadCreateEventDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadCreateEventDataGridView.Location = new System.Drawing.Point(164, 177);
            this.loadCreateEventDataGridView.Name = "loadCreateEventDataGridView";
            this.loadCreateEventDataGridView.ReadOnly = true;
            this.loadCreateEventDataGridView.Size = new System.Drawing.Size(544, 336);
            this.loadCreateEventDataGridView.TabIndex = 4;
            this.loadCreateEventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometos", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(161, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event List";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(867, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadCreateEventDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.createeventbutton);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadCreateEventDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createeventbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loadCreateEventDataGridView;
        private System.Windows.Forms.Label label2;
    }
}