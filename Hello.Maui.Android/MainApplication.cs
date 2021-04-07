using System;
using Android.App;
using Android.Runtime;
using HelloMaui;
using Microsoft.Maui;

namespace Hello.Maui.Android
{
	[Application]
	public class MainApplication : MauiApplication<Startup>
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
		{
		}
	}
}
