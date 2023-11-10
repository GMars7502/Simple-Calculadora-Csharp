using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3._0
{
    public partial class Cuerpo : Form
    {

        double N1 = 0, N2 = 0;
        int operador = 0;

        public Cuerpo()
        {
            InitializeComponent();
        }

        clases.ClaseSuma objsuma = new clases.ClaseSuma();
        clases.ClaseResta objresta = new clases.ClaseResta();
        clases.ClaseMulti objmulti = new clases.ClaseMulti();
        clases.ClaseDivision objdivision = new clases.ClaseDivision();


       


        private void BTmas_Click(object sender, EventArgs e)
        {

           
            try
            {
                operador = 1;

                N1 = double.Parse(pantalla.Text);
                pantalla.Clear();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void BTmen_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "" || pantalla.Text == "0")
            {
                pantalla.Text = "-" + pantalla.Text ;

               
            }
            else
            {
                operador = 2;
                N1 = double.Parse(pantalla.Text);
                pantalla.Clear();

            }

           
            

            
        }

        private void BTdivi_Click(object sender, EventArgs e)
        {
            try
            {
                operador = 3;

                N1 = double.Parse(pantalla.Text);
                pantalla.Clear();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void BTmulti_Click(object sender, EventArgs e)
        {

            try
            {
                operador = 4;

                N1 = double.Parse(pantalla.Text);
                pantalla.Clear();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }

        private void BTigual_Click(object sender, EventArgs e)
        {
            N2 = double.Parse(pantalla.Text);
            double operacionSuma;
            double operacionResta;
            double operacionMulti;
            double operacionDivision;

            switch (operador)
            {
                case 1:
                    operacionSuma = objsuma.clasesuma(N1,N2);
                    pantalla.Text = operacionSuma.ToString();
                    break;
                case 2:
                    operacionResta = objresta.claseresta(N1, N2, pantalla.Text);
                    pantalla.Text = operacionResta.ToString();
                    break;
                case 3:
                    operacionDivision = objdivision.clasedivision(N1, N2);
                    pantalla.Text = operacionDivision.ToString();
                    break;
                case 4:
                    operacionMulti = objmulti.clasemulti(N1, N2);
                    pantalla.Text = operacionMulti.ToString();
                    break;
            }
            N1 = 0;
            N2 = 0;
        }

        //private void BTc_Click(object sender, EventArgs e)
        //{
        //    if (ventana.Text == "" || ventana.Text == "0")
        //    {
        //        ventana.Text = "";
        //    }
        //    else
        //    {
        //        int totaldeletras = 0;
        //        totaldeletras = totaldeletras + ventana.TextLength - 1;
        //        ventana.Text = ventana.Text.Remove(totaldeletras);
        //    }

        //}

        private void BT0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void BT9_Click(object sender, EventArgs e)
        {

            pantalla.Text = pantalla.Text + "9";
        }

        private void BTac_Click(object sender, EventArgs e)
        {
            //Eliminacion total 
            pantalla.Clear();
            N1 = 0;
            N2 = 0;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hechoPorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BTc_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "" || pantalla.Text == "0")
            {
                pantalla.Text = "";
            }
            else
            {
                int totaldeletras = 0;
                totaldeletras = totaldeletras + pantalla.TextLength - 1;
                pantalla.Text = pantalla.Text.Remove(totaldeletras);
            }
        }

        private void BTmm_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Contains("-"))
            {
                char sim = '-';
                pantalla.Text = pantalla.Text.Trim(sim);
            }
            else 
            {
                pantalla.Text = "-" + pantalla.Text;   
            }
        }

        private void BTpunto_Click(object sender, EventArgs e)
        {
            ;

            if(pantalla.Text == "")
            {
                pantalla.Text = "0.";
            }
            else if(pantalla.Text.Contains("."))
            {

            }
            else
            {
                pantalla.Text = pantalla.Text + ".";
            }
           
            
        }

        public void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cuerpo_Load(object sender, EventArgs e)
        {

        }
    }
}
