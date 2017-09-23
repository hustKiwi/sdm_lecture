using Xamarin.Forms;

namespace ImagesDemo
{
    public partial class ImagesDemoPage : ContentPage
    {
        public ImagesDemoPage()
        {
            InitializeComponent();
            btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
        }
    }
}