using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPCNETCliente.ServiceReference;

namespace UPCNETCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UPCNETServiceClient proxy = new UPCNETServiceClient();
            this.Text = proxy.hello("Hola sal de una ");
            //List<ServiceReference.alumno> x = proxy.Enviar_Alumnos();
            ServiceReference.alumno[] zzzz = proxy.Enviar_Alumnos();

            string zx = zzzz[0].apellido;

            //MessageBox.Show(zzzz[0].apellido);
            dataGridView1.DataSource = zzzz;

            
        }   
    }
}
