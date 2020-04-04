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

namespace hellowpf
{
	/// <summary>
	/// Interaction logic for EdebiyatKategori.xaml
	/// </summary>
	public partial class EdebiyatKategori : Page
	{
        public string[] Cins { get; set; }
        public string[] Fiyat { get; set; }
        public string[] Dil { get; set; }
        public string[] Coksatan { get; set; }

        public EdebiyatKategori()
        {
            InitializeComponent();

            Cins = new string[]
            {
                "MEDYA CİNSİ","İNCE KAPAK","CİLTLİ","CEP BOY","AYLIK","HAFTALIK"
            };
            DataContext = this;

            Fiyat = new string[]
            {
                "FİYAT","0 TL - 25 TL","25 TL - 50 TL","50 TL - 100 TL","100 TL - 250 TL","250 TL - 500 TL","500 TL VE ÜZERİ"
            };
            DataContext = this;

            Dil = new string[]
            {
                "DİL","TÜRKÇE","İNGİLİZCE","KÜRTÇE","TÜRKÇE-İNGİLİZCE","ERMENİCE","ALMANCA","TÜRKÇE-FARSÇA","TÜRKÇE-MAKEDONCA","ALMANCA-TÜRKÇE","ARAPÇA-TÜRKÇE","FARSÇA-TÜRKÇE","FRANSIZCA","RUSÇA","TÜRKÇE-ALMANCA","TÜRKÇE-ARAPÇA","TÜRKÇE-KÜRTÇE","TÜRKÇE-OSMANLICA","TÜRKÇE-YUNANCA","TÜRKÇE-İSPANYOLCA"
            };
            DataContext = this;

            Coksatan = new string[]
            {
                "AZALAN FİYAT","ARTAN FİYAT","ÇOK SATAN","YENİ","ESKİ","A-Z","Z-A","AZALAN İNDİRİM","ARTAN İNDİRİM"
            };
            DataContext = this;
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
    }

}
