namespace CRUD
{
    partial class frmDetalleContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleContactos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(1, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(102, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 29);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(102, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 29);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(1, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 24);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(102, 136);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(237, 29);
            this.txtTel.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(1, 141);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 24);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Telefono:";
            // 
            // txtDirec
            // 
            this.txtDirec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirec.Location = new System.Drawing.Point(102, 192);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(237, 29);
            this.txtDirec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dirección:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(102, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmDetalleContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 343);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalleContactos";
            this.Text = "NUEVO CONTACTO";
            this.Load += new System.EventHandler(this.frmDetalleContactos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
    }
}