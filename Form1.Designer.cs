namespace IniModificator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blocoComercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoMusicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.beepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocoComercialToolStripMenuItem,
            this.blocoMusicalToolStripMenuItem,
            this.afiliadaToolStripMenuItem,
            this.beepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blocoComercialToolStripMenuItem
            // 
            this.blocoComercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.blocoComercialToolStripMenuItem.Name = "blocoComercialToolStripMenuItem";
            this.blocoComercialToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.blocoComercialToolStripMenuItem.Text = "Bloco Comercial";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click_1);
            // 
            // blocoMusicalToolStripMenuItem
            // 
            this.blocoMusicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem1});
            this.blocoMusicalToolStripMenuItem.Name = "blocoMusicalToolStripMenuItem";
            this.blocoMusicalToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.blocoMusicalToolStripMenuItem.Text = "Bloco Musical";
            // 
            // configurarToolStripMenuItem1
            // 
            this.configurarToolStripMenuItem1.Name = "configurarToolStripMenuItem1";
            this.configurarToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem1.Text = "Configurar";
            // 
            // afiliadaToolStripMenuItem
            // 
            this.afiliadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem2});
            this.afiliadaToolStripMenuItem.Name = "afiliadaToolStripMenuItem";
            this.afiliadaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.afiliadaToolStripMenuItem.Text = "Afiliada";
            // 
            // configurarToolStripMenuItem2
            // 
            this.configurarToolStripMenuItem2.Name = "configurarToolStripMenuItem2";
            this.configurarToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem2.Text = "Configurar";
            // 
            // beepToolStripMenuItem
            // 
            this.beepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem3});
            this.beepToolStripMenuItem.Name = "beepToolStripMenuItem";
            this.beepToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.beepToolStripMenuItem.Text = "Beep";
            // 
            // configurarToolStripMenuItem3
            // 
            this.configurarToolStripMenuItem3.Name = "configurarToolStripMenuItem3";
            this.configurarToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem3.Text = "Configurar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(230, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pasta Playlist Pgm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(230, 240);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(130, 23);
            this.textBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 356);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem blocoComercialToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem;
        private ToolStripMenuItem blocoMusicalToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem1;
        private ToolStripMenuItem afiliadaToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem2;
        private ToolStripMenuItem beepToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem3;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox;
    }
}