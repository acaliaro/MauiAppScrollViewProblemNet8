namespace MauiAppScrollViewProblemNet8
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Message", "tapped", "Ok");
        }
    }

}
