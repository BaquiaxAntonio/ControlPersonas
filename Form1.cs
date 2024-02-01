using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        //clase objeto
        //Instaciar la clase 
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;

                
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text=persona.FechaNacimiento.ToShortDateString ();
            labelEdad.Text = persona.edad().ToString() +" Años";

            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFecha.Visible = true;
            labelEdad.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            labelNombre.Text=persona.Nombre;    
            labelApellido.Text=persona.Apellido;
            persona.Nombre = labelNombre.Text;
            persona.Apellido = labelApellido.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
