using System;

using Xamarin.Forms;

namespace TanitaTracker.Views
{
    public class MainTabbedPage : ContentPage
    {
        public MainTabbedPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

