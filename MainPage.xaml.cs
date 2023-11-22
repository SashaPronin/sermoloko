namespace sirmoloko
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Main";

            var toCommonPageBtn = new ImageButton
            {
                Source = "https://w7.pngwing.com/pngs/645/674/png-transparent-gruyere-cheese-processed-cheese-shop-afacere-dairy-cheese-food-building-cheese-thumbnail.png",
                HorizontalOptions = LayoutOptions.Start
            };
            toCommonPageBtn.Clicked += ToCommonPage;

            var toModalPageBtn = new ImageButton
            {
                Source = "https://w7.pngwing.com/pngs/432/452/png-transparent-yellow-cheese-gruyxe8re-cheese-a-piece-of-cheese-angle-food-cheese-thumbnail.png",
                HorizontalOptions = LayoutOptions.Start
            };
            toModalPageBtn.Clicked += ToModalPage;

            Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
        }

        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }

        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonPage());
        }
    }

}
