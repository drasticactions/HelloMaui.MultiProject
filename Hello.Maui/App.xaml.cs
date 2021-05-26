using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Reflection;
using Application = Microsoft.Maui.Controls.Application;

namespace Hello.Maui
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}

		protected override IWindow CreateWindow(IActivationState activationState)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

			this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
				.SetImageDirectory("Assets");

			return new Microsoft.Maui.Controls.Window(new MainPage());
		}
	}

	[ContentProperty(nameof(Source))]
	public class ImageResourceExtension : IMarkupExtension
	{
		public string Source { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Source == null)
			{
				return null;
			}

			// Do your translation lookup here, using whatever method you require
			var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

			return imageSource;
		}
	}
}
