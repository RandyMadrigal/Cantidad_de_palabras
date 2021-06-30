using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cantidad_de_palabras
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        //Atributos.
        char guion = '-';
        char espacio = ' ';
        Operadores op1 = new Operadores();
        Operadores op2 = new Operadores();

        //Hacer de varias formas...
        private void GetGuion()
        {
            op1.PALABRA = txtFrase.Text;

            for (int i = 0; i < op1.PALABRA.Length; i++)
            {
                if(op1.PALABRA[i].Equals(guion))
                {
                    op1.TOTAL++;
                }
            }

            cantidadGuion.Text = op1.TOTAL.ToString();

            op1.TOTAL = 0;
        }

        private void GetEspacio()
        {
            op2.PALABRA = txtFrase.Text;

            for (int i=0; i < op2.PALABRA.Length; i++)
            {
                if (op2.PALABRA[i].Equals(espacio) )
                {
                    op2.TOTAL = op2.TOTAL + 1;
                }
            }

            cantidadEspacio.Text = op2.TOTAL.ToString();

            op2.TOTAL = 0;
        }

        private void TotalCaracteres()
        {
            for(int i = 0; i <= txtFrase.Text.Length; i++)
            {
                cantidadTotal.Text = i.ToString();
            }
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            GetEspacio();
            GetGuion();
            TotalCaracteres();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"Icon/cubitos.ico");
            btnLimpiar.Image = Image.FromFile(@"Icon/envase.png");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "";
            cantidadGuion.Text = "0";
            cantidadEspacio.Text = "0";
            cantidadTotal.Text = "0";


        }
    }
}
