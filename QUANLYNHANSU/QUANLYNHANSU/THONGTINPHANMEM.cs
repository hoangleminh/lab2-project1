using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class THONGTIN : UserControl
    {
        private static THONGTIN _instance;
        public static THONGTIN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new THONGTIN();
                return _instance;
            }
        }
        public THONGTIN()
        {
            InitializeComponent();
        }
    }
}
