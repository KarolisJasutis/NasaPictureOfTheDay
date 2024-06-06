using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektas
{
    public partial class INFO : Form
    {
        public DateTime Date { get; set; }
        NasaApi nasaapi = new NasaApi();
        PotdData PotdJson = new PotdData();
        public INFO()
        {
            InitializeComponent();
        }

        private async void INFO_Load(object sender, EventArgs e)
        {

            PotdJson = await nasaapi.GetPOTD(Date);
            lblExpl.Text = PotdJson.Explanation;
            lblType.Text = PotdJson.Title;
        }
        private void lbllink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PotdJson.Url);
        }
    }
}
