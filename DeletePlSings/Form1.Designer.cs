namespace DeletePlSings
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
            this.btnChooseTheFile = new System.Windows.Forms.Button();
            this.btnDelPlSings = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNameFileSave = new System.Windows.Forms.Label();
            this.lblQuantityLines = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseTheFile
            // 
            this.btnChooseTheFile.Location = new System.Drawing.Point(29, 141);
            this.btnChooseTheFile.Name = "btnChooseTheFile";
            this.btnChooseTheFile.Size = new System.Drawing.Size(93, 36);
            this.btnChooseTheFile.TabIndex = 0;
            this.btnChooseTheFile.Text = "Wybierz plik";
            this.btnChooseTheFile.UseVisualStyleBackColor = true;
            this.btnChooseTheFile.Click += new System.EventHandler(this.btnChooseTheFile_Click);
            // 
            // btnDelPlSings
            // 
            this.btnDelPlSings.Enabled = false;
            this.btnDelPlSings.Location = new System.Drawing.Point(156, 141);
            this.btnDelPlSings.Name = "btnDelPlSings";
            this.btnDelPlSings.Size = new System.Drawing.Size(127, 36);
            this.btnDelPlSings.TabIndex = 1;
            this.btnDelPlSings.Text = "Usuń polskie znaki";
            this.btnDelPlSings.UseVisualStyleBackColor = true;
            this.btnDelPlSings.Click += new System.EventHandler(this.btnDelPlSings_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(46, 56);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFilePath.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(318, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz plik";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNameFileSave
            // 
            this.lblNameFileSave.Location = new System.Drawing.Point(26, 98);
            this.lblNameFileSave.Name = "lblNameFileSave";
            this.lblNameFileSave.Size = new System.Drawing.Size(396, 40);
            this.lblNameFileSave.TabIndex = 4;
            // 
            // lblQuantityLines
            // 
            this.lblQuantityLines.AutoSize = true;
            this.lblQuantityLines.Location = new System.Drawing.Point(122, 77);
            this.lblQuantityLines.Name = "lblQuantityLines";
            this.lblQuantityLines.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityLines.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "*.txt albo *.srt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantityLines);
            this.Controls.Add(this.lblNameFileSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnDelPlSings);
            this.Controls.Add(this.btnChooseTheFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuwacz polskich ogonków";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseTheFile;
        private System.Windows.Forms.Button btnDelPlSings;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNameFileSave;
        private System.Windows.Forms.Label lblQuantityLines;
        private System.Windows.Forms.Label label1;
    }
}

