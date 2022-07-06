using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gbooks
{
    public partial class MainWindow : DevExpress.XtraEditors.XtraForm
    {
        public MainWindow()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.MainNativeMDIView.QueryControl += MainNativeMDIView_QueryControl;
        }

        void MainNativeMDIView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == homeDocument)
                e.Control = new gbooks.Views.Home();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}
