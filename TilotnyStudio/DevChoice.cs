using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TilotnyStudio
{
    public partial class DevChoice : Form
    {
        public string basepath;
        public List<string> args = new List<string>();
        public bool allplanet = false;

        public DevChoice()
        {
            InitializeComponent();
        }
        private void TRbutton_Click(object sender, EventArgs e)
        {
            args.Add(Path.Combine(basepath, "TR", "Data"));
            args.Add(Path.Combine(basepath, "CoreSaga", "Data"));
            args.Add(Path.Combine(basepath, "Data"));
            allplanet = PlanetsCheckBox.Checked;
            this.Close();
        }
        private void FotRbutton_Click(object sender, EventArgs e)
        {
            args.Add(Path.Combine(basepath, "FotR", "Data"));
            args.Add(Path.Combine(basepath, "CoreSaga", "Data"));
            args.Add(Path.Combine(basepath, "Data"));
            allplanet = PlanetsCheckBox.Checked;
            this.Close();
        }
        private void Revbutton_Click(object sender, EventArgs e)
        {
            args.Add(Path.Combine(basepath, "Rev", "Data"));
            args.Add(Path.Combine(basepath, "Data"));
            allplanet = PlanetsCheckBox.Checked;
            this.Close();
        }
    }
}
