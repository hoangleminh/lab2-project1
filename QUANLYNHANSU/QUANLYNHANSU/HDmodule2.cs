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
    public partial class HDmodule2 : UserControl
    {
        private static HDmodule2 _instance;
        public static HDmodule2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HDmodule2();
                return _instance;
            }
        }
        public HDmodule2()
        {
            InitializeComponent();
        }
    }
}
