namespace TDMPW_2P_PR02;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();
		this.flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
	}
	private void OnSelectionChanged(object sender, SelectionChangedEventArgs e){
		var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
		if (item != null){
			Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
			IsPresented = true;
		}
	}
}