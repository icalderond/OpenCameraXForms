using System;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace testCamera_xforms
{
    public partial class testCamera_xformsPage : ContentPage
    {
        public testCamera_xformsPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions() { });
            if (photo != null) PhotoImage.Source = ImageSource.FromStream(photo.GetStream);
        }
    }
}
