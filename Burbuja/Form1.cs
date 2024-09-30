using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burbuja.operaciones;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            numbers[i++]=number;
            ShowNumber();
        }
        private void ShowNumber()
        {
            if(numbers.Length > 0)
            {
                lbLista.Items.Clear();
            }
            for (int i = 0;i< numbers.Length; i++)
            {
                lbLista.Items.Add(numbers[i]);
            }
        }

        private void btmOrdenar_Click(object sender, EventArgs e)
        {
            MetBurbuja bur = new MetBurbuja();
            bur.OrdenarBurbuja(numbers);
            ShowNumber();
        }
    }
}
