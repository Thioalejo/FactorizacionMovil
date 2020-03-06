using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Factorizacion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedFactorizacion : TabbedPage
    {
        Operaciones operaciones = new Operaciones();
        double a, b, c, d, e;

      

        public TabbedFactorizacion()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs ev)
        {
            lblFuncion.Text = operaciones.MostrarFuncion4(txtA.Text, txtB.Text, txtC.Text, txtD.Text, txtE.Text);

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            d = Convert.ToDouble(txtD.Text);
            e = Convert.ToDouble(txtE.Text);

            double i = 1;
            double aux = 0;

            //Teorema del factor para allar la raiz
            while (i < Math.Abs(e))
            {
                if (FX_4(i) == 0)
                {
                    aux = i;
                    break;
                }
                else if (FX_4(i * -1) == 0)
                {
                    aux = i * -1;
                    break;
                }
                i = i + 1;
            }

            //Se realiza la division sintetica
            double aux1 = a * aux + b;
            double aux2 = aux * aux1 + c;
            double aux3 = aux * aux2 + d;
            //aux4 = aux*aux3 + e

            double r1 = aux;

            b = aux1;
            c = aux2;
            d = aux3;

            //Se hace division sintetica para el plinomio resultante de grado
            i = 1;
            aux = 0;

            //Se usa el teorema del factor para allar una raiz
            while (i < Math.Abs(d))
            {
                if (FX_3(i) == 0)
                {
                    aux = i;
                    break;
                }
                else if (FX_3(i*-1) == 0)
                {
                    aux = i * -1;
                    break;
                }
                i = i + 1;
            }

            //Se realiza la division sintetica
            aux1 = a * aux + b;
            aux2 = aux1 * aux + c;
            //aux3 = aux2*aux+d;

            double r2 = aux;

            b = aux1;
            c = aux2;

            //Estudiante
            double w =  ((b * 2) - (4 * a * c));

            if (w < 0)
            {

                double b1 = (Math.Sqrt(w * -1)) / (2 * a);

                double b2 = (-1 * b) / (2 * a); 

                lblRaiz1.Text = ("raiz 1:" + r1);
                lblRaiz2.Text = ("raiz 2:" + r2);
                lblRaiz3.Text = ("raiz 3:" + b2 + " + " + b1 + "i");
                lblRaiz4.Text = ("raiz 4:" + b2 + " + " + b1 + "i");
            }
            else
            {

                double r3 = (-1 * b + Math.Sqrt(w)) / (2 * a);
                double r4 = (-1 * b - Math.Sqrt(w)) / (2 * a);

                lblRaiz1.Text =("raiz 1:" + r1);
                lblRaiz2.Text = ("raiz 2:" + r2);
                lblRaiz3.Text = ("raiz 3:" + r3);
                lblRaiz4.Text = ("raiz 4:" + r4);
            }


        }

        private void Button_Clicked_1(object sender, EventArgs ev)
        {
            lblFuncion_3.Text = operaciones.MostrarFuncion3(txtA_3.Text, txtB_3.Text, txtC_3.Text, txtD_3.Text);

            a = Convert.ToDouble(txtA_3.Text);
            b = Convert.ToDouble(txtB_3.Text);
            c = Convert.ToDouble(txtC_3.Text);
            d = Convert.ToDouble(txtD_3.Text);

            double i = 1;
            double aux = 0;

            //Teorema del factor para allar la raiz
            while (i < Math.Abs(d))
            {
                if (FX_3(i) == 0)
                {
                    aux = i;
                    break;
                }
                else if (FX_3(i * -1) == 0)
                {
                    aux = i * -1;
                    break;
                }
                i = i + 1;
            }

            //Se realiza la division sintetica
           double aux1 = a * aux + b;
           double aux2 = aux1 * aux + c;
            //aux3 = aux2*aux+d;

            double r1 = aux;

            b = aux1;
            c = aux2;

            //Estudiante
            double w = ((b * 2) - (4 * a * c));

            if (w < 0)
            {

                double b1 = (Math.Sqrt(w * -1)) / (2 * a);

                double b2 = (-1 * b) / (2 * a);

                lblRaiz1_3.Text = ("raiz 1: " + r1);
                lblRaiz2_3.Text = ("raiz 2: " + b2 + " + " + b1 + "i");
                lblRaiz3_3.Text = ("raiz 3: " + b2 + " + " + b1 + "i");
            }
            else
            {

                double r2 = (-1 * b + Math.Sqrt(w)) / (2 * a);
                double r3 = (-1 * b - Math.Sqrt(w)) / (2 * a);

                lblRaiz1_3.Text = ("raiz 1: " + r1);
                lblRaiz2_3.Text = ("raiz 2: " + r2);
                lblRaiz3_3.Text = ("raiz 3: " + r3);
            }

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

            lblFuncion_2.Text = operaciones.MostrarFuncion2(txtA_2.Text, txtB_2.Text, txtC_2.Text);

            a = Convert.ToDouble(txtA_2.Text);
            b = Convert.ToDouble(txtB_2.Text);
            c = Convert.ToDouble(txtC_2.Text);

            //Formula general
            double w = ((b * 2) - (4 * a * c));

            if (w < 0)
            {

                double b1 = (Math.Sqrt(w * -1)) / (2 * a);

                double b2 = (-1 * b) / (2 * a);

                lblRaiz1_2.Text = ("raiz 1: " + b2 + " - "+ b1 + "i");
                lblRaiz2_2.Text = ("raiz 2: " + b2 + " + " + b1 + "i");
            }
            else
            {

                double r1 = (-1 * b + Math.Sqrt(w)) / (2 * a);
                double r2 = (-1 * b - Math.Sqrt(w)) / (2 * a);

                lblRaiz1_2.Text = ("raiz 1: " + r1);
                lblRaiz2_2.Text = ("raiz 2: " + r2);
            }

        }

        public double FX_4(double x)
        {
            return a*x * 4 + b *x * 3 + c*x * 2 + d * x + e;
        }

        public double FX_3(double x)
        {
            return a * x * 3 + b * x * 2 + c * x + d;
        }


       

    }
   }