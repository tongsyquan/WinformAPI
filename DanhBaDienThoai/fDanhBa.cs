using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DanhBaDienThoai
{
	public partial class fDanhBa : Form
	{
		string username;
		string password;

		public fDanhBa()
		{

			InitializeComponent();
		}
		public fDanhBa(string username, string password)
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			dt_birthday.Format = DateTimePickerFormat.Custom;
			dt_birthday.CustomFormat = "dd/MM/yyyy";
			this.username = username;
			this.password = password;
			GetAllDanhBa();
		}

		private void Binding()
		{
			tb_ID.DataBindings.Add("Text", dgv_list.DataSource, "ID");
			tb_fullname.DataBindings.Add("Text", dgv_list.DataSource, "HoTen");
			tb_nickname.DataBindings.Add("Text", dgv_list.DataSource, "BietDanh");
			dt_birthday.DataBindings.Add("Text", dgv_list.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy");
			tb_phone.DataBindings.Add("Text", dgv_list.DataSource, "SoDienThoai");
			tb_email.DataBindings.Add("Text", dgv_list.DataSource, "Email");
			tb_address.DataBindings.Add("Text", dgv_list.DataSource, "DiaChi");
		}
		private void ClearBinding()
		{
			tb_ID.DataBindings.Clear();
			tb_fullname.DataBindings.Clear();
			tb_nickname.DataBindings.Clear();
			dt_birthday.DataBindings.Clear();
			tb_phone.DataBindings.Clear();
			tb_email.DataBindings.Clear();
			tb_address.DataBindings.Clear();
		}

		public void GetAllDanhBa()
		{
			Thread thread = new Thread(() =>
			{
				GetContent("http://danhbadienthoai.somee.com/api/danhba");
				ClearBinding();
				Binding();
			});
			thread.Start();
		}

		private void GetContent(string api)
		{
			var client = new RestClient(api);
			client.Authenticator = new HttpBasicAuthenticator(username, password);
			var request = new RestRequest(Method.GET);
			var response = client.Get(request);
			string json = response.Content;
			var result = JsonConvert.DeserializeObject<List<ThongTin>>(json);
			dgv_list.DataSource = result;

		}

		private void DanhBa_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(1);
			}
		}

		private void DeleteContent(string id)
		{
			new Thread(() =>
			{
				string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/{0}", id);

				var client = new RestClient(api);
				client.Authenticator = new HttpBasicAuthenticator(username, password);
				var request = new RestRequest(Method.DELETE);
				var response = client.Delete(request);
				if (response.StatusCode == HttpStatusCode.OK)
				{
					MessageBox.Show("Xoá thành công");
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Xoá thất bại");
				}
			}).Start();

		}

		private void btn_searchHoTen_Click(object sender, EventArgs e)
		{
			string hoten = tb_searchFullname.Text;
			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/GetByName/{0}", hoten);
			new Thread(() =>
			{
				GetContent(api);
				ClearBinding();
				Binding();
			}).Start();
		}

		private void btn_searchBD_Click(object sender, EventArgs e)
		{
			string bietdanh = tb_searchNickname.Text;
			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/GetByNickname/{0}", bietdanh);
			new Thread(() =>
			{
				GetContent(api);
				ClearBinding();
				Binding();
			}).Start();
		}

		private void btn_searchID_Click(object sender, EventArgs e)
		{
			string id = tb_searchID.Text;
			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/{0}", id);
			new Thread(() =>
			{
				GetContent(api);
				ClearBinding();
				Binding();
			}).Start();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			string id = tb_ID.Text;
			DeleteContent( id);
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			string Hoten = tb_fullname.Text;
			string BietDanh = tb_nickname.Text;
			DateTime? NgaySinh = dt_birthday.Value;
			string SoDienThoai = tb_phone.Text;
			string Email = tb_email.Text;
			string DiaChi = tb_address.Text;
			if (Hoten == null)
			{
				MessageBox.Show("Không được để trống", "Thông báo");
				return;
			}
			ThongTin thongTin = new ThongTin(Hoten, BietDanh, NgaySinh, SoDienThoai, Email, DiaChi);
			Create(thongTin);
		}

		public void Create(ThongTin thongTin)
		{
			new Thread(() =>
			{
				var client = new RestClient("http://danhbadienthoai.somee.com/api/danhba");
				client.Authenticator = new HttpBasicAuthenticator(username, password);
				var request = new RestRequest(Method.POST);
				var json = JsonConvert.SerializeObject(thongTin);
				request.AddJsonBody(json, "Application/Json");
				var response = client.Post(request);
				if (response.StatusCode == HttpStatusCode.OK)
				{
					MessageBox.Show("Thêm thành công");
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Thêm thất bại");
				}
			}).Start();

		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			int id = int.Parse(tb_ID.Text);
			string Hoten = tb_fullname.Text;
			string BietDanh = tb_nickname.Text;
			DateTime? NgaySinh = dt_birthday.Value;
			string SoDienThoai = tb_phone.Text;
			string Email = tb_email.Text;
			string DiaChi = tb_address.Text;
			if (Hoten == null)
			{
				MessageBox.Show("Không được để trống", "Thông báo");
				return;
			}
			ThongTin thongTin = new ThongTin(id, Hoten, BietDanh, NgaySinh, SoDienThoai, Email, DiaChi);
			Update(thongTin);

		}

		private void Update(ThongTin thongTin)
		{
			new Thread(() =>
			{
				var client = new RestClient("http://danhbadienthoai.somee.com/api/danhba");
				client.Authenticator = new HttpBasicAuthenticator(username, password);
				var request = new RestRequest(Method.PUT);
				var json = JsonConvert.SerializeObject(thongTin);
				request.AddJsonBody(json, "Application/Json");
				var response = client.Put(request);
				if (response.StatusCode == HttpStatusCode.OK)
				{
					MessageBox.Show("Cập nhật thành công");
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Cập nhật thất bại");
				}
			}).Start();
		}

		private void btn_left_Click(object sender, EventArgs e)
		{
			int index = dgv_list.CurrentCell.RowIndex;
			if (index > 0)
			{
				index--;
				dgv_list.CurrentCell = dgv_list.Rows[index].Cells[0];

			}
		}

		private void btn_right_Click(object sender, EventArgs e)
		{
			int index = dgv_list.CurrentCell.RowIndex;
			if (index < dgv_list.RowCount - 1)
			{
				index++;
				dgv_list.CurrentCell = dgv_list.Rows[index].Cells[0];

			}
		}
	}
}
