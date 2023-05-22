using System.Text;
using System.Web;

namespace I01_Puesto_de_atencion_WinFormsApp
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lable_Surname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.textBox1.Text.Trim();
            string apellido = this.textBox2.Text.Trim();
            string materiaFavorita = this.comboBox_MateriaFavorita.Text.Trim();
            if (esValido(nombre,apellido))
            {
                Frm_msge mssgeBox_saludo = new Frm_msge(nombre, apellido, materiaFavorita);
                mssgeBox_saludo.mssge_SetUserNames();
                this.Hide();
                mssgeBox_saludo.Show();
            }
            else
            {
                MessageBox.Show("Se deben completar los siguientes campos:\n" +
                                "Nombre\n" +
                                "Apellido", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            comboBox_MateriaFavorita.Items.Add("Programación I");
            comboBox_MateriaFavorita.Items.Add("Laboratorio de Computación I");
            comboBox_MateriaFavorita.Items.Add("Sistema de procesamiento de datos");
            comboBox_MateriaFavorita.Items.Add("Inglés I");
            comboBox_MateriaFavorita.Items.Add("Matemática");
            comboBox_MateriaFavorita.Items.Add("Programación II");
            comboBox_MateriaFavorita.Items.Add("Laboratorio de Computación II");
            comboBox_MateriaFavorita.Items.Add("Inglés II");
            comboBox_MateriaFavorita.Items.Add("Metodología de la investigación");
            comboBox_MateriaFavorita.Items.Add("Arquitectura y sistemas operativos");
            comboBox_MateriaFavorita.Items.Add("Estadística");
            comboBox_MateriaFavorita.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_MateriaFavorita_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox_MateriaFavorita.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool esValido(string nombre, string apellido)
        {
            bool esValido = true;
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
            } 
            return esValido;
        }
    }
}