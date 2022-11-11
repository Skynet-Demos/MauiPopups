using CommunityToolkit.Maui.Views;
using MauiPopupsDemo.Models;

namespace MauiPopupsDemo.Views;

public partial class OccasionPopup : Popup
{
	public OccasionPopup()
	{
		InitializeComponent();
	}

	private void CancelButton_Clicked(object sender, EventArgs e)
	{
		Close();
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		OccasionModel occasion = new OccasionModel
		{
			Date = OccasionDate.Date,
			Occasion = OccasionType.SelectedItem.ToString(),
			Notes = OccasionNotes.Text
		};

		Close(occasion);
	}
}