namespace GUI
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelSaveMsg = new System.Windows.Forms.Label();
            this.btnOpenEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(40, 21);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(185, 40);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload photos/videos...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(137, 243);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(280, 22);
            this.textBoxPath.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Photo Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 282);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(280, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(137, 322);
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(280, 22);
            this.textBoxAbout.TabIndex = 6;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(137, 365);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(280, 22);
            this.textBoxPlace.TabIndex = 7;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(137, 405);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(280, 22);
            this.textBoxPeople.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "About:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Place:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "People:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Photo !";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelSaveMsg
            // 
            this.labelSaveMsg.AutoSize = true;
            this.labelSaveMsg.Location = new System.Drawing.Point(38, 456);
            this.labelSaveMsg.Name = "labelSaveMsg";
            this.labelSaveMsg.Size = new System.Drawing.Size(0, 17);
            this.labelSaveMsg.TabIndex = 13;
            // 
            // btnOpenEdit
            // 
            this.btnOpenEdit.Location = new System.Drawing.Point(232, 21);
            this.btnOpenEdit.Name = "btnOpenEdit";
            this.btnOpenEdit.Size = new System.Drawing.Size(185, 40);
            this.btnOpenEdit.TabIndex = 14;
            this.btnOpenEdit.Text = "Edit photo/video...";
            this.btnOpenEdit.UseVisualStyleBackColor = true;
            this.btnOpenEdit.Click += new System.EventHandler(this.btnOpenEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 494);
            this.Controls.Add(this.btnOpenEdit);
            this.Controls.Add(this.labelSaveMsg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelSaveMsg;
        private System.Windows.Forms.Button btnOpenEdit;
    }
}

