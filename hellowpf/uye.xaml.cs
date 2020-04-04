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

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for uye.xaml
	/// </summary>
	public partial class uye : Window
	{
		public uye()
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
		private void Btngetcategories(object sender, RoutedEventArgs e)
		{

		}

		private void Btnara(object sender, RoutedEventArgs e)
		{

		}

		private void Btnuyegirisi(object sender, RoutedEventArgs e)
		{

		}

		private void Btnsepet(object sender, RoutedEventArgs e)
		{

		}

		private void anasayfa(object sender, RoutedEventArgs e)
		{

		}
	}
}
