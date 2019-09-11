namespace FormBilletes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotización";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(217, 47);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(33, 13);
            this.lblEuroA.TabIndex = 1;
            this.lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(303, 47);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(37, 13);
            this.lblDolarA.TabIndex = 2;
            this.lblDolarA.Text = "Dólar";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoA.Location = new System.Drawing.Point(394, 47);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(35, 13);
            this.lblPesoA.TabIndex = 3;
            this.lblPesoA.Text = "Peso";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(16, 73);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(33, 13);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 100);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(37, 13);
            this.lblDolar.TabIndex = 5;
            this.lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(14, 129);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(196, 15);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(73, 20);
            this.txtCotizacionEuro.TabIndex = 7;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(284, 15);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(73, 20);
            this.txtCotizacionDolar.TabIndex = 8;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(375, 15);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(73, 20);
            this.txtCotizacionPeso.TabIndex = 9;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(375, 70);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(73, 20);
            this.txtEuroAPeso.TabIndex = 12;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(284, 70);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(73, 20);
            this.txtEuroADolar.TabIndex = 11;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(196, 70);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(73, 20);
            this.txtEuroAEuro.TabIndex = 10;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(375, 96);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(73, 20);
            this.txtDolarAPeso.TabIndex = 15;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(284, 96);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(73, 20);
            this.txtDolarADolar.TabIndex = 14;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(196, 96);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(73, 20);
            this.txtDolarAEuro.TabIndex = 13;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(375, 126);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(73, 20);
            this.txtPesoAPeso.TabIndex = 18;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(284, 126);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(73, 20);
            this.txtPesoADolar.TabIndex = 17;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(196, 126);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(73, 20);
            this.txtPesoAEuro.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(55, 126);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(73, 20);
            this.txtPeso.TabIndex = 21;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(55, 97);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(73, 20);
            this.txtDolar.TabIndex = 20;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(55, 70);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(73, 20);
            this.txtEuro.TabIndex = 19;
            this.txtEuro.Leave += new System.EventHandler(this.txtEuro_Leave);
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(134, 5);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(56, 39);
            this.btnLockCotizacion.TabIndex = 22;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "po.png");
            this.imageList1.Images.SetKeyName(1, "pc.png");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(140, 70);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(44, 20);
            this.btnConvertEuro.TabIndex = 23;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(140, 97);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(44, 20);
            this.btnConvertDolar.TabIndex = 24;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(140, 126);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(44, 20);
            this.btnConvertPeso.TabIndex = 25;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 157);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblEuroA;
    private System.Windows.Forms.Label lblDolarA;
    private System.Windows.Forms.Label lblPesoA;
    private System.Windows.Forms.Label lblEuro;
    private System.Windows.Forms.Label lblDolar;
    private System.Windows.Forms.Label lblPeso;
    private System.Windows.Forms.TextBox txtCotizacionEuro;
    private System.Windows.Forms.TextBox txtCotizacionDolar;
    private System.Windows.Forms.TextBox txtCotizacionPeso;
    private System.Windows.Forms.TextBox txtEuroAPeso;
    private System.Windows.Forms.TextBox txtEuroADolar;
    private System.Windows.Forms.TextBox txtEuroAEuro;
    private System.Windows.Forms.TextBox txtDolarAPeso;
    private System.Windows.Forms.TextBox txtDolarADolar;
    private System.Windows.Forms.TextBox txtDolarAEuro;
    private System.Windows.Forms.TextBox txtPesoAPeso;
    private System.Windows.Forms.TextBox txtPesoADolar;
    private System.Windows.Forms.TextBox txtPesoAEuro;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.TextBox txtDolar;
    private System.Windows.Forms.TextBox txtEuro;
    private System.Windows.Forms.Button btnLockCotizacion;
    private System.Windows.Forms.Button btnConvertEuro;
    private System.Windows.Forms.Button btnConvertDolar;
    private System.Windows.Forms.Button btnConvertPeso;
    private System.Windows.Forms.ImageList imageList1;
  }
}

