using Actividad2Farmcia.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2Farmcia
{
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion()
        {
            InitializeComponent();
            this.FormClosing += CerrarFormulario;
        }
        public void InfoConfirmacion(Pedido pedido)
        {
            if (pedido != null)
            {
                this.Text = "Pedido al distribuidor " + pedido.Distribuidor;
                lblinformacion.Text = pedido.Cantidad + " unidades del " + pedido.Tipo + " " + pedido.Nombremedicamento;

            }
        }
        private void CerrarFormulario(object sender, FormClosingEventArgs e)
        {
            // Evita que el formulario se cierre y, en su lugar, lo oculta
            e.Cancel = true;
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        { 
            this.Hide();
            MessageBox.Show("Guardado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
