using Biblioteca;

namespace I02_Registrate_WinFormsApp
{
    public partial class Frm_Ingreso : Form
    {
        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lst_pais.Items.Add("Argentina");
            this.lst_pais.Items.Add("Chile");
            this.lst_pais.Items.Add("Uruguay");
            this.lst_pais.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //List<string> listaCursos = new List<string>();
            string nombre = this.txt_nombre.Text;
            string direccion = this.txt_direccion.Text;
            int edad = (int)this.numb_edad.Value;
            string genero = string.Empty;
            string[] cursos = new string[3];
            string pais = this.lst_pais.Text;
            int i = cursos.Length - 1;
            //Recorro el groupbox chequeando los controles del mismo
            //y si coincide el control y el checked del mismo paso el texto
            //a la variable string del dato que me convenga
            foreach (Control controles in grp_genero.Controls)
            {
                if (controles is RadioButton && ((RadioButton)controles).Checked)
                {
                    genero = controles.Text;
                    break;
                }
            }
            foreach (Control controles in grp_cursos.Controls)
            {
                if (controles is CheckBox && ((CheckBox)controles).Checked)
                {
                    cursos[i] = controles.Text;
                }
                i -= 1;
            }
            Ingresante nuevoIngresante = new Ingresante(cursos,
                                                 direccion,
                                                 edad, genero,
                                                 nombre, pais);
            MessageBox.Show(nuevoIngresante.Mostrar());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grp_usuario_Enter(object sender, EventArgs e)
        {

        }
    }
}