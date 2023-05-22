namespace I02_Registrate_WinFormsApp
{
    partial class Frm_Ingreso
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
            this.grp_usuario = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numb_edad = new System.Windows.Forms.NumericUpDown();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.grp_genero = new System.Windows.Forms.GroupBox();
            this.rdo_femenino = new System.Windows.Forms.RadioButton();
            this.rdo_nobinario = new System.Windows.Forms.RadioButton();
            this.rdo_masculino = new System.Windows.Forms.RadioButton();
            this.grp_pais = new System.Windows.Forms.GroupBox();
            this.lst_pais = new System.Windows.Forms.ListBox();
            this.grp_cursos = new System.Windows.Forms.GroupBox();
            this.chk_javascript = new System.Windows.Forms.CheckBox();
            this.chk_masmas = new System.Windows.Forms.CheckBox();
            this.chk_csharp = new System.Windows.Forms.CheckBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.grp_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_edad)).BeginInit();
            this.grp_genero.SuspendLayout();
            this.grp_pais.SuspendLayout();
            this.grp_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_usuario
            // 
            this.grp_usuario.Controls.Add(this.label3);
            this.grp_usuario.Controls.Add(this.label2);
            this.grp_usuario.Controls.Add(this.label1);
            this.grp_usuario.Controls.Add(this.numb_edad);
            this.grp_usuario.Controls.Add(this.txt_direccion);
            this.grp_usuario.Controls.Add(this.txt_nombre);
            this.grp_usuario.Location = new System.Drawing.Point(27, 32);
            this.grp_usuario.Name = "grp_usuario";
            this.grp_usuario.Size = new System.Drawing.Size(271, 166);
            this.grp_usuario.TabIndex = 0;
            this.grp_usuario.TabStop = false;
            this.grp_usuario.Text = "Detalles del Usuario";
            this.grp_usuario.Enter += new System.EventHandler(this.grp_usuario_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // numb_edad
            // 
            this.numb_edad.Location = new System.Drawing.Point(108, 118);
            this.numb_edad.Name = "numb_edad";
            this.numb_edad.Size = new System.Drawing.Size(120, 23);
            this.numb_edad.TabIndex = 2;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(108, 79);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(120, 23);
            this.txt_direccion.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(108, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(120, 23);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grp_genero
            // 
            this.grp_genero.Controls.Add(this.rdo_femenino);
            this.grp_genero.Controls.Add(this.rdo_nobinario);
            this.grp_genero.Controls.Add(this.rdo_masculino);
            this.grp_genero.Location = new System.Drawing.Point(365, 32);
            this.grp_genero.Name = "grp_genero";
            this.grp_genero.Size = new System.Drawing.Size(179, 117);
            this.grp_genero.TabIndex = 1;
            this.grp_genero.TabStop = false;
            this.grp_genero.Text = "Género";
            // 
            // rdo_femenino
            // 
            this.rdo_femenino.AutoSize = true;
            this.rdo_femenino.Location = new System.Drawing.Point(25, 55);
            this.rdo_femenino.Name = "rdo_femenino";
            this.rdo_femenino.Size = new System.Drawing.Size(78, 19);
            this.rdo_femenino.TabIndex = 2;
            this.rdo_femenino.TabStop = true;
            this.rdo_femenino.Text = "Femenino";
            this.rdo_femenino.UseVisualStyleBackColor = true;
            this.rdo_femenino.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdo_nobinario
            // 
            this.rdo_nobinario.AutoSize = true;
            this.rdo_nobinario.Location = new System.Drawing.Point(25, 80);
            this.rdo_nobinario.Name = "rdo_nobinario";
            this.rdo_nobinario.Size = new System.Drawing.Size(81, 19);
            this.rdo_nobinario.TabIndex = 1;
            this.rdo_nobinario.TabStop = true;
            this.rdo_nobinario.Text = "No Binario";
            this.rdo_nobinario.UseVisualStyleBackColor = true;
            // 
            // rdo_masculino
            // 
            this.rdo_masculino.AutoSize = true;
            this.rdo_masculino.Location = new System.Drawing.Point(25, 30);
            this.rdo_masculino.Name = "rdo_masculino";
            this.rdo_masculino.Size = new System.Drawing.Size(80, 19);
            this.rdo_masculino.TabIndex = 0;
            this.rdo_masculino.TabStop = true;
            this.rdo_masculino.Text = "Masculino";
            this.rdo_masculino.UseVisualStyleBackColor = true;
            // 
            // grp_pais
            // 
            this.grp_pais.Controls.Add(this.lst_pais);
            this.grp_pais.Location = new System.Drawing.Point(27, 226);
            this.grp_pais.Name = "grp_pais";
            this.grp_pais.Size = new System.Drawing.Size(271, 133);
            this.grp_pais.TabIndex = 2;
            this.grp_pais.TabStop = false;
            this.grp_pais.Text = "País";
            // 
            // lst_pais
            // 
            this.lst_pais.FormattingEnabled = true;
            this.lst_pais.ItemHeight = 15;
            this.lst_pais.Location = new System.Drawing.Point(0, 23);
            this.lst_pais.Name = "lst_pais";
            this.lst_pais.Size = new System.Drawing.Size(271, 109);
            this.lst_pais.TabIndex = 0;
            this.lst_pais.SelectedIndexChanged += new System.EventHandler(this.lst_pais_SelectedIndexChanged);
            // 
            // grp_cursos
            // 
            this.grp_cursos.Controls.Add(this.chk_javascript);
            this.grp_cursos.Controls.Add(this.chk_masmas);
            this.grp_cursos.Controls.Add(this.chk_csharp);
            this.grp_cursos.Location = new System.Drawing.Point(365, 174);
            this.grp_cursos.Name = "grp_cursos";
            this.grp_cursos.Size = new System.Drawing.Size(179, 117);
            this.grp_cursos.TabIndex = 2;
            this.grp_cursos.TabStop = false;
            this.grp_cursos.Text = "Cursos";
            // 
            // chk_javascript
            // 
            this.chk_javascript.AutoSize = true;
            this.chk_javascript.Location = new System.Drawing.Point(25, 77);
            this.chk_javascript.Name = "chk_javascript";
            this.chk_javascript.Size = new System.Drawing.Size(78, 19);
            this.chk_javascript.TabIndex = 2;
            this.chk_javascript.Text = "JavaScript";
            this.chk_javascript.UseVisualStyleBackColor = true;
            // 
            // chk_masmas
            // 
            this.chk_masmas.AutoSize = true;
            this.chk_masmas.Location = new System.Drawing.Point(25, 52);
            this.chk_masmas.Name = "chk_masmas";
            this.chk_masmas.Size = new System.Drawing.Size(50, 19);
            this.chk_masmas.TabIndex = 1;
            this.chk_masmas.Text = "C++";
            this.chk_masmas.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            this.chk_csharp.AutoSize = true;
            this.chk_csharp.Location = new System.Drawing.Point(25, 27);
            this.chk_csharp.Name = "chk_csharp";
            this.chk_csharp.Size = new System.Drawing.Size(41, 19);
            this.chk_csharp.TabIndex = 0;
            this.chk_csharp.Text = "C#";
            this.chk_csharp.UseVisualStyleBackColor = true;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(365, 329);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(179, 29);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 384);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.grp_cursos);
            this.Controls.Add(this.grp_pais);
            this.Controls.Add(this.grp_genero);
            this.Controls.Add(this.grp_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_usuario.ResumeLayout(false);
            this.grp_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_edad)).EndInit();
            this.grp_genero.ResumeLayout(false);
            this.grp_genero.PerformLayout();
            this.grp_pais.ResumeLayout(false);
            this.grp_cursos.ResumeLayout(false);
            this.grp_cursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp_usuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numb_edad;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private GroupBox grp_genero;
        private RadioButton rdo_femenino;
        private RadioButton rdo_nobinario;
        private RadioButton rdo_masculino;
        private GroupBox grp_pais;
        private GroupBox grp_cursos;
        private Button btn_ingresar;
        private ListBox lst_pais;
        private CheckBox chk_javascript;
        private CheckBox chk_masmas;
        private CheckBox chk_csharp;
    }
}