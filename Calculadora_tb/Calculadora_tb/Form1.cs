using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_tb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string Opera = "";
        double[] valores = { 0, 0 };
        
        
        //Agregue un try catch para que no pinche el programa

        public void guardarValor()
        {
            if (double.TryParse(txb_datos.Text, out  valores[0]))
            {
                txb_datos.Clear();

            }else
            {
                MessageBox.Show("Por favor ingrese un numero valido");
                HabilitarOperaciones(true);
            }

        }
        //Manejador de Eventos de los botones del 0 al 9
        private void btn_numerico_Click(object sender, EventArgs e)
        {
            Button btn_num = sender as Button;

            if ((btn_num.Text == "0" && txb_datos.Text.Trim() != "") || (btn_num.Text != "0"))
            {
                txb_datos.Text += btn_num.Text; //el mas igual evita escribir txb_datos.text = txb_datos.Text + btn_num.Text;
            }

        }
        
        //Funcion que habilita o desabilita los botones segun el parametro del bool que se le de. (Funcion con parametros de entrada)
        private void HabilitarOperaciones(bool habilitar)
        {
            btn_simbolo_suma.Enabled = habilitar;
            btn_simbolo_resta.Enabled = habilitar;
            btn_simbolo_multiplicar.Enabled = habilitar;
            btn_simbolo_dividir.Enabled = habilitar;
           
        }
        //metodos para operaciones (MANEJADOR DE EVENTOS)
        private void btn_operaciones_Click(object sender , EventArgs e)
        {
            // se utiliza el valor de la propiedad tag
            Button btn_oper = sender as Button;
            //le asigna el valor de un string a la variable Opera que depende del tag asignado al boton, ej el boton btn_simbolo_suma tiene asignado el tag "S"
           
            
            if (btn_oper.Text == ",")
            {
                if (txb_datos.Text.Contains(","))
                    {
                    
                    }
                else if(txb_datos.Text != "")
                    {
                    txb_datos.Text += ",";
                    }
                else
                {
                    txb_datos.Text += "0,";
                }
            }else
            {
                
                Opera = btn_oper.Tag.ToString();
                HabilitarOperaciones(false);
                guardarValor();
            }
        }





        private void btn_simbolo_igual_Click(object sender, EventArgs e)
        {
            //se asegura de que el valor sea numerico
            if (double.TryParse(txb_datos.Text, out valores[1]))
            {
                switch (Opera)
                {
                    case "S":
                        txb_datos.Text = (valores[0] + valores[1]).ToString();
                        break;
                    case "R":
                        txb_datos.Text = (valores[0] - valores[1]).ToString();
                        break;
                    case "M":
                        txb_datos.Text = (valores[0] * valores[1]).ToString();
                        break;
                    case "D": 
                        if(valores[0] % valores[1] == 0)
                            txb_datos.Text = (valores[0] / valores[1]).ToString("F0");
                        else
                        {
                            txb_datos.Text = (valores[0] / valores[1]).ToString("F3");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero valido.");
                HabilitarOperaciones(true);

            }
           



        }

        private void btn_simbolo_CEborrar_Click(object sender, EventArgs e)
        {
            txb_datos.Clear();
            HabilitarOperaciones(true); // habilitar boton de operaciones
        }

        //cambia el color del boton a gris cuando se le pasa el mouse por arriva
        private void btn_colores_hover(object sender, EventArgs e)
        {
            Button btn_color = sender as Button;
            btn_color.BackColor = Color.FromArgb(233, 236, 139);

        }
        //devuelve el boton a su color original
        private void btn_color_leave(object sender, EventArgs e)
        {
            Button btn_sali = sender as Button;
            btn_sali.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void btn_simbolo_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_datos.Text.Count() != 1 || txb_datos.Text.Count() != 0)
                {
                    txb_datos.Text = txb_datos.Text.Substring(0, txb_datos.Text.Length - 1);
                }
                else
                {
                    
                }

            }
            catch
            {
                MessageBox.Show("hubo un error en la operacion");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        



        /*

    private void btn_num_1_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "1";
    }

    private void btn_num_2_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "2";
    }

    private void btn_num_3_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "3";
    }

    private void btn_num_4_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "4";
    }

    private void btn_num_5_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "5";
    }
    private void btn_num_6_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "6";
    }

    private void btn_num_7_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "7";
    }

    private void btn_num_8_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "8";
    }

    private void btn_num_9_Click(object sender, EventArgs e)
    {
        txb_datos.Text = txb_datos.Text + "9";
    }

    private void btn_num_0_Click(object sender, EventArgs e)
    {

    }

         */




    }
}
