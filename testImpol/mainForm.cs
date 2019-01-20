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
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Printing;

namespace testImpol
{
    public partial class mainForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public mainForm()
        {
            InitializeComponent();
        }

        Calculation cal = new Calculation();
        private PrintDocument document = new PrintDocument();

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
            {
                log.Info("Nepravilen vnos parametrov");
                MessageBox.Show("Vhodni podatki dolžine, širine in radiusa rondelic morajo biti večji od 0!",
                        "Opozorilo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
            }
            else
            {
                //preverimo št. možnih rondelic na traku in postavitev, rezultat 
                log.Info("Izvedba kalkulacije");
                List<Rond> result = cal.Calculate(length, width, radius, minTopDistance, minLeftDistance, minMiddleDistance);
                txtResult.Text = result.Count().ToString();
                lbCoordinates.Items.Clear();
                int i = 1;
                foreach (Rond _rond in result)
                {
                    lbCoordinates.Items.Add(i + "\tKoordinata xy:\t" + _rond.posX + "," + _rond.posY + "\tVrsta: " + _rond.row + "\tPozicija: " + _rond.position);
                    i++;
                }

                //shranimo zadnji vnos
                var xs = new XmlSerializer(typeof(List<string>));
                using (var fs = new FileStream("input_paramteres.xml", FileMode.Create))
                {
                    xs.Serialize(fs, new List<string> { numLength.Value.ToString(), numWidth.Value.ToString(), numRadius.Value.ToString(),
                        numTopDistance.Value.ToString(),numLeftDistance.Value.ToString(), numMiddleDistance.Value.ToString()});
                }

                //omogočimo izvoz
                btnExport.Enabled = true;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //postavi parametre zadnjega vnosa iz datoteke
            try
            {
                if (File.Exists(Application.StartupPath + "\\input_paramteres.xml"))
                {
                    var xs = new XmlSerializer(typeof(List<string>));
                    using (var fs = new FileStream("input_paramteres.xml", FileMode.Open))
                    {
                        List<string> par = xs.Deserialize(fs) as List<string>;
                        numLength.Value = int.Parse(par[0]);
                        numWidth.Value = int.Parse(par[1]);
                        numRadius.Value = int.Parse(par[2]);
                        numTopDistance.Value = int.Parse(par[3]);
                        numLeftDistance.Value = int.Parse(par[4]);
                        numMiddleDistance.Value = int.Parse(par[5]);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }

            //ustvari direktorij če le-ta ne obstaja
            Directory.CreateDirectory(Application.StartupPath + "\\Izvoz");
        }

        private void btnExport_Click(object sender, EventArgs e)
        { 
            System.IO.StreamWriter rondExport = new System.IO.StreamWriter(Application.StartupPath + "\\Izvoz\\" + "Rondelice_r"+numRadius.Value.ToString()+"_("+ DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")+").txt", true);
            for (int i = 0; i < lbCoordinates.Items.Count; i++)
                rondExport.WriteLine(lbCoordinates.Items[i].ToString());
            rondExport.Close();
            btnExport.Enabled = false;
        }
    }
}
