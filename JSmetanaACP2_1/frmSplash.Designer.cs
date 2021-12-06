namespace JSmetanaACP2_1 {
    partial class frmSplash {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bkgWorker
            // 
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            this.bkgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorker_ProgressChanged);
            // 
            // pgrBar
            // 
            this.pgrBar.Location = new System.Drawing.Point(12, 165);
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(276, 23);
            this.pgrBar.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.Yellow;
            this.lblProgress.Location = new System.Drawing.Point(89, 145);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(128, 16);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "Progress: 100%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pgrBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bkgWorker;
        private System.Windows.Forms.ProgressBar pgrBar;
        private System.Windows.Forms.Label lblProgress;
    }
}