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
            ShowNumber(numbers);
        }
        private void ShowNumber(int[]num)
        {
                lbLista.Items.Clear();
            for (int j = 0;j< num.Length; j++)
            {
                lbLista.Items.Add(num[j]);
            }
        }

        private void btmOrdenar_Click(object sender, EventArgs e)
        {
            MetBurbuja bur = new MetBurbuja();
            int[] orden = null;
            orden = (int []) numbers.Clone();
            bur.OrdenarBurbuja(orden);
            ShowNumber(orden);
        }
    }
}
