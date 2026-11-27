using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT MaTK, HoTen, MatKhau, VaiTro
                       FROM TaiKhoan
                       WHERE TenDangNhap = @TenDangNhap
                       AND TrangThai = 1";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string matKhauDB = reader["MatKhau"].ToString();
                            string vaiTroDB = reader["VaiTro"].ToString();

                            if (matKhau != matKhauDB)
                            {
                                MessageBox.Show(
                                    "Mật khẩu không chính xác! Vui lòng nhập lại.",
                                    "Thông báo đăng nhập",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                txtMatKhau.Clear();
                                txtMatKhau.Focus();
                                return;
                            }

                            if (cboVaiTro.Text != vaiTroDB)
                            {
                                MessageBox.Show(
                                    "Loại tài khoản không chính xác!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            int maTK = Convert.ToInt32(reader["MaTK"]);
                            string hoTen = reader["HoTen"].ToString();

                            MessageBox.Show(
                                "Đăng nhập thành công! Xin chào " + hoTen,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy tài khoản đăng nhập!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
    }
    }
}
