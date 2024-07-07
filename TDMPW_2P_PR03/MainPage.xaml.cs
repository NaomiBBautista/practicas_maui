namespace TDMPW_2P_PR03;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSliderChange1(object sender, EventArgs e)
	{
		txtH1.Text = " " + sldH1.Value.ToString("N0") + " ";
	}
	private void OnSliderChange2(object sender, EventArgs e)
	{
		txtH2.Text = " " + sldH2.Value.ToString("N0") + " ";
	}
	private void OnSliderChange3(object sender, EventArgs e)
	{
		txtH3.Text = " " + sldH3.Value.ToString("N0") + " ";
	}

	private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
		txtNombre.Text = $" {e.NewTextValue} ";
	}

	private void HobbieTextChanged(object sender, TextChangedEventArgs e)
	{
		txtHobbie.Text = $" {e.NewTextValue} ";
	}

	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		sldPuntuar.IsEnabled = mySwitch.IsToggled;
	}

	private void OnSlider(object sender, EventArgs e)
	{
		txtPuntuar.Text = " " + sldPuntuar.Value.ToString("N0") + " ";
		stpCantidad.Value = sldPuntuar.Value; 
	}

	private void OnStepper(object sender, EventArgs e)
	{
		txtPuntuar.Text = " " + stpCantidad.Value.ToString("N0") + " ";
		sldPuntuar.Value = stpCantidad.Value; 
	}
}

