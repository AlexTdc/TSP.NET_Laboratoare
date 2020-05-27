namespace GUI
{
    partial class Form2
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
            this.textBoxPath2 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxAbout2 = new System.Windows.Forms.TextBox();
            this.textBoxPlace2 = new System.Windows.Forms.TextBox();
            this.textBoxPeople2 = new System.Windows.Forms.TextBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSaved = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath2
            // 
            this.textBoxPath2.Location = new System.Drawing.Point(425, 39);
            this.textBoxPath2.Name = "textBoxPath2";
            this.textBoxPath2.ReadOnly = true;
            this.textBoxPath2.Size = new System.Drawing.Size(167, 22);
            this.textBoxPath2.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 331);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(314, 42);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Save Changes !";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(492, 111);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 22);
            this.textBoxName2.TabIndex = 2;
            // 
            // textBoxAbout2
            // 
            this.textBoxAbout2.Location = new System.Drawing.Point(492, 162);
            this.textBoxAbout2.Name = "textBoxAbout2";
            this.textBoxAbout2.Size = new System.Drawing.Size(100, 22);
            this.textBoxAbout2.TabIndex = 3;
            // 
            // textBoxPlace2
            // 
            this.textBoxPlace2.Location = new System.Drawing.Point(492, 212);
            this.textBoxPlace2.Name = "textBoxPlace2";
            this.textBoxPlace2.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlace2.TabIndex = 4;
            // 
            // textBoxPeople2
            // 
            this.textBoxPeople2.Location = new System.Drawing.Point(492, 262);
            this.textBoxPeople2.Name = "textBoxPeople2";
            this.textBoxPeople2.Size = new System.Drawing.Size(100, 22);
            this.textBoxPeople2.TabIndex = 5;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(12, 30);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(314, 41);
            this.btnSelectPhoto.TabIndex = 7;
            this.btnSelectPhoto.Text = "Select Photo...";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edit Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edit About:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edit Place:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edit People:";
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.Location = new System.Drawing.Point(165, 400);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(0, 17);
            this.labelSaved.TabIndex = 14;
            this.labelSaved.Click += new System.EventHandler(this.labelSaved_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(398, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 42);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete Photo...";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.textBoxPeople2);
            this.Controls.Add(this.textBoxPlace2);
            this.Controls.Add(this.textBoxAbout2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBoxPath2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxAbout2;
        private System.Windows.Forms.TextBox textBoxPlace2;
        private System.Windows.Forms.TextBox textBoxPeople2;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label6;
    }
}