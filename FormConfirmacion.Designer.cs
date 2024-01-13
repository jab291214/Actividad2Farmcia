namespace Actividad2Farmcia
{
    partial class FormConfirmacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblinformacion = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblinformacion
            // 
            lblinformacion.AutoSize = true;
            lblinformacion.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblinformacion.Location = new Point(103, 106);
            lblinformacion.Name = "lblinformacion";
            lblinformacion.Size = new Size(0, 25);
            lblinformacion.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(165, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(382, 196);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 337);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblinformacion);
            Name = "FormConfirmacion";
            Text = "FormConfirmacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblinformacion;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}