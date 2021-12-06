namespace JSmetanaACP2_1 {
    partial class frmIO {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbxGrades = new System.Windows.Forms.ListBox();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxGrades
            // 
            this.lbxGrades.FormattingEnabled = true;
            this.lbxGrades.Location = new System.Drawing.Point(13, 13);
            this.lbxGrades.Name = "lbxGrades";
            this.lbxGrades.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxGrades.Size = new System.Drawing.Size(150, 134);
            this.lbxGrades.TabIndex = 0;
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(169, 13);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(100, 30);
            this.btnGrades.TabIndex = 1;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(169, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(169, 65);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 30);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "&Write to File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 159);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.lbxGrades);
            this.MaximumSize = new System.Drawing.Size(297, 198);
            this.MinimumSize = new System.Drawing.Size(297, 198);
            this.Name = "frmIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input/Output";
            this.Load += new System.EventHandler(this.frmIO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxGrades;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWrite;
    }
}