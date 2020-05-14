using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DanhBaDienThoai
{
	public partial class fDangNhap : Form
	{
		public fDangNhap()
		{
			InitializeComponent();
		}

		private void btn_Submit_Click(object sender, EventArgs e)
		{
			string username = tb_username.Text;
			string password = tb_password.Text;
			string api = "http://danhbadienthoai.somee.com/api/taikhoan";
			if (Login(username, password, api))
			{
				fDanhBa form = new fDanhBa(username, password);
				form.Show();
				this.Hide();
			}
		}

		private static bool Login(string username, string password, string api)
		{
			var client = new RestClient(api);
			client.Authenticator = new HttpBasicAuthenticator(username, password);
			var request = new RestRequest(Method.GET);
			var response = client.Get(request);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}
