namespace TDMPW_2P_PR02;

public partial class DolarPage : ContentPage
{
	double dolarsillo = 0;
	public DolarPage()
	{
		InitializeComponent();
	}

	private void calcularDolar(object sender, EventArgs e)
	{
		dolarsillo = double.Parse(this.txtDolar.Text) * 0.059;
		this.txtResultadoDolar.Text = "Resultado = " + dolarsillo.ToString() + " USD($)";
	}
}