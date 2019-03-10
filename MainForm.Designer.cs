namespace Oc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnu50pct = new System.Windows.Forms.ToolStripMenuItem();
            this._mnu100pct = new System.Windows.Forms.ToolStripMenuItem();
            this._mnu200pct = new System.Windows.Forms.ToolStripMenuItem();
            this.showAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._txtInfoMessage = new System.Windows.Forms.TextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mnuMainMenu
            // 
            this._mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this._mnuMainMenu.Name = "_mnuMainMenu";
            this._mnuMainMenu.Size = new System.Drawing.Size(384, 24);
            this._mnuMainMenu.TabIndex = 1;
            this._mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuDelete});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // _mnuDelete
            // 
            this._mnuDelete.Name = "_mnuDelete";
            this._mnuDelete.Size = new System.Drawing.Size(107, 22);
            this._mnuDelete.Text = "Delete";
            this._mnuDelete.Click += new System.EventHandler(this._mnuDelete_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnu50pct,
            this._mnu100pct,
            this._mnu200pct,
            this.showAxisToolStripMenuItem,
            this._mnuBackgroundColor,
            this._mnuFullscreen});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // _mnu50pct
            // 
            this._mnu50pct.Name = "_mnu50pct";
            this._mnu50pct.Size = new System.Drawing.Size(170, 22);
            this._mnu50pct.Text = "50%";
            this._mnu50pct.Click += new System.EventHandler(this._mnu50pct_Click);
            // 
            // _mnu100pct
            // 
            this._mnu100pct.Name = "_mnu100pct";
            this._mnu100pct.Size = new System.Drawing.Size(170, 22);
            this._mnu100pct.Text = "100%";
            this._mnu100pct.Click += new System.EventHandler(this._mnu100pct_Click);
            // 
            // _mnu200pct
            // 
            this._mnu200pct.Name = "_mnu200pct";
            this._mnu200pct.Size = new System.Drawing.Size(170, 22);
            this._mnu200pct.Text = "200%";
            this._mnu200pct.Click += new System.EventHandler(this._mnu200pct_Click);
            // 
            // showAxisToolStripMenuItem
            // 
            this.showAxisToolStripMenuItem.Name = "showAxisToolStripMenuItem";
            this.showAxisToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showAxisToolStripMenuItem.Text = "Show Axis";
            this.showAxisToolStripMenuItem.Click += new System.EventHandler(this.showAxisToolStripMenuItem_Click);
            // 
            // _mnuBackgroundColor
            // 
            this._mnuBackgroundColor.Name = "_mnuBackgroundColor";
            this._mnuBackgroundColor.Size = new System.Drawing.Size(170, 22);
            this._mnuBackgroundColor.Text = "Background Color";
            this._mnuBackgroundColor.Click += new System.EventHandler(this._mnuBackgroundColor_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // _txtInfoMessage
            // 
            this._txtInfoMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txtInfoMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._txtInfoMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtInfoMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._txtInfoMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtInfoMessage.Location = new System.Drawing.Point(97, 27);
            this._txtInfoMessage.Multiline = true;
            this._txtInfoMessage.Name = "_txtInfoMessage";
            this._txtInfoMessage.ReadOnly = true;
            this._txtInfoMessage.Size = new System.Drawing.Size(287, 72);
            this._txtInfoMessage.TabIndex = 2;
            this._txtInfoMessage.Text = "Information Message";
            this._txtInfoMessage.Visible = false;
            this._txtInfoMessage.MouseClick += new System.Windows.Forms.MouseEventHandler(this._txtInfoMessage_MouseClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // _mnuAbout
            // 
            this._mnuAbout.Name = "_mnuAbout";
            this._mnuAbout.Size = new System.Drawing.Size(152, 22);
            this._mnuAbout.Text = "About";
            this._mnuAbout.Click += new System.EventHandler(this._mnuAbout_Click);
            // 
            // _mnuFullscreen
            // 
            this._mnuFullscreen.Name = "_mnuFullscreen";
            this._mnuFullscreen.Size = new System.Drawing.Size(170, 22);
            this._mnuFullscreen.Text = "Fullscreen (F12)";
            this._mnuFullscreen.Click += new System.EventHandler(this._mnuFullscreen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 305);
            this.Controls.Add(this._txtInfoMessage);
            this.Controls.Add(this._mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._mnuMainMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._mnuMainMenu.ResumeLayout(false);
            this._mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mnu50pct;
        private System.Windows.Forms.ToolStripMenuItem _mnu100pct;
        private System.Windows.Forms.ToolStripMenuItem _mnu200pct;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem showAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mnuBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox _txtInfoMessage;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem _mnuFullscreen;
    }
}