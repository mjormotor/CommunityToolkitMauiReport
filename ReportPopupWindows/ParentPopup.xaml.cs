using CommunityToolkit.Maui.Views;

namespace ReportPopupWindows;

public partial class ParentPopup : Popup
{
	public ParentPopup()
	{
		InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        // before popup undismissable child, make this also undismissable
        CanBeDismissedByTappingOutsideOfPopup = false;

        await Shell.Current.CurrentPage.ShowPopupAsync(new ChildPopup());

        // now restore this dismissable
        CanBeDismissedByTappingOutsideOfPopup = true;
    }
}