using CommunityToolkit.Maui.Views;

namespace ReportPopupWindows;

public partial class ChildPopup : Popup
{
	public ChildPopup()
	{
		InitializeComponent();
    }

    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        await CloseAsync();
    }
}