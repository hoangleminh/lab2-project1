using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            btnNEXT.Visible = false;
            btnIGNORE.Visible = false;
        }

        private void Quanly_Click(object sender, EventArgs e)
        {
            btnNEXT.Visible = false;
            btnIGNORE.Visible = false;
            if (!PanelThaotac.Controls.Contains(QUANLY2.Instance))
            {
                PanelThaotac.Controls.Add(QUANLY2.Instance);
                QUANLY2.Instance.Dock = DockStyle.Fill;
                QUANLY2.Instance.BringToFront();
            }
            else
            {
                QUANLY2.Instance.BringToFront();
            }
        }

        private void Thongtin_Click(object sender, EventArgs e)
        {
            btnNEXT.Visible = false;
            btnIGNORE.Visible = false;
            if (!PanelThaotac.Controls.Contains(THONGTIN.Instance))
            {
                PanelThaotac.Controls.Add(THONGTIN.Instance);
                THONGTIN.Instance.Dock = DockStyle.Fill;
                THONGTIN.Instance.BringToFront();
            }
            else
            {
                THONGTIN.Instance.BringToFront();
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            LOGIN frm1 = new LOGIN();
            frm1.Show();
            this.Close();
        }

        private void Huongdan_Click(object sender, EventArgs e)
        {
            btnNEXT.Visible = true;
            if (!PanelThaotac.Controls.Contains(HDmodule1.Instance))
            {
                PanelThaotac.Controls.Add(HDmodule1.Instance);
                HDmodule1.Instance.Dock = DockStyle.Fill;
                HDmodule1.Instance.BringToFront();
            }
            else
            {
                HDmodule1.Instance.BringToFront();
            }
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            btnNEXT.Visible = false;
            btnIGNORE.Visible = true;
            if (!PanelThaotac.Controls.Contains(HDmodule2.Instance))
            {
                PanelThaotac.Controls.Add(HDmodule2.Instance);
                HDmodule2.Instance.Dock = DockStyle.Fill;
                HDmodule2.Instance.BringToFront();
            }
            else
            {
                HDmodule2.Instance.BringToFront();
            }
        }

        private void btnIGNORE_Click(object sender, EventArgs e)
        {
            btnNEXT.Visible = false;
            btnIGNORE.Visible = false;
            if (!PanelThaotac.Controls.Contains(QUANLY2.Instance))
            {
                PanelThaotac.Controls.Add(QUANLY2.Instance);
                QUANLY2.Instance.Dock = DockStyle.Fill;
                QUANLY2.Instance.BringToFront();
            }
            else
            {
                QUANLY2.Instance.BringToFront();
            }
        }
    }
}
