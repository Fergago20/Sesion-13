using Registro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btmPersona_Click(object sender, EventArgs e)
        {
           Persona per = new Persona();
            per.FirstName= tbNombre.Text;
            per.LastName= tbApellido.Text;
            per.BirthDate= dtpFecha.Value.Date;
            per.CalcularEdad();
            personas.Add(per);
            ShowPersons();
            ClearTb();
        }

        private void ShowPersons()
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = personas;
        }
        private void ClearTb()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            dtpFecha.Value= DateTime.Now;
            tbNombre.Focus();
        }
    }
}
