namespace WindowsFormsApplication1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLOURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wORDWRAPPINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 390);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.fORMATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cUTToolStripMenuItem.Text = "CUT";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOPYToolStripMenuItem.Text = "COPY";
            this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pASTEToolStripMenuItem.Text = "PASTE";
            this.pASTEToolStripMenuItem.Click += new System.EventHandler(this.pASTEToolStripMenuItem_Click);
            // 
            // fORMATToolStripMenuItem
            // 
            this.fORMATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fONTToolStripMenuItem,
            this.cOLOURToolStripMenuItem,
            this.wORDWRAPPINGToolStripMenuItem,
            this.sELECTIONToolStripMenuItem});
            this.fORMATToolStripMenuItem.Name = "fORMATToolStripMenuItem";
            this.fORMATToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fORMATToolStripMenuItem.Text = "FORMAT";
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fONTToolStripMenuItem.Text = "FONT";
            this.fONTToolStripMenuItem.Click += new System.EventHandler(this.fONTToolStripMenuItem_Click);
            // 
            // cOLOURToolStripMenuItem
            // 
            this.cOLOURToolStripMenuItem.Name = "cOLOURToolStripMenuItem";
            this.cOLOURToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cOLOURToolStripMenuItem.Text = "COLOUR";
            this.cOLOURToolStripMenuItem.Click += new System.EventHandler(this.cOLOURToolStripMenuItem_Click);
            // 
            // wORDWRAPPINGToolStripMenuItem
            // 
            this.wORDWRAPPINGToolStripMenuItem.Name = "wORDWRAPPINGToolStripMenuItem";
            this.wORDWRAPPINGToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.wORDWRAPPINGToolStripMenuItem.Text = "WORD WRAPPING";
            this.wORDWRAPPINGToolStripMenuItem.Click += new System.EventHandler(this.wORDWRAPPINGToolStripMenuItem_Click);
            // 
            // sELECTIONToolStripMenuItem
            // 
            this.sELECTIONToolStripMenuItem.Name = "sELECTIONToolStripMenuItem";
            this.sELECTIONToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sELECTIONToolStripMenuItem.Text = "SELECTION ";
            this.sELECTIONToolStripMenuItem.Click += new System.EventHandler(this.sELECTIONToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 429);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLOURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wORDWRAPPINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELECTIONToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

