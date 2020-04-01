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

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			/*this.AutoScroll = true;
			this.HorizontalScroll.Enabled = true;
			this.HorizontalScroll.Visible = true;
			this.VerticalScroll.Enabled = true;
			this.VerticalScroll.Visible = true;*/
			
		}

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
			/*WrapPanel wrapPanel = new WrapPanel();
			wrapPanel.Name = "wrappanel";
			wrapPanel.Height = 370;
			wrapPanel.Width = 1600;
			wrapPanel.Margin = new Thickness(0,0,0,200);
			//wrapPanel.Margin = ;
		for(int i=0;i<14;i++)
			{
				StackPanel stackPanel = new StackPanel();
				stackPanel.Name = "stackpanel" + (i + 1).ToString();
			}
			StackPanel stackPanel = new StackPanel();
			stackPanel.Height = 150;
			stackPanel.Width = 200;
			Image image = new Image();
			//image.Source = https://www.iconfinder.com/icons/3366896/book_learning_student_icon;			
			Label kitap = new Label();
			kitap.Content = "Kitap";
			kitap.FontSize = 25;
			stackPanel.Children.Add(kitap);
			StackPanel stackPanel2 = new StackPanel();
			StackPanel stackPane3 = new StackPanel();
			StackPanel stackPanel4 = new StackPanel();
			StackPanel stackPanel5= new StackPanel();
			StackPanel stackPanel6= new StackPanel();
			StackPanel stackPanel7 = new StackPanel();
			StackPanel stackPanel8 = new StackPanel();
			StackPanel stackPanel9 = new StackPanel();
			StackPanel stackPanel10 = new StackPanel();
			StackPanel stackPanel11= new StackPanel();
			StackPanel stackPanel12 = new StackPanel();
			StackPanel stackPanel13 = new StackPanel();
			StackPanel stackPanel14 = new StackPanel();
			
			wrapPanel.Children.Add(stackPanel);
			//this.Content = wrapPanel;
			//this.AddChild(wrapPanel);					
			//wrapPanel.Visibility = Visibility.Visible;*/
			
			
			
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
		    
		}

		private void Btnuyegirisi(object sender, RoutedEventArgs e)
		{
			uyelik uye = new uyelik();
			this.Visibility = Visibility.Hidden;
			uye.Show();
		}

		private void Btnsepet(object sender, RoutedEventArgs e)
		{

		}

		private void Btnara(object sender, RoutedEventArgs e)
		{

		}
		/*<WrapPanel Height = "300" Width="1600">
									<StackPanel>
										<MenuItem Header = "_kitap" >
											< MenuItem.Icon >
												< Image Source="https://www.iconfinder.com/icons/3366896/book_learning_student_icon"/>
											</MenuItem.Icon>
								        </MenuItem>
									</StackPanel>
									<StackPanel>
										<MenuItem Header = "_E - Kitap" ></ MenuItem >
									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >
									< StackPanel >

									</ StackPanel >



								</ WrapPanel >*/


	}
}
