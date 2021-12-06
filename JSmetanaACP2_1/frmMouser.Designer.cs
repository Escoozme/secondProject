namespace JSmetanaACP2_1 {
    partial class frmMouser {
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
            this.lblMouseClickCoords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMouseClickCoords
            // 
            this.lblMouseClickCoords.AutoSize = true;
            this.lblMouseClickCoords.Location = new System.Drawing.Point(13, 13);
            this.lblMouseClickCoords.Name = "lblMouseClickCoords";
            this.lblMouseClickCoords.Size = new System.Drawing.Size(25, 13);
            this.lblMouseClickCoords.TabIndex = 0;
            this.lblMouseClickCoords.Text = "0, 0";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(372, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMouseClickCoords);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmMouser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMouser";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMouser_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMouseClickCoords;
        private System.Windows.Forms.Button btnClose;
    }
}