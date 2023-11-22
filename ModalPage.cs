namespace sirmoloko;

public class ModalPage : ContentPage
{
    public ModalPage()
    {
        Title = "Modal";

        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        backButton.Clicked += async (sender, e) => await Navigation.PopModalAsync();

        Image image = new Image { Source = "https://w7.pngwing.com/pngs/753/248/png-transparent-raw-meats-beefsteak-rump-steak-meat-raw-meat-food-beef-roast-beef-thumbnail.png" };
        Label label = new Label { Text = "сыр" };
        Content = new StackLayout
        {
            Children = { label,image, backButton }
        };
    }
}