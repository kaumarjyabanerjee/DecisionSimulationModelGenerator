using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using System.Drawing;

namespace DecisionSimulationModelGenerator
{
    public partial class Simulation
    {
        private void Simulation_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //  Globals.ThisAddIn.GenerateModel();
            Form MyForm = new InputForm();
            MyForm.Show();
        }
    }
}
