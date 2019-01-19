using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rondAlgo;

namespace testImpol
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        Calculation cal = new Calculation();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(numLength.Value);
            int width = Convert.ToInt32(numWidth.Value);
            int radius = Convert.ToInt32(numRadius.Value);
            int minTopDistance = Convert.ToInt32(numTopDistance.Value);
            int minLeftDistance = Convert.ToInt32(numLeftDistance.Value);
            int minMiddleDistance = Convert.ToInt32(numMiddleDistance.Value);

            if (length == 0 || width == 0 || radius == 0)
                MessageBox.Show("Vhodni podatki dolžine, širine in radiusa rondelic morajo biti večji od 0!",
                        "Opozorilo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
            else
            {
                List<Rond> result = cal.Calculate(length, width, radius, minTopDistance, minLeftDistance, minMiddleDistance);
                txtResult.Text = result.Count().ToString();
                lbCoordinates.Items.Clear();
                foreach (Rond _rond in result)
                    lbCoordinates.Items.Add("Koordinata xy:\t"+_rond.posX+"," + _rond.posY+ "\tVrsta: " + _rond.row + "\tPozicija: " + _rond.position);
            }

        }
    }
}
