namespace ArkToDoMaui;

public partial class Epona : ContentPage
{
	public Epona()
	{
		InitializeComponent();
	}

    private void Add_Epona_Tracker(object sender, EventArgs e)
    {
		SemanticScreenReader.Announce("Tracker added");
	}
}