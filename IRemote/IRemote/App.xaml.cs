﻿using Xamarin.Forms;

namespace IRemote
{

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			//Задаем ресурсы с цветами приложения, чтобы потом не путать где какой цвет
			Resources = new ResourceDictionary();
			Resources.Add("primaryDarkColor", Color.FromHex("01579B"));
			Resources.Add("primaryColor", Color.FromHex("03A9F4"));
			Resources.Add("backgroundColor", Color.FromHex("ECEFF1"));

			//
			//Создаем страницу навигации из главной страницы и указываем ей необходимые цвета
			var navigateTo = new NavigationPage(new IRemotePage());
			navigateTo.BarBackgroundColor = (Color)App.Current.Resources["primaryColor"];
			navigateTo.BackgroundColor = (Color)App.Current.Resources["backgroundColor"];
			// передаем управление на главную страницу
			MainPage = navigateTo;

		}



		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}