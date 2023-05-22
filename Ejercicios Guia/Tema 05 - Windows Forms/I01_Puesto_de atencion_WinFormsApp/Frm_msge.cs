using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01_Puesto_de_atencion_WinFormsApp
{
    public partial class Frm_msge : Form
    {
        private string name;
        private string surname;
        private string materiaFavorita;
        private Frm_msge()
        {
            InitializeComponent();
        }
        public Frm_msge(string name, string surname, string materiaFavorita) : this()
        {
            this.name = name;
            this.surname = surname;
            this.materiaFavorita = materiaFavorita;
        }
        public void mssge_SetUserNames()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Soy {this.name} {this.surname} y mi " +
                                 $"materia favorita es {this.materiaFavorita}");
            this.lbl_usrName.Text = stringBuilder.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Frm_msge_Load(object sender, EventArgs e)
        {

        }
        private void Frm_msge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
