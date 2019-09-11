using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace FormBilletes
{
  public partial class Form1 : Form
  {
    private bool editarCotizaciones = false;
    Euro euros = new Euro(0);
    Dolar dolares = new Dolar(0);
    Pesos pesos = new Pesos(0);

    public Form1()
    {
      InitializeComponent();
      this.btnLockCotizacion_Click(null, null);
    }

    private void btnLockCotizacion_Click(object sender, EventArgs e)
    {
      txtCotizacionEuro.Enabled = editarCotizaciones;
      txtCotizacionDolar.Enabled = editarCotizaciones;
      txtCotizacionPeso.Enabled = editarCotizaciones;

      if (editarCotizaciones)
      {
        editarCotizaciones = false;
        btnLockCotizacion.ImageIndex = 1;
      }
      else
      {
        editarCotizaciones = true;
        btnLockCotizacion.ImageIndex = 0;
      }
    }

    private void btnConvertEuro_Click(object sender, EventArgs e)
    {
      txtEuroAEuro.Text = euros.GetCantidad().ToString();
      txtEuroADolar.Text = ((Dolar)euros).GetCantidad().ToString();
      txtEuroAPeso.Text = ((Pesos)euros).GetCantidad().ToString();
    }

    private void btnConvertDolar_Click(object sender, EventArgs e)
    {
      txtDolarAEuro.Text = ((Euro)dolares).GetCantidad().ToString();
      txtDolarADolar.Text = dolares.GetCantidad().ToString();
      txtDolarAPeso.Text = ((Pesos)dolares).GetCantidad().ToString();
    }

    private void btnConvertPeso_Click(object sender, EventArgs e)
    {

    }

    private void txtCotizacionEuro_Leave(object sender, EventArgs e)
    {
        double auxEuros;
        if (!double.TryParse(txtCotizacionEuro.Text, out auxEuros) || auxEuros<0)
        {
          txtCotizacionEuro.Focus();
        }
        else
        {
          Euro.SetCotizacion(auxEuros);
        }
    }

    private void txtCotizacionDolar_Leave(object sender, EventArgs e)
    {
        double auxDolares;
        if (!double.TryParse(txtCotizacionDolar.Text, out auxDolares) || auxDolares < 0)
        {
            txtCotizacionDolar.Focus();
        }
        else
        {
            Dolar.SetCotizacion(auxDolares);
        }
    }

    private void txtCotizacionPeso_Leave(object sender, EventArgs e)
    {
        double auxPesos;

        if (!double.TryParse(txtCotizacionPeso.Text, out auxPesos) || auxPesos < 0)
        {
            txtCotizacionPeso.Focus();
        }
        else
        {
            Pesos.SetCotizacion(auxPesos);
        }
    }

    private void txtEuro_Leave(object sender, EventArgs e)
    {
      double auxEuros;

      if (!double.TryParse(txtEuro.Text, out auxEuros) || auxEuros < 0)
      {
        txtEuro.Focus();
      }
      else
      {
        euros = auxEuros;
      }
    }

    private void txtDolar_Leave(object sender, EventArgs e)
    {
      double auxDolares;

      if (!double.TryParse(txtDolar.Text, out auxDolares) || auxDolares < 0)
      {
        txtDolar.Focus();
      }
      else
      {
        dolares = auxDolares;
      }
    }

    private void txtPeso_Leave(object sender, EventArgs e)
    {
      double auxPesos;

      if (!double.TryParse(txtPeso.Text, out auxPesos) || auxPesos < 0)
      {
        txtPeso.Focus();
      }
      else
      {
        pesos = auxPesos;
      }
    }
  }
}
