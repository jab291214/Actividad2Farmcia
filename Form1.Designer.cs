using Actividad2Farmcia.Logic;

namespace Actividad2Farmcia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitulo = new Label();
            lblnombre = new Label();
            lbltipo = new Label();
            lblcantidad = new Label();
            lbldistribuidor = new Label();
            lblsucursal = new Label();
            inp_text_nombre = new TextBox();
            inp_text_cantidad = new TextBox();
            inp_comb_tipomedicamento = new ComboBox();
            inp_radb_cofarma = new RadioButton();
            inp_radb_empsaphar = new RadioButton();
            inp_radb_cemefar = new RadioButton();
            inp_check_principal = new CheckBox();
            inp_check_segundaria = new CheckBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(224, 30);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(382, 30);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Sistema de pedidos de medicamentos";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(50, 94);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(147, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre del medicamento";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(50, 128);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(123, 15);
            lbltipo.TabIndex = 2;
            lbltipo.Text = "Tipo de medicamento";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(50, 162);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(218, 15);
            lblcantidad.TabIndex = 3;
            lblcantidad.Text = "Cantidad de productos que se requieren";
            // 
            // lbldistribuidor
            // 
            lbldistribuidor.AutoSize = true;
            lbldistribuidor.Location = new Point(50, 197);
            lbldistribuidor.Name = "lbldistribuidor";
            lbldistribuidor.Size = new Size(207, 15);
            lbldistribuidor.TabIndex = 4;
            lbldistribuidor.Text = "Nombre del distribuidor farmaceutico";
            // 
            // lblsucursal
            // 
            lblsucursal.AutoSize = true;
            lblsucursal.Location = new Point(50, 235);
            lblsucursal.Name = "lblsucursal";
            lblsucursal.Size = new Size(220, 15);
            lblsucursal.TabIndex = 5;
            lblsucursal.Text = "Sucursal a la que debe llegar el producto";
            // 
            // inp_text_nombre
            // 
            inp_text_nombre.Location = new Point(436, 86);
            inp_text_nombre.Name = "inp_text_nombre";
            inp_text_nombre.Size = new Size(321, 23);
            inp_text_nombre.TabIndex = 6;
            // 
            // inp_text_cantidad
            // 
            inp_text_cantidad.Location = new Point(436, 154);
            inp_text_cantidad.Name = "inp_text_cantidad";
            inp_text_cantidad.Size = new Size(321, 23);
            inp_text_cantidad.TabIndex = 8;
            // 
            // inp_comb_tipomedicamento
            // 
            inp_comb_tipomedicamento.FormattingEnabled = true;
            inp_comb_tipomedicamento.Items.AddRange(new object[] { "Seleccione", "Analgésico", "Analéptico", "Anestésico" });
            inp_comb_tipomedicamento.Location = new Point(436, 120);
            inp_comb_tipomedicamento.Name = "inp_comb_tipomedicamento";
            inp_comb_tipomedicamento.Size = new Size(321, 23);
            inp_comb_tipomedicamento.TabIndex = 9;
            inp_comb_tipomedicamento.Tag = "";
            // 
            // inp_radb_cofarma
            // 
            inp_radb_cofarma.AutoSize = true;
            inp_radb_cofarma.Location = new Point(436, 193);
            inp_radb_cofarma.Name = "inp_radb_cofarma";
            inp_radb_cofarma.Size = new Size(71, 19);
            inp_radb_cofarma.TabIndex = 10;
            inp_radb_cofarma.TabStop = true;
            inp_radb_cofarma.Text = "Cofarma";
            inp_radb_cofarma.UseVisualStyleBackColor = true;
            // 
            // inp_radb_empsaphar
            // 
            inp_radb_empsaphar.AutoSize = true;
            inp_radb_empsaphar.Location = new Point(548, 193);
            inp_radb_empsaphar.Name = "inp_radb_empsaphar";
            inp_radb_empsaphar.Size = new Size(84, 19);
            inp_radb_empsaphar.TabIndex = 11;
            inp_radb_empsaphar.TabStop = true;
            inp_radb_empsaphar.Text = "Empsephar";
            inp_radb_empsaphar.UseVisualStyleBackColor = true;
            // 
            // inp_radb_cemefar
            // 
            inp_radb_cemefar.AutoSize = true;
            inp_radb_cemefar.Location = new Point(663, 193);
            inp_radb_cemefar.Name = "inp_radb_cemefar";
            inp_radb_cemefar.Size = new Size(70, 19);
            inp_radb_cemefar.TabIndex = 12;
            inp_radb_cemefar.TabStop = true;
            inp_radb_cemefar.Text = "Cemefar";
            inp_radb_cemefar.UseVisualStyleBackColor = true;
            // 
            // inp_check_principal
            // 
            inp_check_principal.AutoSize = true;
            inp_check_principal.Location = new Point(484, 231);
            inp_check_principal.Name = "inp_check_principal";
            inp_check_principal.Size = new Size(72, 19);
            inp_check_principal.TabIndex = 13;
            inp_check_principal.Text = "Principal";
            inp_check_principal.UseVisualStyleBackColor = true;
            // 
            // inp_check_segundaria
            // 
            inp_check_segundaria.AutoSize = true;
            inp_check_segundaria.Location = new Point(607, 231);
            inp_check_segundaria.Name = "inp_check_segundaria";
            inp_check_segundaria.Size = new Size(85, 19);
            inp_check_segundaria.TabIndex = 14;
            inp_check_segundaria.Text = "Segundaria";
            inp_check_segundaria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(481, 310);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(inp_check_segundaria);
            Controls.Add(inp_check_principal);
            Controls.Add(inp_radb_cemefar);
            Controls.Add(inp_radb_empsaphar);
            Controls.Add(inp_radb_cofarma);
            Controls.Add(inp_comb_tipomedicamento);
            Controls.Add(inp_text_cantidad);
            Controls.Add(inp_text_nombre);
            Controls.Add(lblsucursal);
            Controls.Add(lbldistribuidor);
            Controls.Add(lblcantidad);
            Controls.Add(lbltipo);
            Controls.Add(lblnombre);
            Controls.Add(lbltitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        } 

        #endregion

        private Label lbltitulo;
        private Label lblnombre;
        private Label lbltipo;
        private Label lblcantidad;
        private Label lbldistribuidor;
        private Label lblsucursal;
        private TextBox inp_text_nombre;
        private TextBox inp_text_cantidad;
        private ComboBox inp_comb_tipomedicamento;
        private RadioButton inp_radb_cofarma;
        private RadioButton inp_radb_empsaphar;
        private RadioButton inp_radb_cemefar;
        private CheckBox inp_check_principal;
        private CheckBox inp_check_segundaria;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}