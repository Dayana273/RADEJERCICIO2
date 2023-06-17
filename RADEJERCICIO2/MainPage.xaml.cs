using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RADEJERCICIO2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        private int Restar(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }


        private double Dividir(double numero1, double numero2)
        {
            double resultado = numero1 / numero2;
            return resultado;

        }



        private int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        private void btsuma_Clicked(object sender, EventArgs e)
        {

                int num1 = Convert.ToInt32(txtnumero1.Text);
                int num2 = Convert.ToInt32(txtnumero2.Text);
                int resultado = Sumar(num1, num2);
               btresultado.Text = resultado.ToString();
            
        }
       
      

        private void btresta_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnumero1.Text);
            int num2 = Convert.ToInt32(txtnumero2.Text);
            int resultado = Restar(num1, num2);
            btresultado.Text = resultado.ToString();
        }



        private void btdivision_Clicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnumero1.Text);
            double num2 = Convert.ToDouble(txtnumero2.Text);
            double resultado = Dividir(num1, num2);
           btresultado.Text = resultado.ToString();

        }

        private void btmultiplicacion_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnumero1.Text);
            int num2 = Convert.ToInt32(txtnumero2.Text);
            int resultado = Multiplicar(num1, num2);
           btresultado.Text = resultado.ToString();
        }

        private void btresultado_Clicked(object sender, EventArgs e)
        {

            var operacion = new Operaciones();
            
                

            //esto es para llamar una segunda pagina y pasar un parametro a una segunda pantalla//
            var seconpage =new PaginaResultado();
            seconpage.BindingContext = operacion; //paso de parametros a la pantalla
            Navigation.PushAsync(seconpage);
        }
    }
    }

