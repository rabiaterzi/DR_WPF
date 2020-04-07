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
	/// Interaction logic for urunayrinti.xaml
	/// </summary>
	public partial class urunayrinti : Window
	{
		public urunayrinti()
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

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DispatcherTimer dt = new DispatcherTimer();
			dt.Interval = TimeSpan.FromSeconds(5);
			dt.Tick += dtTicker;
			dt.Start();
		}
		private void dtTicker(object sender, EventArgs e)
		{
			if (ticker.Background == Brushes.Blue)
			{
				ticker.Content = "EVDE HAYAT VAR!";
				ticker.Background = Brushes.Orange;
			}
			else if (ticker.Background == Brushes.Orange)
			{
				ticker.Content = "Yazarından İmzalı Kitapları Kaçırmayın";
				ticker.Background = Brushes.DarkRed;
			}
			else if (ticker.Background == Brushes.DarkRed)
			{
				ticker.Content = "Ön Okuma özellikli kitaplar dr.com.tr'de!..";
				ticker.Background = Brushes.Black;
			}
			else if (ticker.Background == Brushes.Black)
			{
				ticker.Content = "İndirimli Kitap Setleri";
				ticker.Background = Brushes.Maroon;
			}
			else if (ticker.Background == Brushes.Maroon)
			{
				ticker.Content = "Kral Şakir 8, satışta!";
				ticker.Background = Brushes.Blue;
			}
		}

		private void Btngetcategories(object sender, RoutedEventArgs e)
		{

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
			sepetim sepet = new sepetim();
			sepet.Show();
			this.Close();
		}

		private void anasayfa(object sender, RoutedEventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			this.Close();
		}

		private void sepeteekle(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Ürün alışveriş sepetinize eklendi");
			
		}
	}
}
