
namespace Cantidad_de_palabras
{
    partial class Formulario
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
            this.labelFrase = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.cantidadGuion = new System.Windows.Forms.Label();
            this.cantidadEspacio = new System.Windows.Forms.Label();
            this.labelcantidad2 = new System.Windows.Forms.Label();
            this.cantidadTotal = new System.Windows.Forms.Label();
            this.labelcantidad3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.Location = new System.Drawing.Point(12, 65);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(61, 21);
            this.labelFrase.TabIndex = 0;
            this.labelFrase.Text = "Frase";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(505, 39);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(118, 21);
            this.labelCantidad.TabIndex = 1;
            this.labelCantidad.Text = "Cantidad \"-\"";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(12, 98);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(437, 58);
            this.txtFrase.TabIndex = 2;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // cantidadGuion
            // 
            this.cantidadGuion.AutoSize = true;
            this.cantidadGuion.Location = new System.Drawing.Point(534, 65);
            this.cantidadGuion.Name = "cantidadGuion";
            this.cantidadGuion.Size = new System.Drawing.Size(21, 21);
            this.cantidadGuion.TabIndex = 3;
            this.cantidadGuion.Text = "0";
            // 
            // cantidadEspacio
            // 
            this.cantidadEspacio.AutoSize = true;
            this.cantidadEspacio.Location = new System.Drawing.Point(534, 124);
            this.cantidadEspacio.Name = "cantidadEspacio";
            this.cantidadEspacio.Size = new System.Drawing.Size(21, 21);
            this.cantidadEspacio.TabIndex = 5;
            this.cantidadEspacio.Text = "0";
            // 
            // labelcantidad2
            // 
            this.labelcantidad2.AutoSize = true;
            this.labelcantidad2.Location = new System.Drawing.Point(505, 98);
            this.labelcantidad2.Name = "labelcantidad2";
            this.labelcantidad2.Size = new System.Drawing.Size(117, 21);
            this.labelcantidad2.TabIndex = 4;
            this.labelcantidad2.Text = "Cantidad \" \"";
            // 
            // cantidadTotal
            // 
            this.cantidadTotal.AutoSize = true;
            this.cantidadTotal.Location = new System.Drawing.Point(534, 188);
            this.cantidadTotal.Name = "cantidadTotal";
            this.cantidadTotal.Size = new System.Drawing.Size(21, 21);
            this.cantidadTotal.TabIndex = 7;
            this.cantidadTotal.Text = "0";
            // 
            // labelcantidad3
            // 
            this.labelcantidad3.AutoSize = true;
            this.labelcantidad3.Location = new System.Drawing.Point(523, 157);
            this.labelcantidad3.Name = "labelcantidad3";
            this.labelcantidad3.Size = new System.Drawing.Size(59, 21);
            this.labelcantidad3.TabIndex = 6;
            this.labelcantidad3.Text = "Total ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(675, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 56);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(746, 240);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cantidadTotal);
            this.Controls.Add(this.labelcantidad3);
            this.Controls.Add(this.cantidadEspacio);
            this.Controls.Add(this.labelcantidad2);
            this.Controls.Add(this.cantidadGuion);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelFrase);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label cantidadGuion;
        private System.Windows.Forms.Label cantidadEspacio;
        private System.Windows.Forms.Label labelcantidad2;
        private System.Windows.Forms.Label cantidadTotal;
        private System.Windows.Forms.Label labelcantidad3;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

