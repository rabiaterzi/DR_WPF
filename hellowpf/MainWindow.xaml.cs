using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using hellowpf.viewmodel;

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			DataContext = this;
			InitializeComponent();
			if (this.WindowState == System.Windows.WindowState.Normal)
			{
				this.WindowState = System.Windows.WindowState.Maximized;
			}
			else
			{
				this.WindowState = System.Windows.WindowState.Normal;
			}
			Image images = new Image();
			images.Source = new BitmapImage(new Uri("https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg"));
			for (int i=0;i<7;i++)
			{

				Image image = new Image();
				image.Source = new BitmapImage(new Uri("https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg"));

			}
			
		}
		
		public static string[] Images = new string[16]
		{
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/evde-vakit-gecirme-ana-sayfa.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/turkuvaz-dergi_851x373_2.png",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/cok-satanlar-revize3-homepage.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_59_851x373_oyuncak_okazyon_lp.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/tum-kitap-kampanyalari-homepage1.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_60_851x373_elektronik_okazyon_lp.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_x_851x373_ayin_yayinevi_gunisigi.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/1019_d_u_x_851x373_lego_lp.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0220_d_u_x_851x373_haftanin_firsati_domingo.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/iletisim-kamp-homepage.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/metis-kampanya-homepage.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/evde-tekloloji.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/les-ana-sayfa.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/sudoku-homepage.jpg",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/851x373_idefix_KaradenizKiyi.png",
			@"https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/taksit-sevenekleri-yeni.jpg",
		};
		private void Btngetcategories(object sender, RoutedEventArgs e)
		{
			if(kategoriler.Width==1601)
			{
				festival.Visibility = Visibility.Hidden;
				kategoriler.Margin = new Thickness(-1400,0,0,0);
				kategoriler.Width = 1600;
			}
			else
			{
				kategoriler.Width = 1601;
				kategoriler.Margin = new Thickness(150,0,0,0);
				festival.Visibility = Visibility.Visible;
			}		
		}
		private void kitapkategori(object sender,RoutedEventArgs e)
		{
			kitap_kategori kitap = new kitap_kategori();
			kitap.Show();
			this.Close();
		}
		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
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

		private void Btnara(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var bc = new BrushConverter();
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/evde-vakit-gecirme-ana-sayfa.jpg"));
			
			if (buton1.BorderBrush== Brushes.White)
			{              
				buton1.BorderBrush = Brushes.DarkBlue;
				buton1.Background = Brushes.White;			
			}
			else
			{
				buton1.Background = (Brush)bc.ConvertFrom("#FFBAB2B2");
				buton1.BorderBrush = Brushes.White;
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/turkuvaz-dergi_851x373_2.png"));
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/cok-satanlar-revize3-homepage.jpg"));
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_59_851x373_oyuncak_okazyon_lp.jpg"));
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/tum-kitap-kampanyalari-homepage1.jpg"));
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_60_851x373_elektronik_okazyon_lp.jpg"));
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_x_851x373_ayin_yayinevi_gunisigi.jpg"));
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/1019_d_u_x_851x373_lego_lp.jpg"));
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0220_d_u_x_851x373_haftanin_firsati_domingo.jpg"));
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/iletisim-kamp-homepage.jpg"));
		}

		private void Button_Click_10(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/metis-kampanya-homepage.jpg"));
		}

		private void Button_Click_11(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/evde-tekloloji.jpg"));
			
		}

		private void Button_Click_12(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/les-ana-sayfa.jpg"));
		}

		private void Button_Click_13(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/sudoku-homepage.jpg"));
		}

		private void Button_Click_14(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/851x373_idefix_KaradenizKiyi.png"));
		}

		private void Button_Click_15(object sender, RoutedEventArgs e)
		{
			resim1.Source = new BitmapImage(new Uri("https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/taksit-sevenekleri-yeni.jpg"));
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DispatcherTimer dt = new DispatcherTimer();			
			dt.Interval = TimeSpan.FromSeconds(5);
			dt.Tick += dtTicker;
			dt.Start();

			DispatcherTimer resim = new DispatcherTimer();
			resim.Interval = TimeSpan.FromSeconds(5);
			resim.Tick += dtticker;
			resim.Start();
		}
        private int increment = 0;
		private void dtticker(object sender, EventArgs e)
		{
			if(increment==16)
			{
				increment = 0;
			}
			//Images[increment] = resim1.Source.ToString();
			resim1.Source = new BitmapImage(new Uri(Images[increment]));
			increment++;
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

		private void urunayrıntı(object sender, RoutedEventArgs e)
		{
			urunayrinti urun = new urunayrinti();
			urun.Show();
			this.Close();
		}
	}
}
