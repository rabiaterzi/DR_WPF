using System;
using System.Collections.Generic;
using System.Text;

namespace hellowpf.model
{
	public class KitapModel
	{
		public string Resim { get; set; }
		public double Puan { get; set; }
		public string KitapIsim { get; set; }
		public string YazarIsim { get; set; }
		public string CiltTipi { get; set; }
		public string Yayınevi { get; set; }
		public double IndirimsizFiyat { get; set; }
		public int Indirim { get; set; }
		public double IndirimliFiyat { get; set; }

		//public IList<KitapModel> urunler = new List<KitapModel>();
		
	}
}
