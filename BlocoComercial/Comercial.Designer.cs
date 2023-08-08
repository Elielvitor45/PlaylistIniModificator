namespace IniModificator.BlocoComercial
{
    partial class Comercial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.checkTxt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMapa = new System.Windows.Forms.CheckBox();
            this.checkBoxDataN = new System.Windows.Forms.CheckBox();
            this.checkBoxDataS = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Bloco Comercial]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formato:";
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.Location = new System.Drawing.Point(90, 87);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(52, 19);
            this.checkAuto.TabIndex = 2;
            this.checkAuto.Text = "Auto";
            this.checkAuto.UseVisualStyleBackColor = true;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // checkTxt
            // 
            this.checkTxt.AutoSize = true;
            this.checkTxt.Location = new System.Drawing.Point(148, 87);
            this.checkTxt.Name = "checkTxt";
            this.checkTxt.Size = new System.Drawing.Size(51, 19);
            this.checkTxt.TabIndex = 3;
            this.checkTxt.Text = "TXT1";
            this.checkTxt.UseVisualStyleBackColor = true;
            this.checkTxt.CheckedChanged += new System.EventHandler(this.checkTxt_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arquivo:";
            // 
            // checkMapa
            // 
            this.checkMapa.AutoSize = true;
            this.checkMapa.Location = new System.Drawing.Point(86, 162);
            this.checkMapa.Name = "checkMapa";
            this.checkMapa.Size = new System.Drawing.Size(73, 19);
            this.checkMapa.TabIndex = 5;
            this.checkMapa.Text = "Mapa.txt";
            this.checkMapa.UseVisualStyleBackColor = true;
            this.checkMapa.CheckedChanged += new System.EventHandler(this.checkMapa_CheckedChanged);
            // 
            // checkBoxDataN
            // 
            this.checkBoxDataN.AutoSize = true;
            this.checkBoxDataN.Location = new System.Drawing.Point(161, 162);
            this.checkBoxDataN.Name = "checkBoxDataN";
            this.checkBoxDataN.Size = new System.Drawing.Size(105, 19);
            this.checkBoxDataN.TabIndex = 6;
            this.checkBoxDataN.Text = "Data Numerica";
            this.checkBoxDataN.UseVisualStyleBackColor = true;
            this.checkBoxDataN.CheckedChanged += new System.EventHandler(this.checkBoxDataN_CheckedChanged);
            // 
            // checkBoxDataS
            // 
            this.checkBoxDataS.AutoSize = true;
            this.checkBoxDataS.Location = new System.Drawing.Point(272, 162);
            this.checkBoxDataS.Name = "checkBoxDataS";
            this.checkBoxDataS.Size = new System.Drawing.Size(104, 19);
            this.checkBoxDataS.TabIndex = 7;
            this.checkBoxDataS.Text = "Dia da Semana";
            this.checkBoxDataS.UseVisualStyleBackColor = true;
            this.checkBoxDataS.CheckedChanged += new System.EventHandler(this.checkBoxDataS_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(272, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Comercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxDataS);
            this.Controls.Add(this.checkBoxDataN);
            this.Controls.Add(this.checkMapa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkTxt);
            this.Controls.Add(this.checkAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Comercial";
            this.Text = "Comercial";
            this.Load += new System.EventHandler(this.Comercial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkAuto;
        private CheckBox checkTxt;
        private Label label3;
        private CheckBox checkMapa;
        private CheckBox checkBoxDataN;
        private CheckBox checkBoxDataS;
        private Button button1;
    }
}