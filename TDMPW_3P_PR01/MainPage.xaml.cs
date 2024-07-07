namespace TDMPW_3P_PR01;
using Microsoft.Maui.Graphics;
using System.Runtime.Intrinsics.X86;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnFondo_Clicked(object sender, EventArgs e){
		int i = 1;
		Random random = new Random();

		var startColor = Color.FromRgb(
			random.Next(0,256),
			random.Next(0,256),
			random.Next(0,256));

		var endColor = Color.FromRgb(
			random.Next(0,256),
			random.Next(0,256),
			random.Next(0,256));


		//Generar los stops
		var colors = GetColorGradient(startColor, endColor, 6);
		var stops = new GradientStopCollection();
		foreach (var c in colors){
			stops.Add(new GradientStop(c,(float)(i-1)/5));
			i++;
		}
		var gradient = new LinearGradientBrush(stops){
			StartPoint = new Point(0,0),
			EndPoint = new Point(1,1)
		};

		gridBG.Background = gradient;
		Console.WriteLine("Holis");

        int imagen = random.Next(1, 7);
        int frase = random.Next(1, 10);

        switch (imagen)
        {
            case 1:
                imageChange.Source = ImageSource.FromFile("img1.png");
                break;

            case 2:
                imageChange.Source = ImageSource.FromFile("img2.png");
                break;

            case 3:
                imageChange.Source = ImageSource.FromFile("img3.png");
                break;

            case 4:
                imageChange.Source = ImageSource.FromFile("img4.png");
                break;

            case 5:
                imageChange.Source = ImageSource.FromFile("img5.png");
                break;

            case 6:
                imageChange.Source = ImageSource.FromFile("img6.png");
                break;

            default:
                imageChange.Source = ImageSource.FromFile("img1.png");
                break;
        }

        switch (frase)
        {
            case 1:
                fraseChange.Text = "Casi no dormí, así que hoy elegí el camino de la violencia";
                break;

            case 2:
                fraseChange.Text = "No entiendo la vida, pero sigo aqui porque me gusta comer";
                break;

            case 3:
                fraseChange.Text = "O lo pienso y sobrepienso, o me vale verga";
                break;

            case 4:
                fraseChange.Text = "No quiero jugar más a la universidad";
                break;

            case 5:
                fraseChange.Text = "La vida es Tronchatoro y yo la de las trenzas";
                break;

            case 6:
                fraseChange.Text = "No renuncies a tus sueños, sigue durmiendo";
                break;

            case 7:
                fraseChange.Text = "El chocolate no resolverá tus problemas, pero tampoco una manzana";
                break;

            case 8:
                fraseChange.Text = "A veces, lo más bonito de la vida es lo más simple";
                break;

            case 9:
                fraseChange.Text = "No soy pesimista, soy un optimista informado";
                break;

            default:
                fraseChange.Text = "Casi no dormí, así que hoy elegí el camino de la violencia";
                break;
        }

    }

    private List<Color> GetColorGradient(Color start, Color end, int steps)
    {
        var colorList = new List<Color>();
        for (int i = 0; i < steps; i++)
        {
            float ratio = (float)i / (steps - 1);
            int r = (int)(start.Red * 255 + (end.Red * 255 - start.Red * 255) * ratio);
            int g = (int)(start.Green * 255 + (end.Green * 255 - start.Green * 255) * ratio);
            int b = (int)(start.Blue * 255 + (end.Blue * 255 - start.Blue * 255) * ratio);
            colorList.Add(Color.FromRgb(r, g, b));
        }
        return colorList;
    }

}

