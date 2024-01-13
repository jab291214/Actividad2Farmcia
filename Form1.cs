using Actividad2Farmcia.Logic;

namespace Actividad2Farmcia
{
    public partial class Form1 : Form
    {
        Pedido pedido=new Pedido();
        FormConfirmacion formcon = new FormConfirmacion();
        public Form1()
        {
            InitializeComponent();
            inp_comb_tipomedicamento.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inp_text_nombre.Text= string.Empty;
            inp_comb_tipomedicamento.SelectedIndex=0;
            inp_text_cantidad.Text = "0";
            inp_radb_cemefar.Checked= false;
            inp_radb_empsaphar.Checked= false;
            inp_radb_cofarma.Checked= false;
            inp_check_principal.Checked= false;
            inp_check_segundaria.Checked= false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (inp_text_nombre.Text.Equals(""))
                {
                    throw new Exception("El nombre del medicamento no puede estar vacio");
                }
                pedido.Nombremedicamento = inp_text_nombre.Text;
                if (inp_comb_tipomedicamento.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un tipo de Medicamento");
                }
                if (  inp_comb_tipomedicamento.SelectedItem.Equals("") || inp_comb_tipomedicamento.SelectedItem.ToString() == "Seleccione")
                {
                    throw new Exception("Debe seleccionar un tipo de Medicamento");

                }
                pedido.Tipo = (string)inp_comb_tipomedicamento.SelectedItem;

                try
                {
                    var numero= Convert.ToInt32(inp_text_cantidad.Text);
                }
                catch (Exception)
                {
                    throw new Exception("La cantidad ingresada es invalida");
                }
                if (Convert.ToInt32(inp_text_cantidad.Text)<=0)
                {
                    throw new Exception("La cantidad ingresada es menor o igual a cero, por favor ingrese un valor positivo");
                }
                pedido.Cantidad = Convert.ToInt32(inp_text_cantidad.Text);

                if (inp_radb_cemefar.Checked)
                {
                    pedido.Distribuidor = inp_radb_cemefar.Text;
                }
                if (inp_radb_cofarma.Checked)
                {
                    pedido.Distribuidor = inp_radb_cofarma.Text;
                }
                if (inp_radb_empsaphar.Checked)
                {
                    pedido.Distribuidor = inp_radb_empsaphar.Text;
                }
                if (pedido.Distribuidor.Equals(""))
                {
                    throw new Exception("Por favor seleccione un distribuidor");
                }

                if (inp_check_principal.Checked== inp_check_segundaria.Checked)
                {
                    throw new Exception("Sucursal invalida, seleccione una sucursal");
                }
                if (inp_check_principal.Checked)
                {
                    pedido.Sucursal = inp_check_principal.Text;
                }
                if (inp_check_segundaria.Checked)
                {
                    pedido.Sucursal = inp_check_segundaria.Text;
                }
                formcon.Text = "Cargando...";
                formcon.InfoConfirmacion(pedido);
                formcon.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }
    }
}