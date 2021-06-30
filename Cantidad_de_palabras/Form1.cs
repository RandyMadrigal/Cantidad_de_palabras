using System;
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
        string palabra;
        Operadores op1 = new Operadores();
        Operadores op2 = new Operadores();

        //Hacer de varias formas...
        private void GetGuion()
        {
            palabra = txtFrase.Text;

            for (int i = 0; i < palabra.Length; i++)
            {
                if(palabra[i].Equals(guion))
                {
                    op1.TOTAL++;
                }
            }

            cantidadGuion.Text = op1.TOTAL.ToString();

            op1.TOTAL = 0;
        }

        private void GetEspacio()
        {
            for (int i=0; i < txtFrase.Text.Length; i++)
            {
                if (txtFrase.Text[i].Equals(espacio) )
                {
                    op2.TOTAL++ ;
                }

                cantidadEspacio.Text = op2.TOTAL.ToString();
                
                op2.TOTAL = 0;
            }
        }

        private void TotalCaracteres()
        {

            for(int i = 1; i <= txtFrase.Text.Length; i++)
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



    }

    
}
