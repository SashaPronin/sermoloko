namespace sirmoloko;

public class CommonPage : ContentPage
{
	public CommonPage()
    {
        Title = "Common";
        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Image image = new Image { Source = "https://w7.pngwing.com/pngs/17/33/png-transparent-cooked-crackers-pizza-grated-cheese-processed-cheese-cheese-s-food-baking-recipe-thumbnail.png" };
        Label label = new Label { Text = "простокваштно" };
        //  переход с обычной страницы назад
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, image, backButton } };
    }
}