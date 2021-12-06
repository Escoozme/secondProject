namespace JSmetanaACP2_1 {
    partial class frmMain {
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
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.tbxAddItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoToInputOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoToMouser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(12, 27);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(178, 316);
            this.lbxItems.TabIndex = 0;
            // 
            // tbxAddItem
            // 
            this.tbxAddItem.Location = new System.Drawing.Point(196, 43);
            this.tbxAddItem.Name = "tbxAddItem";
            this.tbxAddItem.Size = new System.Drawing.Size(100, 20);
            this.tbxAddItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Item here";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(196, 149);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 30);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "A&dd Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(196, 185);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(196, 221);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(100, 30);
            this.btnContains.TabIndex = 6;
            this.btnContains.Text = "C&ontains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(196, 257);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 30);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Dis&play";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoTo,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuGoTo
            // 
            this.mnuGoTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoToInputOutput,
            this.mnuGoToMouser});
            this.mnuGoTo.Name = "mnuGoTo";
            this.mnuGoTo.Size = new System.Drawing.Size(46, 20);
            this.mnuGoTo.Text = "&GoTo";
            // 
            // mnuGoToInputOutput
            // 
            this.mnuGoToInputOutput.Name = "mnuGoToInputOutput";
            this.mnuGoToInputOutput.Size = new System.Drawing.Size(180, 22);
            this.mnuGoToInputOutput.Text = "&Input Output";
            this.mnuGoToInputOutput.Click += new System.EventHandler(this.mnuGoToInputOutput_Click);
            // 
            // mnuGoToMouser
            // 
            this.mnuGoToMouser.Name = "mnuGoToMouser";
            this.mnuGoToMouser.Size = new System.Drawing.Size(180, 22);
            this.mnuGoToMouser.Text = "&Mouser";
            this.mnuGoToMouser.Click += new System.EventHandler(this.mnuGoToMouser_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 352);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAddItem);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(324, 391);
            this.MinimumSize = new System.Drawing.Size(324, 391);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.TextBox tbxAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuGoTo;
        private System.Windows.Forms.ToolStripMenuItem mnuGoToInputOutput;
        private System.Windows.Forms.ToolStripMenuItem mnuGoToMouser;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}

