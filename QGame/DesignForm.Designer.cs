namespace QGame
{
    partial class DesignForm
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.grpToolbox = new System.Windows.Forms.GroupBox();
            this.btnYellowBox = new System.Windows.Forms.Button();
            this.btnYellowDoor = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNumberOfColumns = new System.Windows.Forms.Label();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.txtNumberOfColumns = new System.Windows.Forms.TextBox();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.mnuFile.SuspendLayout();
            this.grpToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(1077, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlLayout
            // 
            this.pnlLayout.AutoSize = true;
            this.pnlLayout.Location = new System.Drawing.Point(367, 104);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(685, 471);
            this.pnlLayout.TabIndex = 17;
            // 
            // grpToolbox
            // 
            this.grpToolbox.Controls.Add(this.btnYellowBox);
            this.grpToolbox.Controls.Add(this.btnYellowDoor);
            this.grpToolbox.Controls.Add(this.btnRedBox);
            this.grpToolbox.Controls.Add(this.btnRedDoor);
            this.grpToolbox.Controls.Add(this.btnGreenBox);
            this.grpToolbox.Controls.Add(this.btnGreenDoor);
            this.grpToolbox.Controls.Add(this.btnBlueBox);
            this.grpToolbox.Controls.Add(this.btnBlueDoor);
            this.grpToolbox.Controls.Add(this.btnWall);
            this.grpToolbox.Controls.Add(this.btnNone);
            this.grpToolbox.Location = new System.Drawing.Point(25, 104);
            this.grpToolbox.Name = "grpToolbox";
            this.grpToolbox.Size = new System.Drawing.Size(319, 460);
            this.grpToolbox.TabIndex = 16;
            this.grpToolbox.TabStop = false;
            this.grpToolbox.Text = "Toolbox";
            // 
            // btnYellowBox
            // 
            this.btnYellowBox.Image = global::QGame.Properties.Resources.yellowbox;
            this.btnYellowBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYellowBox.Location = new System.Drawing.Point(161, 360);
            this.btnYellowBox.Name = "btnYellowBox";
            this.btnYellowBox.Size = new System.Drawing.Size(135, 76);
            this.btnYellowBox.TabIndex = 5;
            this.btnYellowBox.Text = "Yellow Box";
            this.btnYellowBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowBox.UseVisualStyleBackColor = true;
            this.btnYellowBox.Click += new System.EventHandler(this.btnYellowBox_Click);
            // 
            // btnYellowDoor
            // 
            this.btnYellowDoor.Image = global::QGame.Properties.Resources.yellowdoor;
            this.btnYellowDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYellowDoor.Location = new System.Drawing.Point(20, 360);
            this.btnYellowDoor.Name = "btnYellowDoor";
            this.btnYellowDoor.Size = new System.Drawing.Size(135, 76);
            this.btnYellowDoor.TabIndex = 5;
            this.btnYellowDoor.Text = "Yellow Door";
            this.btnYellowDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowDoor.UseVisualStyleBackColor = true;
            this.btnYellowDoor.Click += new System.EventHandler(this.btnYellowDoor_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Image = global::QGame.Properties.Resources.redbox;
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.Location = new System.Drawing.Point(161, 278);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(135, 76);
            this.btnRedBox.TabIndex = 5;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Image = global::QGame.Properties.Resources.reddoor;
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.Location = new System.Drawing.Point(20, 278);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(135, 76);
            this.btnRedDoor.TabIndex = 5;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Image = global::QGame.Properties.Resources.greenbox;
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.Location = new System.Drawing.Point(161, 196);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(135, 76);
            this.btnGreenBox.TabIndex = 5;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Image = global::QGame.Properties.Resources.greendoor;
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.Location = new System.Drawing.Point(20, 196);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(135, 76);
            this.btnGreenDoor.TabIndex = 5;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Image = global::QGame.Properties.Resources.bluebox;
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.Location = new System.Drawing.Point(161, 114);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(135, 76);
            this.btnBlueBox.TabIndex = 5;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btnBlueBox_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Image = global::QGame.Properties.Resources.bluedoor;
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.Location = new System.Drawing.Point(20, 114);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(135, 76);
            this.btnBlueDoor.TabIndex = 5;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.Image = global::QGame.Properties.Resources.wall;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.Location = new System.Drawing.Point(161, 32);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(135, 76);
            this.btnWall.TabIndex = 5;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.Image = global::QGame.Properties.Resources.blank;
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.Location = new System.Drawing.Point(20, 32);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(135, 76);
            this.btnNone.TabIndex = 5;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(439, 52);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 23);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNumberOfColumns
            // 
            this.lblNumberOfColumns.AutoSize = true;
            this.lblNumberOfColumns.Location = new System.Drawing.Point(236, 55);
            this.lblNumberOfColumns.Name = "lblNumberOfColumns";
            this.lblNumberOfColumns.Size = new System.Drawing.Size(50, 13);
            this.lblNumberOfColumns.TabIndex = 12;
            this.lblNumberOfColumns.Text = "Columns:";
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(46, 55);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(37, 13);
            this.lblNumberOfRows.TabIndex = 13;
            this.lblNumberOfRows.Text = "Rows:";
            // 
            // txtNumberOfColumns
            // 
            this.txtNumberOfColumns.Location = new System.Drawing.Point(292, 52);
            this.txtNumberOfColumns.Name = "txtNumberOfColumns";
            this.txtNumberOfColumns.Size = new System.Drawing.Size(102, 20);
            this.txtNumberOfColumns.TabIndex = 14;
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(89, 52);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(102, 20);
            this.txtNumberOfRows.TabIndex = 11;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 626);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.grpToolbox);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblNumberOfColumns);
            this.Controls.Add(this.lblNumberOfRows);
            this.Controls.Add(this.txtNumberOfColumns);
            this.Controls.Add(this.txtNumberOfRows);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "DesignForm";
            this.Text = "DesignForm";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.grpToolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.GroupBox grpToolbox;
        private System.Windows.Forms.Button btnYellowBox;
        private System.Windows.Forms.Button btnYellowDoor;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblNumberOfColumns;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.TextBox txtNumberOfColumns;
        private System.Windows.Forms.TextBox txtNumberOfRows;
    }
}