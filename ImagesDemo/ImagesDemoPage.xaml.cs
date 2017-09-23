using System;
using Xamarin.Forms;

namespace ImagesDemo
{
    public partial class ImagesDemoPage : ContentPage
    {
        public ImagesDemoPage()
        {
            InitializeComponent();
            var imageSource = new UriImageSource {
                Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/")
            };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }
    }
}