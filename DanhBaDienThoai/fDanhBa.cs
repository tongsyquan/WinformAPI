using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DanhBaDienThoai
{
	public partial class fDanhBa : Form
	{
		private string username;
		private string password;

		public fDanhBa(string username, string password)
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
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

		private void GetAllDanhBa()
		{
			GetContent("http://danhbadienthoai.somee.com/api/danhba");
		}

		private void GetContent(string api)
		{
			new Thread(() =>
			{
				var client = new RestClient(api);
				client.Authenticator = new HttpBasicAuthenticator(username, password);
				var request = new RestRequest(Method.GET);
				var response = client.Get(request);
				string json = response.Content;
				var result = JsonConvert.DeserializeObject<List<LienHe>>(json);
				dgv_list.DataSource = null;
				dgv_list.DataSource = new BindingList<LienHe>(result);
				ClearBinding();
				Binding();
			}).Start();
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
					MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}).Start();
		}

		private void btn_searchHoTen_Click(object sender, EventArgs e)
		{
			string hoten = tb_searchFullname.Text;
			if (hoten == null)
			{
				MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/GetByName/{0}", hoten);
			GetContent(api);
		}

		private void btn_searchBD_Click(object sender, EventArgs e)
		{
			string bietdanh = tb_searchNickname.Text;
			if (bietdanh == null)
			{
				MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/GetByNickname/{0}", bietdanh);
			GetContent(api);
		}

		private void btn_searchID_Click(object sender, EventArgs e)
		{
			string id = tb_searchID.Text;
			if (id == null)
			{
				MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string api = string.Format("http://danhbadienthoai.somee.com/api/DanhBa/{0}", id);
			GetContent(api);
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			string id = tb_ID.Text;
			DeleteContent(id);
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				string Hoten = tb_fullname.Text;
				string BietDanh = tb_nickname.Text;
				DateTime? NgaySinh = dt_birthday.Value;
				string SoDienThoai = tb_phone.Text;
				string Email = tb_email.Text;
				string DiaChi = tb_address.Text;
				if (Hoten == null)
				{
					MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				LienHe thongTin = new LienHe(Hoten, BietDanh, NgaySinh, SoDienThoai, Email, DiaChi);
				Create(thongTin);
			}).Start();
		}

		private void Create(LienHe thongTin)
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
					MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			LienHe thongTin = new LienHe(id, Hoten, BietDanh, NgaySinh, SoDienThoai, Email, DiaChi);
			Update(thongTin);
		}

		private void Update(LienHe thongTin)
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
					MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetAllDanhBa();
				}
				else
				{
					MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
