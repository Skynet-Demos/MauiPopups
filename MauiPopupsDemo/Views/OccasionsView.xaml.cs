using CommunityToolkit.Maui.Views;
using MauiPopupsDemo.Models;
using System.Collections.ObjectModel;

namespace MauiPopupsDemo.Views;

public partial class OccasionsView : ContentPage
{
	ObservableCollection<OccasionModel> Occasions;

	public OccasionsView()
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
		var popup = new OccasionPopup();

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