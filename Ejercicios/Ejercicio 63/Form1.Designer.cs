namespace Ejercicio_63
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
            this.lblHoraFija = new System.Windows.Forms.Label();
            this.lblHoraActualizada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHoraFija
            // 
            this.lblHoraFija.AutoSize = true;
            this.lblHoraFija.Location = new System.Drawing.Point(233, 154);
            this.lblHoraFija.Name = "lblHoraFija";
            this.lblHoraFija.Size = new System.Drawing.Size(46, 13);
            this.lblHoraFija.TabIndex = 0;
            this.lblHoraFija.Text = "Hora fija";
            // 
            // lblHoraActualizada
            // 
            this.lblHoraActualizada.AutoSize = true;
            this.lblHoraActualizada.Location = new System.Drawing.Point(233, 190);
            this.lblHoraActualizada.Name = "lblHoraActualizada";
            this.lblHoraActualizada.Size = new System.Drawing.Size(87, 13);
            this.lblHoraActualizada.TabIndex = 1;
            this.lblHoraActualizada.Text = "Hora actualizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoraActualizada);
            this.Controls.Add(this.lblHoraFija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblHoraFija;
    private System.Windows.Forms.Label lblHoraActualizada;
    private System.Windows.Forms.Label label2;
  }
}

