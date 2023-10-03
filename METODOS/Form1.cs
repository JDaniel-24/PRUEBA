using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_09
{
    public partial class Form1 : Form
    {
        ArbolBB arbol = new ArbolBB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_valor.Text);
            txt_valor.Clear();
            txt_valor.Focus();
            arbol.inserta(x);
            arbol.preOrden(lst_preOrden);
            arbol.enOrden(lst_enOrden);
            arbol.postOrden(lst_postOrden);
            arbol.OrdenDescendenteen(lst_descendente);
        }

        private void btn_menor_Click(object sender, EventArgs e)
        {
            int men = arbol.BuscarMin();
            MessageBox.Show("El menor es: " + men);
        }
        private void btn_contar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El numero de nodos es: " + arbol.contar());
        }

        private void btn_altura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La altura es: " + arbol.contarAltura());
        }

        private void btn_profundidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La profundidad es: " + arbol.contarProfundidad());
        }

        private void btn_mayor_Click(object sender, EventArgs e)
        {
            int mayor = arbol.BuscarMax();
            MessageBox.Show("El mayor es: " + mayor);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su visita. :D");
            Close();
        }

        private void btn_cantHojas_Click(object sender, EventArgs e)
        {
            int hojas = arbol.contarHojas();
            MessageBox.Show("La cantidad de hojas es: " + hojas);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_enOrden.Items.Clear();
            lst_postOrden.Items.Clear();
            lst_preOrden.Items.Clear();
            lst_descendente.Items.Clear();
            txt_valor.Focus();
        }

        private void btn_diferenciaMenMay_Click(object sender, EventArgs e)
        {
            int diferencia = arbol.Diferencia();
            MessageBox.Show("La diferencia entre el menor y el mayor es: " + diferencia);
        }

        private void lst_descendente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Interaction.InputBox("Ingrese el numero a buscar: "));
            Nodo p = arbol.buscar(x);
            if (p != null)
                MessageBox.Show("El valor se encuentra en el arbol.");
            else
                MessageBox.Show("El valor no se encuentra en el arbol.");
        }
    }
}
