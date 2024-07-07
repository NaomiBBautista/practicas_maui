namespace TDMPW_1P_EX;

public partial class MainPage : TabbedPage
{
	double watt = 0;
	double joul = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void calcularWatts(object sender, EventArgs e)
	{
		watt = double.Parse(this.ampers.Text) * double.Parse(this.voltios.Text);
		this.resulWatts.Text = "Resultado: " + watt.ToString() + " P";
	}

	private void calcularJoules(object sender, EventArgs e)
	{
		joul = double.Parse(this.joules.Text) / double.Parse(this.segundos.Text);
		this.resulJoules.Text = "Resultado: " + joul.ToString() + " P";
	}

	
}

