using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasSimplementeEnlazadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista listita = new Lista();

        private void Mostrar()
        {
            listBox.DataSource = listita.MostrarLista();
        }

        private void btn_remove_inicio_Click(object sender, EventArgs e)
        {
            listita.EliminarAlInicio();
            Mostrar();
        }

        private void btn_add_inicio_Click(object sender, EventArgs e)
        {
            listita.AgregarAlInicio(input1.Text);
            Mostrar();
        }

        private void btn_remove_final_Click(object sender, EventArgs e)
        {
            listita.EliminarAlFinal();
            Mostrar();
        }

        private void btn_add_final_Click(object sender, EventArgs e)
        {
            listita.AgregarAlFinal(input1.Text);
            Mostrar();
        }

        private void btn_remove_n_Click(object sender, EventArgs e)
        {
            listita.EliminarPosN(listBox.SelectedIndex);
            Mostrar();
        }

        private void btn_add_n_Click(object sender, EventArgs e)
        {
            listita.AgregarPosN(input1.Text, listBox.SelectedIndex);
            Mostrar();
        }

        private void btn_change_xy_Click(object sender, EventArgs e)
        {
            listita.IntercambiarPosiciones(Convert.ToInt32(input_pos1.Text), Convert.ToInt32(input_pos2.Text));
            Mostrar();
        }

        private void btn_borrartodo_Click(object sender, EventArgs e)
        {
            listita.BorrarTodo();
            Mostrar();
        }
    }
}
