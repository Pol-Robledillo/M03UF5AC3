using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
namespace M03UF5AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Helper.CsvToXml("../../../files/Consum.csv", "../../../files/Consum.xml");
            InitializeComponent();
            FillComboBoxYear();
            FillComboBoxComarca();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            infoComarcas.Columns.Add("Any", "Any");
            infoComarcas.Columns.Add("Comarca", "Comarca");
            infoComarcas.Columns.Add("Poblacio", "Poblacio");
            infoComarcas.Columns.Add("DomesticXarxa", "DomesticXarxa");
            infoComarcas.Columns.Add("ActivitatsEconomiques", "ActivitatsEconomiques");
            infoComarcas.Columns.Add("Total", "Total");
            infoComarcas.Columns.Add("ConsumDomesticPerCapita", "ConsumDomesticPerCapita");
            LoadDataIntoGrid();
        }
        private void LoadDataIntoGrid()
        {
            List<Consum> consums = Helper.GetDataFromCsv("../../../files/Consum.csv");
            foreach (Consum consum in consums)
            {
                int rowIndex = infoComarcas.Rows.Add();
                DataGridViewRow row = infoComarcas.Rows[rowIndex];
                row.Cells["Any"].Value = consum.Any;
                row.Cells["Comarca"].Value = consum.Comarca;
                row.Cells["Poblacio"].Value = consum.Poblacio;
                row.Cells["DomesticXarxa"].Value = consum.DomesticXarxa;
                row.Cells["ActivitatsEconomiques"].Value = consum.ActivitatsEconomiques;
                row.Cells["Total"].Value = consum.Total;
                row.Cells["ConsumDomesticPerCapita"].Value = consum.ConsumDomesticPerCapita;
            }
        }
        private void FillComboBoxYear()
        {
            List<Consum> consums = Helper.GetDataFromCsv("../../../files/Consum.csv");
            int minYear = consums.Min(x => x.Any);
            for (int i = minYear; i <= 2050; i++)
            {
                yearSelector.Items.Add(i);
            }
        }
        private void FillComboBoxComarca()
        {
            List<string> comarques = Helper.GetComarquesXML();
            foreach (string comarca in comarques)
            {
                regionSelector.Items.Add(comarca);
            }
        }

        private void cleanSelectionButton_Click(object sender, EventArgs e)
        {
            yearSelector.SelectedIndex = -1;
            regionSelector.SelectedIndex = -1;
            populationInput.Text = "";
            domNetInput.Text = "";
            ecoActivitiesInput.Text = "";
            consDomInput.Text = "";
            totalInput.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int year = yearSelector.SelectedIndex == -1 ? -1 : (int)yearSelector.SelectedItem;
            string? region = regionSelector.SelectedIndex == -1 ? "" : (string)regionSelector.SelectedItem;
            string population = populationInput.Text;
            string domNet = domNetInput.Text;
            string ecoActivities = ecoActivitiesInput.Text;
            string total = totalInput.Text;
            string consDom = consDomInput.Text;
            bool allCorrect = true;
            Regex regexNums = new Regex(@"^\d+$");
            Regex regexDecimals = new Regex(@"^\d+(\,\d+)?$");

            if (year == -1)
            {
                errorProvider1.SetError(yearSelector, "Any no pot estar buit");
                MessageBox.Show("Any no pot estar buit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            } else
            {
                errorProvider1.SetError(yearSelector, "");
            }
            if (region == "")
            {
                errorProvider1.SetError(regionSelector, "Comarca no pot estar buida");
                MessageBox.Show("Comarca no pot estar buida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(regionSelector, "");
            }
            if (!regexNums.IsMatch(population))
            {
                errorProvider1.SetError(populationInput, "Poblacio ha de ser un nombre enter");
                MessageBox.Show("Poblacio ha de ser un nombre enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(populationInput, "");
            }
            if (!regexNums.IsMatch(domNet))
            {
                errorProvider1.SetError(domNetInput, "DomesticXarxa ha de ser un nombre enter");
                MessageBox.Show("Domestic Xarxa ha de ser un nombre enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(domNetInput, "");
            }
            if (!regexNums.IsMatch(ecoActivities))
            {
                errorProvider1.SetError(ecoActivitiesInput, "ActivitatsEconomiques ha de ser un nombre enter");
                MessageBox.Show("Activitats Economiques ha de ser un nombre enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(ecoActivitiesInput, "");
            }
            if (!regexNums.IsMatch(total))
            {
                errorProvider1.SetError(totalInput, "Total ha de ser un nombre enter");
                MessageBox.Show("Total ha de ser un nombre enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(totalInput, "");
            }
            if (!regexDecimals.IsMatch(consDom))
            {
                errorProvider1.SetError(consDomInput, "ConsumDomesticPerCapita ha de ser un nombre decimal");
                MessageBox.Show("Consum Domestic Per Capita ha de ser un nombre decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allCorrect = false;
            }
            else
            {
                errorProvider1.SetError(consDomInput, "");
            }
            if (allCorrect)
            {
                Consum consum = new Consum
                {
                    Any = year,
                    CodiComarca = Helper.GetCodiComarcaXML(region),
                    Comarca = region,
                    Poblacio = int.Parse(population),
                    DomesticXarxa = int.Parse(domNet),
                    ActivitatsEconomiques = int.Parse(ecoActivities),
                    Total = int.Parse(total),
                    ConsumDomesticPerCapita = double.Parse(consDom)
                };
                Helper.AddConsumToCsv(consum, "../../../files/Consum.csv");
                infoComarcas.Rows.Clear();
                LoadDataIntoGrid();
            }

        }

        private void infoComarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                populationBiggerThanInfo.Visible = true;
                avgDomConsInfo.Visible = true;
                highestDomConsInfo.Visible = true;
                lowestDomConsInfo.Visible = true;

                DataGridViewRow row = infoComarcas.Rows[e.RowIndex];

                double poblacion = double.Parse(row.Cells["Poblacio"].Value.ToString());
                populationBiggerThanInfo.Text = poblacion > 20000 ? "Sí" : "No";

                double domesticXarxa = double.Parse(row.Cells["DomesticXarxa"].Value.ToString());
                double average = poblacion != 0 ? domesticXarxa / poblacion : 0;
                avgDomConsInfo.Text = average.ToString("0,00");

                double consumPerCapita = double.Parse(row.Cells["ConsumDomesticPerCapita"].Value.ToString());
                highestDomConsInfo.Text = Helper.IsHighestDomCons(consumPerCapita) ? "Sí" : "No";
                lowestDomConsInfo.Text = Helper.IsLowestDomCons(consumPerCapita) ? "Sí" : "No";
            }
        }
    }
}
