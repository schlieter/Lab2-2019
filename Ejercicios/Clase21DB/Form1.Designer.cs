namespace Clase21DB
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtBoxLocalidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProvincias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(110, 55);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincias.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(24, 123);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtBoxLocalidad
            // 
            this.txtBoxLocalidad.Location = new System.Drawing.Point(110, 120);
            this.txtBoxLocalidad.Name = "txtBoxLocalidad";
            this.txtBoxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLocalidad.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(89, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblProvincias
            // 
            this.lblProvincias.AutoSize = true;
            this.lblProvincias.Location = new System.Drawing.Point(24, 63);
            this.lblProvincias.Name = "lblProvincias";
            this.lblProvincias.Size = new System.Drawing.Size(56, 13);
            this.lblProvincias.TabIndex = 4;
            this.lblProvincias.Text = "Provincias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 282);
            this.Controls.Add(this.lblProvincias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBoxLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cmbProvincias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbProvincias;
    private System.Windows.Forms.Label lblLocalidad;
    private System.Windows.Forms.TextBox txtBoxLocalidad;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label lblProvincias;
  }
}

