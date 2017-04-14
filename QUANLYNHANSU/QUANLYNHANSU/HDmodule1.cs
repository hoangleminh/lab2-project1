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
    public partial class HDmodule1 : UserControl
    {
        private static HDmodule1 _instance;
        public static HDmodule1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HDmodule1();
                return _instance;
            }
        }
        public HDmodule1()
        {
            InitializeComponent();
        }

    }
}
