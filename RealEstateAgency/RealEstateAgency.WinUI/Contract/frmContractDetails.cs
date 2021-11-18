using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Contract
{
    public partial class frmContractDetails : Form
    {
        private Model.Contract _contract;
        public frmContractDetails(Model.Contract contract = null)
        {
            InitializeComponent();
            _contract = contract;
        }
    }
}
