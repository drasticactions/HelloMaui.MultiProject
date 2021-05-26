using System;
using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace Hello.Maui
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage, IPage
	{
		public MainPage()
		{
			InitializeComponent();
			
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			var test = ImageSource.FromResource("Hello.Maui.dotnet_bot.png", typeof(MainPage).GetTypeInfo().Assembly);
			this.TestImage.Source = test;
		}

        int count = 0;
		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Current count: {count}";
		}
	}
}
