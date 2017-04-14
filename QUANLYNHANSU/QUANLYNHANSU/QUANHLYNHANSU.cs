
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUANLYNHANSU
{
    public partial class QUANLY2 : UserControl
    {
        private static QUANLY2 _instance;
        public static QUANLY2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QUANLY2();
                return _instance;
            }
        }

        
        public QUANLY2()
        {
            InitializeComponent();
            comNATIVE2.Items.Add("An Giang");
            comNATIVE2.Items.Add("Bà Rịa - Vũng Tàu");
            comNATIVE2.Items.Add("Bắc Giang");
            comNATIVE2.Items.Add("Bắc Cạn");
            comNATIVE2.Items.Add("Bạc Liêu");
            comNATIVE2.Items.Add("Bắc Ninh");
            comNATIVE2.Items.Add("Bến Tre");
            comNATIVE2.Items.Add("Bình Định");
            comNATIVE2.Items.Add("Bình Dương");
            comNATIVE2.Items.Add("Bình Phước");
            comNATIVE2.Items.Add("Bình Thuận");
            comNATIVE2.Items.Add("Cà Mau");
            comNATIVE2.Items.Add("Cao Bằng");
            comNATIVE2.Items.Add("Đăk Lăk");
            comNATIVE2.Items.Add("Đăk Nông");
            comNATIVE2.Items.Add("Điện Biên");
            comNATIVE2.Items.Add("Đồng Nai");
            comNATIVE2.Items.Add("Đồng Tháp");
            comNATIVE2.Items.Add("Gia Lai");
            comNATIVE2.Items.Add("Hà Giang");
            comNATIVE2.Items.Add("Hà Nam");
            comNATIVE2.Items.Add("Hà Tĩnh");
            comNATIVE2.Items.Add("Hải Dương");
            comNATIVE2.Items.Add("Hậu Giang");
            comNATIVE2.Items.Add("Hòa Bình");
            comNATIVE2.Items.Add("Hưng Yên");
            comNATIVE2.Items.Add("Khánh Hòa");
            comNATIVE2.Items.Add("Kiên Giang");
            comNATIVE2.Items.Add("Kon Tum");
            comNATIVE2.Items.Add("Lai Châu");
            comNATIVE2.Items.Add("Lâm Đồng");
            comNATIVE2.Items.Add("Lạng Sơn");
            comNATIVE2.Items.Add("Lào Cai");
            comNATIVE2.Items.Add("Long An");
            comNATIVE2.Items.Add("Nam Định");
            comNATIVE2.Items.Add("Nghệ An");
            comNATIVE2.Items.Add("Ninh Bình");
            comNATIVE2.Items.Add("Ninh Thuận");
            comNATIVE2.Items.Add("Phú Thọ");
            comNATIVE2.Items.Add("Quảng Bình");
            comNATIVE2.Items.Add("Quảng Nam");
            comNATIVE2.Items.Add("Quảng Ngãi");
            comNATIVE2.Items.Add("Quảng Ninh");
            comNATIVE2.Items.Add("Quảng Trị");
            comNATIVE2.Items.Add("Sóc Trăng");
            comNATIVE2.Items.Add("Sơn La");
            comNATIVE2.Items.Add("Tây Ninh");
            comNATIVE2.Items.Add("Thái Bình");
            comNATIVE2.Items.Add("Thái Nguyên");
            comNATIVE2.Items.Add("Thanh Hóa");
            comNATIVE2.Items.Add("Thừa Thiên Huế");
            comNATIVE2.Items.Add("Tiền Giang");
            comNATIVE2.Items.Add("Trà Vinh");
            comNATIVE2.Items.Add("Tuyên Quang");
            comNATIVE2.Items.Add("Vĩnh Long");
            comNATIVE2.Items.Add("Vĩnh Phúc");
            comNATIVE2.Items.Add("Yên Bái");
            comNATIVE2.Items.Add("Phú Yên");
            comNATIVE2.Items.Add("Cần Thơ");
            comNATIVE2.Items.Add("Đà Nẵng");
            comNATIVE2.Items.Add("Hải Phòng");
            comNATIVE2.Items.Add("Hà Nội");
            comNATIVE2.Items.Add("TP HCM");
            comSEX2.Items.Add("Nam");
            comSEX2.Items.Add("Nữ");
        }

        KetnoiCSDL kn = new KetnoiCSDL();

        private void QUANLY2_Load(object sender, EventArgs e)
        {
            loadForm();
            loadTextbox();
        }

        private void loadTextbox()
        {
            txtNAME.DataBindings.Clear();
            txtNAME.DataBindings.Add("Text", dGVNHANSU.DataSource, "ten");
            dTPNGAYSINH2.DataBindings.Clear();
            dTPNGAYSINH2.DataBindings.Add("Text", dGVNHANSU.DataSource, "ngaysinh");
            comSEX2.DataBindings.Clear();
            comSEX2.DataBindings.Add("Text", dGVNHANSU.DataSource, "gioitinh");
            comNATIVE2.DataBindings.Clear();
            comNATIVE2.DataBindings.Add("Text", dGVNHANSU.DataSource, "quequan");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dGVNHANSU.DataSource, "sdt");
            txtMASO.DataBindings.Clear();
            txtMASO.DataBindings.Add("Text", dGVNHANSU.DataSource, "maso");
        }

        private void loadForm()
        {
            kn.loadNHANSU(this.dGVNHANSU);
        }

        bool kt = true;
        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (txtMASO.Text.Trim() != "")
            {
                if (kt)
                {
                    string ten = txtNAME.Text.Trim();
                    DateTime ngaysinh = DateTime.Parse(dTPNGAYSINH2.Value.ToString());
                    string gioitinh = comSEX2.Text.Trim();
                    string quequan = comNATIVE2.Text.Trim();
                    string sdt = txtSDT.Text.Trim();
                    string maso = txtMASO.Text.Trim();

                    kn.suaNHANSU(ten, maso, quequan, ngaysinh, gioitinh, sdt);
                    loadForm();
                    loadTextbox();
                    MessageBox.Show("Lưu thành công", "THÔNG BÁO");
                }
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa " + txtNAME.Text + "?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maso = txtMASO.Text.Trim();
                kn.xoaNHANSU(maso);
                loadTextbox();
                loadForm();
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string ten = txtNAME.Text.Trim();
            DateTime ngaysinh = DateTime.Parse(dTPNGAYSINH2.Value.ToString());
            string gioitinh = comSEX2.Text.Trim();
            string quequan = comNATIVE2.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string maso = txtMASO.Text.Trim();

            if (txtMASO.Text.Trim() != "")
            {
                kn.themNHANSU(ten, maso, quequan, ngaysinh, gioitinh, sdt);
                MessageBox.Show("Đã thêm thành công", "THÔNG BÁO");
                loadTextbox();
                loadForm();
            }
        }

        private void dGVNHANSU_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dGVNHANSU.RowCount; i++)
            {
                dGVNHANSU[0, i].Value = i + 1;
            }
        }

    }
}
