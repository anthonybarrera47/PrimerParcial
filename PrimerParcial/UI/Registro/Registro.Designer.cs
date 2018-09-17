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
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::PrimerParcial.Properties.Resources.if_cross_24_103181;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar.Location = new System.Drawing.Point(276, 215);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 62);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Image = global::PrimerParcial.Properties.Resources.if_floppy_disk_save_103863;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar.Location = new System.Drawing.Point(160, 215);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 62);
            this.Guardar.TabIndex = 14;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::PrimerParcial.Properties.Resources.if_new10_216291;
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevo.Location = new System.Drawing.Point(43, 216);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 61);
            this.Nuevo.TabIndex = 13;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Image = global::PrimerParcial.Properties.Resources.if_search_126577;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar.Location = new System.Drawing.Point(276, 23);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(86, 58);
            this.Buscar.TabIndex = 12;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Buscar;
    }
}