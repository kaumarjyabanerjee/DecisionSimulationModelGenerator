using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using System.Windows.Forms;

namespace DecisionSimulationModelGenerator
{
    public partial class ThisAddIn
    {
        String questionPlot = "F"; String optionsPlot = "G";
        int questionPlotNum = 6; int optionsPlotNum = 6;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        internal Range GetActiveCell()
        {
            throw new NotImplementedException();
        }
        public class contents
        {

            public string ques { get; set; }
            public String[] OptArr { get; set; }
        }
        //  public void GenerateModel(InputForm.contents[] contents) {
        public void GenerateModel()
        {
            /*   MessageBox.Show("contents:: " + contents.Length);
               for (int i = 0; i < contents.Length; i++)
               {
                   MessageBox.Show(contents[i].ques);
                   MessageBox.Show("contents:: " + contents.Length);
                   for (int k = 0; k < contents[i].OptArr.Length; k++)
                   {
                       MessageBox.Show("k:: "+k);
                       MessageBox.Show(contents[i].OptArr[k]);
                   }
               }
             
            InputForm inf = new InputForm();

            foreach (contents item in inf.contentsobj)
            {
                MessageBox.Show("Data :" + item.ques);
                for (int i = 0; i < item.OptArr.Length; ++i)
                {
                    MessageBox.Show("OptArr :" + item.OptArr[i]);
                }

            }


          
                Worksheet vstoWorksheet = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];
            // The following line of code specifies a single cell.
            vstoWorksheet.Range[questionPlot+ questionPlotNum].Value2 = "Questions";

            vstoWorksheet.Range[optionsPlot + optionsPlotNum].Value2 = "Options";
            // The following line of code specifies multiple cells.
            vstoWorksheet.Range["A3", "B4"].Value2 = "Range 2";

            // The following line of code uses an Excel.Range for 
            // the second parameter of the Range property.
             int ran = 8;
            Excel.Range range1 = vstoWorksheet.Range["C" + ran];
            vstoWorksheet.Range["A6", range1].Value2 = "Range 3";

      */
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
