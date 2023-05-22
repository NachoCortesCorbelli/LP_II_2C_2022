namespace I01_Puesto_de_atencion_WinFormsApp
{
    partial class Frm_login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.lable_Surname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_MateriaFavorita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ingrese su nombre";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Ingrese su apellido";
            this.textBox2.Size = new System.Drawing.Size(129, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(47, 40);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(58, 17);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Nombre";
            this.label_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lable_Surname
            // 
            this.lable_Surname.AutoSize = true;
            this.lable_Surname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable_Surname.Location = new System.Drawing.Point(218, 40);
            this.lable_Surname.Name = "lable_Surname";
            this.lable_Surname.Size = new System.Drawing.Size(60, 17);
            this.lable_Surname.TabIndex = 3;
            this.lable_Surname.Text = "Apellido";
            this.lable_Surname.Click += new System.EventHandler(this.lable_Surname_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Saludar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_MateriaFavorita
            // 
            this.comboBox_MateriaFavorita.FormattingEnabled = true;
            this.comboBox_MateriaFavorita.Location = new System.Drawing.Point(47, 112);
            this.comboBox_MateriaFavorita.Name = "comboBox_MateriaFavorita";
            this.comboBox_MateriaFavorita.Size = new System.Drawing.Size(300, 23);
            this.comboBox_MateriaFavorita.TabIndex = 5;
            this.comboBox_MateriaFavorita.SelectedIndexChanged += new System.EventHandler(this.comboBox_MateriaFavorita_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Materia Favorita";
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_MateriaFavorita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lable_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Form!";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label_Name;
        private Label lable_Surname;
        private Button button1;
        private ComboBox comboBox_MateriaFavorita;
        private Label label1;
    }
}