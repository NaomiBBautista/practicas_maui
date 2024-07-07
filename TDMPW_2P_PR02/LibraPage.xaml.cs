namespace TDMPW_2P_PR02;

public partial class LibraPage : ContentPage
{
	double librita = 0;
	public LibraPage()
	{
		InitializeComponent();
	}

	private void calcularLibra(object sender, EventArgs e)
	{
		librita = double.Parse(this.txtLibra.Text) * 0.047;
		this.txtResultadoLibra.Text = "Resultado = " + librita.ToString() + " GBP(£)";
	}
}