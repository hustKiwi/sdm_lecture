using Xamarin.Forms;

namespace ImagesDemo
{
    public partial class ImagesDemoPage : ContentPage
    {
        public ImagesDemoPage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource(
                "ImagesDemo.Images.background.jpg"
            );
        }
    }
}