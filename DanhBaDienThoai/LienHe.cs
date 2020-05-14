using System;
using System.ComponentModel;

namespace DanhBaDienThoai
{
	public class LienHe
	{

		public int ID { get; set; }
		[DisplayName("Họ tên")]
		public string Hoten { get; set; }
		[DisplayName("Biệt danh")]
		public string BietDanh { get; set; }
		[DisplayName("Ngày sinh")]
		public DateTime? NgaySinh { get; set; }
		[DisplayName("Số điện thoại")]
		public string SoDienThoai { get; set; }
		public string Email { get; set; }
		[DisplayName("Địa chỉ")]
		public string DiaChi { get; set; }

		public LienHe()
		{

		}

		public LienHe(string hoten, string bietDanh, DateTime? ngaySinh, string soDienThoai, string email, string diaChi)
		{
			Hoten = hoten;
			BietDanh = bietDanh;
			NgaySinh = ngaySinh;
			SoDienThoai = soDienThoai;
			Email = email;
			DiaChi = diaChi;
		}

		public LienHe(int iD, string hoten, string bietDanh, DateTime? ngaySinh, string soDienThoai, string email, string diaChi)
		{
			ID = iD;
			Hoten = hoten;
			BietDanh = bietDanh;
			NgaySinh = ngaySinh;
			SoDienThoai = soDienThoai;
			Email = email;
			DiaChi = diaChi;
		}

	}
}
