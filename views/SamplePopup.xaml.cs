using CommunityToolkit.Maui.Views;

namespace MauiAppPopUpProject.views;

public partial class SamplePopup : Popup
{
	public SamplePopup()
	{
		InitializeComponent();
	}

    private void OKButton_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}