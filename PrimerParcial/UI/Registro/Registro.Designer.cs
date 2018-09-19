namespace PrimerParcial.UI.Registro
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vendedorIDLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label retencionCalculoLabel;
            System.Windows.Forms.Label retencionPorcentajeLabel;
            this.vendedorIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.sueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.retencionCalculoTextBox = new System.Windows.Forms.TextBox();
            this.retencionPorcentajeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDataTimePicker = new System.Windows.Forms.DateTimePicker();
            vendedorIDLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            retencionCalculoLabel = new System.Windows.Forms.Label();
            retencionPorcentajeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionPorcentajeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendedorIDLabel
            // 
            vendedorIDLabel.AutoSize = true;
            vendedorIDLabel.Location = new System.Drawing.Point(3, 64);
            vendedorIDLabel.Name = "vendedorIDLabel";
            vendedorIDLabel.Size = new System.Drawing.Size(89, 17);
            vendedorIDLabel.TabIndex = 16;
            vendedorIDLabel.Text = "vendedor ID:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(3, 90);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(69, 17);
            nombresLabel.TabIndex = 18;
            nombresLabel.Text = "Nombres:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(3, 127);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(56, 17);
            sueldoLabel.TabIndex = 19;
            sueldoLabel.Text = "Sueldo:";
            // 
            // retencionCalculoLabel
            // 
            retencionCalculoLabel.AutoSize = true;
            retencionCalculoLabel.Location = new System.Drawing.Point(3, 167);
            retencionCalculoLabel.Name = "retencionCalculoLabel";
            retencionCalculoLabel.Size = new System.Drawing.Size(135, 17);
            retencionCalculoLabel.TabIndex = 20;
            retencionCalculoLabel.Text = "Retencion A Pagar: ";
            // 
            // retencionPorcentajeLabel
            // 
            retencionPorcentajeLabel.AutoSize = true;
            retencionPorcentajeLabel.Location = new System.Drawing.Point(250, 127);
            retencionPorcentajeLabel.Name = "retencionPorcentajeLabel";
            retencionPorcentajeLabel.Size = new System.Drawing.Size(148, 17);
            retencionPorcentajeLabel.TabIndex = 21;
            retencionPorcentajeLabel.Text = "Retencion Porcentaje:";
            // 
            // vendedorIDNumericUpDown
            // 
            this.vendedorIDNumericUpDown.Location = new System.Drawing.Point(110, 59);
            this.vendedorIDNumericUpDown.Name = "vendedorIDNumericUpDown";
            this.vendedorIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.vendedorIDNumericUpDown.TabIndex = 17;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(110, 87);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(252, 22);
            this.nombresTextBox.TabIndex = 19;
            this.nombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombresTextBox_KeyPress);
            // 
            // sueldoNumericUpDown
            // 
            this.sueldoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendedorBindingSource, "Sueldo", true));
            this.sueldoNumericUpDown.Location = new System.Drawing.Point(110, 125);
            this.sueldoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sueldoNumericUpDown.Name = "sueldoNumericUpDown";
            this.sueldoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.sueldoNumericUpDown.TabIndex = 20;
            this.sueldoNumericUpDown.ValueChanged += new System.EventHandler(this.sueldoNumericUpDown_ValueChanged);
            // 
            // retencionCalculoTextBox
            // 
            this.retencionCalculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "RetencionCalculo", true));
            this.retencionCalculoTextBox.Location = new System.Drawing.Point(144, 164);
            this.retencionCalculoTextBox.MaxLength = 10;
            this.retencionCalculoTextBox.Name = "retencionCalculoTextBox";
            this.retencionCalculoTextBox.ReadOnly = true;
            this.retencionCalculoTextBox.Size = new System.Drawing.Size(100, 22);
            this.retencionCalculoTextBox.TabIndex = 21;
            // 
            // retencionPorcentajeNumericUpDown
            // 
            this.retencionPorcentajeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendedorBindingSource, "RetencionPorcentaje", true));
            this.retencionPorcentajeNumericUpDown.Location = new System.Drawing.Point(253, 164);
            this.retencionPorcentajeNumericUpDown.Name = "retencionPorcentajeNumericUpDown";
            this.retencionPorcentajeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.retencionPorcentajeNumericUpDown.TabIndex = 22;
            this.retencionPorcentajeNumericUpDown.ValueChanged += new System.EventHandler(this.retencionPorcentajeNumericUpDown_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataSource = typeof(PrimerParcial.Entidades.Vendedor);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::PrimerParcial.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(244, 269);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 62);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::PrimerParcial.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(128, 269);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 62);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::PrimerParcial.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 270);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 61);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::PrimerParcial.Properties.Resources.if_search_126577;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(244, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(86, 58);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha";
            // 
            // FechaDataTimePicker
            // 
            this.FechaDataTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDataTimePicker.Location = new System.Drawing.Point(110, 200);
            this.FechaDataTimePicker.Name = "FechaDataTimePicker";
            this.FechaDataTimePicker.Size = new System.Drawing.Size(123, 22);
            this.FechaDataTimePicker.TabIndex = 24;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 352);
            this.Controls.Add(this.FechaDataTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(retencionPorcentajeLabel);
            this.Controls.Add(this.retencionPorcentajeNumericUpDown);
            this.Controls.Add(retencionCalculoLabel);
            this.Controls.Add(this.retencionCalculoTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoNumericUpDown);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(vendedorIDLabel);
            this.Controls.Add(this.vendedorIDNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionPorcentajeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown vendedorIDNumericUpDown;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.NumericUpDown sueldoNumericUpDown;
        private System.Windows.Forms.TextBox retencionCalculoTextBox;
        private System.Windows.Forms.NumericUpDown retencionPorcentajeNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker FechaDataTimePicker;
        private System.Windows.Forms.Label label1;
    }
}