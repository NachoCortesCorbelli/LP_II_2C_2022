namespace I01_Puesto_de_atencion_WinFormsApp
{
    partial class Frm_msge
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
            this.lable_Saludo = new System.Windows.Forms.Label();
            this.lbl_usrName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable_Saludo
            // 
            this.lable_Saludo.AutoSize = true;
            this.lable_Saludo.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lable_Saludo.Location = new System.Drawing.Point(60, 52);
            this.lable_Saludo.Name = "lable_Saludo";
            this.lable_Saludo.Size = new System.Drawing.Size(317, 40);
            this.lable_Saludo.TabIndex = 0;
            this.lable_Saludo.Text = "¡Hola, Windows Forms!";
            this.lable_Saludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_usrName
            // 
            this.lbl_usrName.AutoSize = true;
            this.lbl_usrName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usrName.Location = new System.Drawing.Point(60, 122);
            this.lbl_usrName.Name = "lbl_usrName";
            this.lbl_usrName.Size = new System.Drawing.Size(0, 21);
            this.lbl_usrName.TabIndex = 1;
            this.lbl_usrName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Frm_msge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 179);
            this.Controls.Add(this.lbl_usrName);
            this.Controls.Add(this.lable_Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_msge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_msge_FormClosing);
            this.Load += new System.EventHandler(this.Frm_msge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lable_Saludo;
        private Label lbl_usrName;
    }
}