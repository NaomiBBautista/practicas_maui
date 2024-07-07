using Microsoft.Maui.Controls;

namespace TDMPW_2P_PR04;

public partial class MainPage : TabbedPage
{
	private double monto = 0;
	private double montoEnvio = 0;
	private double montoIva = 0;
	double iva = 0;

	public MainPage()
	{
		InitializeComponent();		
	}

	private void asignarMonto(object sender, TextChangedEventArgs e)
	{
		if(!string.IsNullOrEmpty(txtTotal.Text)){
			monto = double.Parse(txtTotal.Text);
			txtIVA.Text = "$  0.00";
			if(monto == 0){
				txtEnvio.Text =  "$  0.00";
			}
			else if(monto <= 100){
				montoEnvio = monto + 200;
				txtEnvio.Text =  "$200.00";
				txtMonto.Text = "$" + montoEnvio.ToString() + ".00";
			} 
			else if(monto > 100 && monto <= 300){
				montoEnvio = monto + 100;
				txtEnvio.Text =  "$100.00";
				txtMonto.Text = "$" + montoEnvio.ToString() + ".00";
			}
			else if(monto > 300){
				montoEnvio = monto + 0;
				txtEnvio.Text =  "$  0.00";
				txtMonto.Text = "$" + montoEnvio.ToString() + ".00";
			}
			else
			{ 
				monto = 0;
			}
		}
		
	}

	private void agregarIVA0(object sender, EventArgs e)
	{
		iva = 0;
		montoIva = montoEnvio + iva;
		txtIVA.Text = "$  0.00";
		txtMonto.Text = "$" + montoIva.ToString("N2");
		sldIvar.Value = 0;
	}
	private void agregarIVA11(object sender, EventArgs e)
	{
		iva = monto * 0.11;
		montoIva = montoEnvio + iva;
		txtIVA.Text = "$ " + iva.ToString("N2");
		txtMonto.Text = "$" + montoIva.ToString("N2");
		sldIvar.Value = 11;
		
	}
	private void agregarIVA16(object sender, EventArgs e)
	{
		iva = monto * 0.16;
		montoIva = montoEnvio + iva;
		txtIVA.Text = "$ " + iva.ToString("N2");
		txtMonto.Text = "$" + montoIva.ToString("N2");
		sldIvar.Value = 16;
	}
}

