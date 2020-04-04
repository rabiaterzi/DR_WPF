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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for kitap_kategori.xaml
	/// </summary>
	public partial class kitap_kategori : Window
	{
		public kitap_kategori()
		{
			InitializeComponent();
			if (this.WindowState == System.Windows.WindowState.Normal)
			{
				this.WindowState = System.Windows.WindowState.Maximized;
			}
			else
			{
				this.WindowState = System.Windows.WindowState.Normal;
			}
		}
		private void Btnara(object sender, RoutedEventArgs e)
		{

		}

		private void Btnuyegirisi(object sender, RoutedEventArgs e)
		{
			uye uye_ = new uye();
			uye_.Show();
			this.Close();	
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
			for (int i = 0; i < 5; i++)
			{

			}
			dt.Interval = TimeSpan.FromSeconds(10);
			dt.Tick += dtTicker;
			dt.Start();
		}
		private void dtTicker(object sender, EventArgs e)
		{
			ticker.Content = "EVDE HAYAT VAR!";
			ticker.Background = Brushes.Orange;
		}

		private void edebiyatkategori(object sender, RoutedEventArgs e)
		{
			edebiyat_kategori edebiyat = new edebiyat_kategori();
			edebiyat.Show();
			this.Close();	
		}

		private void anasayfa(object sender, RoutedEventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			this.Close();
		}
	}
}
