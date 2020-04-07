using System;
using System.Collections.Generic;
using System.Text;
using hellowpf.model;

namespace hellowpf.viewmodel
{
	public class urunler
	{
		public urunler()
		{
			
			KitapModel kitap1 = new KitapModel();
			kitap1.Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg";
		    kitap1.Puan = 2.5;
			kitap1.KitapIsim = "Kral Şakir 8-Macera Adası!";
			kitap1.YazarIsim = "Varol Yaşaroğlu";
			kitap1.CiltTipi = "Ciltli";
			kitap1.Yayınevi = "Eksik Parça";
			kitap1.IndirimsizFiyat = 32.00;
			kitap1.Indirim = 32;
			kitap1.IndirimliFiyat = 22.40;
		}
		public List<KitapModel> _urunler = new List<KitapModel>();
		public List<KitapModel> getkitap()
		{
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat=32.00,
				Indirim=32,
				IndirimliFiyat=22.40
			});
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat = 32.00,
				Indirim = 32,
				IndirimliFiyat = 22.40
			});
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat = 32.00,
				Indirim = 32,
				IndirimliFiyat = 22.40
			});
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat = 32.00,
				Indirim = 32,
				IndirimliFiyat = 22.40
			});
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat = 32.00,
				Indirim = 32,
				IndirimliFiyat = 22.40
			});
			_urunler.Add(new KitapModel
			{
				Resim = "https://i.dr.com.tr/cache/154x170-0/originals/0001868498001-1.jpg",
				Puan = 2.5,
				KitapIsim = "Kral Şakir 8-Macera Adası!",
				YazarIsim = "Varol Yaşaroğlu",
				CiltTipi = "Ciltli",
				Yayınevi = "Eksik Parça",
				IndirimsizFiyat = 32.00,
				Indirim = 32,
				IndirimliFiyat = 22.40
			});


			return _urunler;
		}
	}
}
