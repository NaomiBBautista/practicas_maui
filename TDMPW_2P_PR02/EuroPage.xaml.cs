namespace TDMPW_2P_PR02;

public partial class EuroPage : ContentPage
{
	double eurito = 0;
	public EuroPage()
	{
		InitializeComponent();
	}

	private void calcularEuro(object sender, EventArgs e)
	{
		eurito = double.Parse(this.txtEuro.Text) * 0.054;
		this.txtResultadoEuro.Text = "Resultado = " + eurito.ToString() + " EUR(€)";
	}
}