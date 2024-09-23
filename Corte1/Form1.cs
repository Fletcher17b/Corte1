using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corte1.Models;

namespace Corte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = ("Titulo: Registro de edades - MBGL");
            cmb_ciudad.Items.Add("Managua");
            cmb_ciudad.Items.Add("No se");
        }

        int index = 0;
        Registro registro = new Registro();


        

        private void btn_add_Click(object sender, EventArgs e)
        {
            int temp1 = cmb_ciudad.SelectedIndex;
            string temp;

            if (temp1 == 0)
            {
                temp = "Managua";
            } else
            {
                temp = "No se";
            }
            
            try
            {
                if(index > 30)
                {
                    MessageBox.Show("ERRPR");
                }

               registro.input(index,txb_name.Text,txb_lastname.Text, dtp_fnac.Value,temp);
              //  Console.WriteLine($"{registro.array_persona[index].name}, {registro.array_persona[index].ciudad},{cmb_ciudad.SelectedIndex.ToString()}");
                
               index++;
            }
            catch (Exception ex) { }
            
        }
    }
}
