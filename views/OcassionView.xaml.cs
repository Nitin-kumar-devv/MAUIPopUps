using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;
using MauiAppPopUpProject.Models;
using MauiAppPopUpProject.views;

namespace MauiAppPopUpProject.Views;

public partial class OcassionView : ContentPage
{
    ObservableCollection<OccasionModel> Occasions;

    public OcassionView()
    {
        InitializeComponent();
        Occasions = new ObservableCollection<OccasionModel>();
    }

    private void SimplePopup_Clicked(object sender, EventArgs e)
    {
        var popup = new SamplePopup();

        this.ShowPopup(popup);
    }

    private async void OccasionPopup_Clicked(object sender, EventArgs e)
    {
        var popup = new OcassionPopUp();

        var result = await this.ShowPopupAsync(popup);

        if (result != null)
        {
            var occasion = (OccasionModel)result;

            if (occasion.Occasion == "Anniversary")
            {
                occasion.Image = "happy_anniversary.png";
            }
            else if (occasion.Occasion == "Birthday")
            {
                occasion.Image = "happy_birthday.png";
            }

            Occasions.Add(occasion);

            occasionsList.ItemsSource = Occasions;
        }
    }
}