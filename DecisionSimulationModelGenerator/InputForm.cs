
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Metadata.Edm;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
namespace DecisionSimulationModelGenerator
{

    public partial class InputForm : Form
    {
        public List<contents> contentsobj = new List<contents>(2);
        String questionPlot = "F"; String optionsPlot = "G";
        int questionPlotNum = 6; int optionsPlotNum = 6; int optCountNum = 0;
        int totalQues = 0; int quesPlotNum = 0;
        // ArrayList contentsList = new ArrayList()
        //  List<string> add_list = new List<string>[100];
        int inx = 1; int inxLen = 0;
        string[] array = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
        string[] extraField = { "Meetdemenadcolor", "Meetsericelevelscolor", "CostColor", "ProductqualityColor", "LeadTimeColor", "Csatisfactory", "CSatAvgColor", "Feedback"};
        string[] myList;
        int columnIn = 0; 
        public InputForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void enableDisableGroup(bool cons, String _all)
        {
            if (_all == "all")
            {
                addoptions.Enabled = cons;
                questions.Enabled = cons;
                optioncount.Enabled = cons;
                //clearoptions.Enabled = cons;
            }
            else
            {
                optionplot.Controls.Clear();
                questions.Enabled = cons;
                optioncount.Enabled = cons;
              //  clearoptions.Enabled = cons;
            }
        }
        public void clearGroup()
        {

            questions.Clear();
            optioncount.SelectedIndex = -1;
            checkEmpty();
        }
        public void createOptions()
        {
            enableDisableGroup(false, "all");
            optionplot.Show();
            optionplot.Controls.Clear();
            int optCount = Int32.Parse(optioncount.Text);

            addcontent.Show();

            for (int i = 1; i <= optCount; i++)
            {
                // textBoxes[i] = new TextBox();
                // Here you can modify the value of the textbox which is at textBoxes[i]

                Label l = new Label();
                TextBox t = new TextBox();
                l.Name = i.ToString();
                l.Text = "Options " + i;
                t.Name = "Options" + i;
                optionplot.Controls.Add(l);
                optionplot.Controls.Add(t);
                // optionplot.Controls.Add(labels[i]);
                // Here you can modify the value of the label which is at labels[i]
            }
        }
        public void checkEmpty()
        {



            if (optioncount.SelectedIndex == -1)
            {
                addoptions.Enabled = false;
            }
            else
            {

                addoptions.Enabled = !string.IsNullOrEmpty(questions.Text);
            }
        }
        private void addoptions_Click(object sender, EventArgs e)
        {
            createOptions();

        }

        private void addquestion_Click(object sender, EventArgs e)
        {
            quesPlotNum++;
            totalQues = Int32.Parse(quesleng.Text); ;
            questionbox.Show();
            quesgroup.Hide();
            quesLen.Show();
      
            questionbox.Left = 29;
            questionbox.Top = 15;
            quesLen.Text = "Question "+quesPlotNum.ToString();
        }

      

        private void questions_TextChanged(object sender, EventArgs e)
        {


            checkEmpty();

        }

        private void optioncount_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEmpty();

        }

        private void addcontent_Click(object sender, EventArgs e)
        {
        
         
                quesPlotNum++;
                String _questions = questions.Text;
                addcontent.Hide();

                int optCount = Int32.Parse(optioncount.Text);
                String[] OptArr = new String[optCount];
                int countVal = 0;
                quesLen.Text = "Question " + quesPlotNum.ToString();



                for (int i = 1; i <= optCount; ++i)
                {

                    string name = "Options" + i;

                    TextBox txtBox = optionplot.Controls[name] as TextBox;
                txtBox.Width = 350;
                txtBox.Height = 32;
                    OptArr[countVal] = txtBox.Text;
                    countVal++;
                }

                inxLen++;
                optCountNum = inxLen;
                contents contentList1 = new contents()
                {
                    ques = _questions,
                    OptArr = OptArr
                };
                contentsobj.Add(contentList1);

                GenerateModel();
                clearGroup();
                enableDisableGroup(true, "");
                if (quesPlotNum> totalQues)
                {
                addcontent.Hide();
                questionbox.Hide();
                    generatormodel.Show();
                }
            }

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
               */
            Worksheet vstoWorksheet = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];
            vstoWorksheet.Range[questionPlot + questionPlotNum].Value2 = "Questions";
            vstoWorksheet.Range[optionsPlot + optionsPlotNum].Value2 = "Options";
            int plotNum = 1;
            int plotNumQUES = 0; int plotNumOpt = 0; int LastplotNumOpt = 0; int LastplotNumQues = 0;
            foreach (contents item in contentsobj)
            {
                int nums = 0;
                if (plotNumQUES == 0)
                {
                    nums = questionPlotNum + plotNum;
                    nums = nums + plotNumQUES;
                }
                else
                {
                    nums = LastplotNumQues + questionPlotNum + plotNum;


                }

                plotNumQUES = nums;
                vstoWorksheet.Range[questionPlot + nums].Value2 = item.ques;

                for (int i = 0; i < item.OptArr.Length; ++i)
                {
                    int itemnumsincrement = 0;
                    int itemnums = 0;
                    if (LastplotNumOpt == 0)
                    {
                        itemnumsincrement = i + 1;
                        itemnums = optionsPlotNum + itemnumsincrement;

                    }
                    else
                    {
                        itemnumsincrement = i + 1;
                        itemnums = plotNumOpt + itemnumsincrement;


                    }


                    vstoWorksheet.Range[optionsPlot + itemnums].Value2 = item.OptArr[i];
                    if (i == item.OptArr.Length - 1)
                    {
                        LastplotNumOpt = itemnums;
                    }



                }

                plotNum++;
                plotNumQUES = item.OptArr.Length;
                LastplotNumQues = LastplotNumQues + plotNumQUES;
                plotNumOpt = LastplotNumOpt;
                plotNumOpt = plotNumOpt + 1;
            }


        }


        public class contents
        {

            public string ques { get; set; }
            public String[] OptArr { get; set; }
        }

        private void generatormodel_Click(object sender, EventArgs e)
        {
          String[] contetObjOpt = new String[optCountNum];
          //  ArrayList contetObjOpt = new ArrayList(optCountNum);
            Excel.Worksheet newWorksheet;
            newWorksheet = (Excel.Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();
            newWorksheet.Name = "COMBINATION";
            Worksheet vstoWorksheet2 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];
          
            myList = new string[optCountNum];
            //    vstoWorksheet.Range[questionPlot + questionPlotNum].Value2 = "Questions";
          
            int InnerIndex = 0;
            int to = optCountNum + 1; int froms = InnerIndex + 1;

            for (var p = 0;p< contentsobj.Count;p++)
            {
                var incre = p + 1;
                vstoWorksheet2.Range[GetColumnName(incre) + 1].Value2 = "Selection "+ incre;
            }
            var incre2 = contentsobj.Count + 1;
         
       
            vstoWorksheet2.Range[GetColumnName(incre2) + 1].Value2 = "Combinations";
            for (var f =0; f < extraField.Length; f++) {

                int ix = f + 1+ incre2;
            
                vstoWorksheet2.Range[GetColumnName(ix) + 1].Value2 = extraField[f];
            }
   
            if (contentsobj.Count == 2)
            {

                var array1 = contentsobj[0].OptArr;
                var array2 = contentsobj[1].OptArr;


                foreach (var a in array1.Select((value, index) => (value, index)))
                {

                    foreach (var b in array2.Select((value, index) => (value, index)))
                    {

                        
                            string values = a.value + "_" + b.value;
                            string indexes = a.index + "_" + b.index;
                            //  MessageBox.Show(values);
                            //   MessageBox.Show(indexes);
                            plottcombinations(values, indexes);
                        
                    }
                }
            }
            if (contentsobj.Count == 3)
            {
                
                var array1 = contentsobj[0].OptArr;
                var array2 = contentsobj[1].OptArr;
                var array3 = contentsobj[2].OptArr;


                foreach (var a in array1.Select((value, index) => (value, index)))
                {
                    foreach (var b in array2.Select((value, index) => (value, index)))
                    {

                        foreach (var c in array3.Select((value, index) => (value, index)))
                        {
                            string values = a.value + "_" + b.value + "_" + c.value;
                            string indexes = a.index + "_" + b.index + "_" + c.index;
                            //  MessageBox.Show(values);
                            //   MessageBox.Show(indexes);
                            plottcombinations(values, indexes);
                        }
                    }
                }
            }
            if (contentsobj.Count == 4)
            {

                var array1 = contentsobj[0].OptArr;
                var array2 = contentsobj[1].OptArr;
                var array3 = contentsobj[2].OptArr;

                var array4 = contentsobj[3].OptArr;
                foreach (var a in array1.Select((value, index) => (value, index)))
                {
                    foreach (var b in array2.Select((value, index) => (value, index)))
                    {

                        foreach (var c in array3.Select((value, index) => (value, index)))
                        {
                         
                            foreach (var d in array4.Select((value, index) => (value, index)))
                            {
                                string values = a.value + "_" + b.value + "_" + c.value + "_" + d.value;
                                string indexes = a.index + "_" + b.index + "_" + c.index + "_" + d.index;
                                //  MessageBox.Show(values);
                                //   MessageBox.Show(indexes);
                                plottcombinations(values, indexes);
                            }

                        }
                    }
                }
            }
            if (contentsobj.Count == 5)
            {

                var array1 = contentsobj[0].OptArr;
                var array2 = contentsobj[1].OptArr;
                var array3 = contentsobj[2].OptArr; var array4 = contentsobj[3].OptArr;
                var array5 = contentsobj[4].OptArr;

                foreach (var a in array1.Select((value, index) => (value, index)))
                {
                    foreach (var b in array2.Select((value, index) => (value, index)))
                    {

                        foreach (var c in array3.Select((value, index) => (value, index)))
                        {
                           
                            foreach (var d in array4.Select((value, index) => (value, index)))
                            {
                                foreach (var g in array5.Select((value, index) => (value, index)))
                                {
                                    string values = a.value + "_" + b.value + "_" + c.value + "_" + d.value + "_" + g.value;
                                    string indexes = a.index + "_" + b.index + "_" + c.index + "_" + d.index + "_" + g.index;
                                    //  MessageBox.Show(values);
                                    //   MessageBox.Show(indexes);
                                    plottcombinations(values, indexes);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void ElementLocation(int left, int top) { 
        }
        public void plottcombinations(string values, string indexes) {
            var valuesplit = values.Split('_');

            var boxin = inx + 1;
            inx = boxin;
            Worksheet vstoWorksheet2 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];
            for (var a = 0; a < valuesplit.Length; a++) {
              
                columnIn = a + 1;
               
                vstoWorksheet2.Range[GetColumnName(columnIn) + boxin].Value2 = valuesplit[a];
                //  MessageBox.Show(valuesplit[a]);
              
            }
            columnIn = columnIn + 1;
            vstoWorksheet2.Range[GetColumnName(columnIn) + boxin].Value2 = indexes;

            for (var f = 0; f < extraField.Length; f++)
            {

                int ix = f + 1 + columnIn;
                if (f == extraField.Length - 1)
                    vstoWorksheet2.Range[GetColumnName(ix) + boxin].Value2 = "Feedback ";
                else 
                vstoWorksheet2.Range[GetColumnName(ix) + boxin].Value2 = "Green";
            }

        }
        public static string GetColumnName(int columnNumber)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string columnName = "";

            while (columnNumber > 0)
            {
                columnName = letters[(columnNumber - 1) % 26] + columnName;
                columnNumber = (columnNumber - 1) / 26;
            }

            return columnName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    public static class LinqHelper
    {
        public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(
   this IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            return sequences.Aggregate(
                emptyProduct,
                (accumulator, sequence) =>
                    from accseq in accumulator
                    from item in sequence
                    select accseq.Concat(new[] { item }));
        }
    }
}
