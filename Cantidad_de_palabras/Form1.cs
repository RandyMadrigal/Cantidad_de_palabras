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
        Operadores op3 = new Operadores();

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
  
        private void TotalNumero()
        {
            op3.PALABRA = txtFrase.Text;
     
            for(int i = 0; i < op3.PALABRA.Length; i++)
            {
                for(int j=0; j < op3.CADENA.Length; j++)
                {
                    if (op3.PALABRA[i].Equals(op3.CADENA[j] ) )
                    {
                        op3.TOTAL++;
                    }
                }

            }
            CantidadNumeros.Text = op3.TOTAL.ToString();

            op3.TOTAL = 0; 
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            GetEspacio();
            GetGuion();
            TotalCaracteres();
            TotalNumero();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"Icon/cubitos.ico");
            btnLimpiar.Image = Image.FromFile(@"Icon/Dance.gif");
            pictureBox.Image = Image.FromFile(@"Icon/Dance.gif");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limpiando la Pizarra :D");
            txtFrase.Text = "";
            cantidadGuion.Text = "0";
            cantidadEspacio.Text = "0";
            cantidadTotal.Text = "0";
            CantidadNumeros.Text = "0";
        }
    }
}
