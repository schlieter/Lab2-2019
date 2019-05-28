namespace Clase_19_Serializacion
{
  partial class FrmNuevo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtBoxNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(39, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(39, 133);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(158, 44);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(158, 88);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 4;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(158, 133);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 218);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(39, 177);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(55, 13);
            this.lblNumeroTarjeta.TabIndex = 8;
            this.lblNumeroTarjeta.Text = "Nº Tarjeta";
            // 
            // txtBoxNumeroTarjeta
            // 
            this.txtBoxNumeroTarjeta.Location = new System.Drawing.Point(158, 177);
            this.txtBoxNumeroTarjeta.Name = "txtBoxNumeroTarjeta";
            this.txtBoxNumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumeroTarjeta.TabIndex = 9;
            // 
            // FrmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 307);
            this.Controls.Add(this.txtBoxNumeroTarjeta);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmNuevo";
            this.Text = "FrmNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblApellido;
    private System.Windows.Forms.Label lblDNI;
    private System.Windows.Forms.TextBox txtBoxNombre;
    private System.Windows.Forms.TextBox txtBoxApellido;
    private System.Windows.Forms.TextBox txtBoxDNI;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Label lblNumeroTarjeta;
    private System.Windows.Forms.TextBox txtBoxNumeroTarjeta;
  }
}
