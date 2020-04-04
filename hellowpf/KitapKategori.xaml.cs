using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for KitapKategori.xaml
	/// </summary>
	public partial class KitapKategori : Page
	{
		public KitapKategori()
		{
			InitializeComponent();
		}

		private void Btnara(object sender, RoutedEventArgs e)
		{

		}

		private void Btnuyegirisi(object sender, RoutedEventArgs e)
		{
			this.Content = new uyelik();
		}

		private void Btnsepet(object sender, RoutedEventArgs e)
		{

		}

		private void Btngetcategories(object sender, RoutedEventArgs e)
		{

		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			DispatcherTimer dt = new DispatcherTimer();
			for(int i=0; i<5; i++)
			{

			}
			dt.Interval = TimeSpan.FromSeconds(10);
			dt.Tick += dtTicker;
			dt.Start();
		}
		private void dtTicker(object sender,EventArgs e)
		{
			ticker.Content = "EVDE HAYAT VAR!";
			ticker.Background = Brushes.Orange;
		}

		private void edebiyatkategori(object sender, RoutedEventArgs e)
		{
			EdebiyatKategori ek = new EdebiyatKategori();
			this.NavigationService.Navigate(ek);

			

			//this.Content = new EdebiyatKategori();

			//NavigationService nav = NavigationService.GetNavigationService(this);
			//nav.Navigate(new Uri("EdebiyatKategori.xaml", UriKind.RelativeOrAbsolute));
		}

	}
}
