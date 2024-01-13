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
        }
        public void InfoConfirmacion(Pedido pedido)
        {
            if (pedido != null)
            {
                this.Text = "Pedido al distribuidor " + pedido.Distribuidor;
                lblinformacion.Text = pedido.Cantidad + " unidades del " + pedido.Tipo + " " + pedido.Nombremedicamento;
            }
        }
    }
}
