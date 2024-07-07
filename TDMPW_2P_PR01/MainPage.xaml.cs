namespace TDMPW_2P_PR01;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void meGusta(object sender, EventArgs e)
	{
		this.txtOpinion.Text = "Me encantó este personaje :)";
	}

	private void noGusta(object sender, EventArgs e)
	{
		this.txtOpinion.Text = "No me gustó este personaje :(";
	}
	private void meGusta1(object sender, EventArgs e)
	{
		this.txtOpinion1.Text = "Me encantó este personaje :)";
	}

	private void noGusta1(object sender, EventArgs e)
	{
		this.txtOpinion1.Text = "No me gustó este personaje :(";
	}
}

