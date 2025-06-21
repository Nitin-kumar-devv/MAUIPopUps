using CommunityToolkit.Maui.Views;
using MauiAppPopUpProject.Models;

namespace MauiAppPopUpProject.views;

public partial class OcassionPopUp : Popup
{
	public OcassionPopUp()
	{
		InitializeComponent();
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        var occasion = new OccasionModel()
        {
            Date = OccasionDate.Date,
            Occasion= OccasionType.SelectedItem.ToString(),
            Notes= OccasionNotes.Text
        };
        Close(occasion);
    }
    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}