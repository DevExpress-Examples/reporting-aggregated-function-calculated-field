using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AggregateFunctionCalcFieldExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.reportDesigner1.OpenReport(new TestReport());
            this.reportDesigner1.ActiveDesignPanel.SelectedTabIndex = 1;
        }
    }
}
