namespace IniModificator.Bloco_Musical
{
    partial class Musical
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxDataS = new System.Windows.Forms.CheckBox();
            this.checkBoxDataN = new System.Windows.Forms.CheckBox();
            this.checkGrade = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkTxt = new System.Windows.Forms.CheckBox();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(273, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxDataS
            // 
            this.checkBoxDataS.AutoSize = true;
            this.checkBoxDataS.Location = new System.Drawing.Point(273, 162);
            this.checkBoxDataS.Name = "checkBoxDataS";
            this.checkBoxDataS.Size = new System.Drawing.Size(104, 19);
            this.checkBoxDataS.TabIndex = 16;
            this.checkBoxDataS.Text = "Dia da Semana";
            this.checkBoxDataS.UseVisualStyleBackColor = true;
            this.checkBoxDataS.CheckedChanged += new System.EventHandler(this.checkBoxDataS_CheckedChanged);
            // 
            // checkBoxDataN
            // 
            this.checkBoxDataN.AutoSize = true;
            this.checkBoxDataN.Location = new System.Drawing.Point(167, 162);
            this.checkBoxDataN.Name = "checkBoxDataN";
            this.checkBoxDataN.Size = new System.Drawing.Size(105, 19);
            this.checkBoxDataN.TabIndex = 15;
            this.checkBoxDataN.Text = "Data Numerica";
            this.checkBoxDataN.UseVisualStyleBackColor = true;
            this.checkBoxDataN.CheckedChanged += new System.EventHandler(this.checkBoxDataN_CheckedChanged);
            // 
            // checkGrade
            // 
            this.checkGrade.AutoSize = true;
            this.checkGrade.Location = new System.Drawing.Point(87, 162);
            this.checkGrade.Name = "checkGrade";
            this.checkGrade.Size = new System.Drawing.Size(74, 19);
            this.checkGrade.TabIndex = 14;
            this.checkGrade.Text = "Grade.txt";
            this.checkGrade.UseVisualStyleBackColor = true;
            this.checkGrade.CheckedChanged += new System.EventHandler(this.checkGrade_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Arquivo:";
            // 
            // checkTxt
            // 
            this.checkTxt.AutoSize = true;
            this.checkTxt.Location = new System.Drawing.Point(149, 87);
            this.checkTxt.Name = "checkTxt";
            this.checkTxt.Size = new System.Drawing.Size(51, 19);
            this.checkTxt.TabIndex = 12;
            this.checkTxt.Text = "TXT1";
            this.checkTxt.UseVisualStyleBackColor = true;
            this.checkTxt.CheckedChanged += new System.EventHandler(this.checkTxt_CheckedChanged);
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.Location = new System.Drawing.Point(91, 87);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(52, 19);
            this.checkAuto.TabIndex = 11;
            this.checkAuto.Text = "Auto";
            this.checkAuto.UseVisualStyleBackColor = true;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Formato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "[Bloco Musical]";
            // 
            // Musical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxDataS);
            this.Controls.Add(this.checkBoxDataN);
            this.Controls.Add(this.checkGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkTxt);
            this.Controls.Add(this.checkAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Musical";
            this.Text = "Musical";
            this.Load += new System.EventHandler(this.Musical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox checkBoxDataS;
        private CheckBox checkBoxDataN;
        private CheckBox checkGrade;
        private Label label3;
        private CheckBox checkTxt;
        private CheckBox checkAuto;
        private Label label2;
        private Label label1;
    }
}