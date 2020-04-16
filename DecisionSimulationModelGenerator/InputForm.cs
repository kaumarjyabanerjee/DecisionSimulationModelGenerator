
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
        // ArrayList contentsList = new ArrayList()
        //  List<string> add_list = new List<string>[100];
        int inx = 0; int inxLen = 0;
        string[] array = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
        string[] myList;
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
                clearoptions.Enabled = cons;
            }
            else
            {
                optionplot.Controls.Clear();
                questions.Enabled = cons;
                optioncount.Enabled = cons;
                clearoptions.Enabled = cons;
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
            questionbox.Show();
        }

        private void clearoptions_Click(object sender, EventArgs e)
        {
            optioncount.SelectedIndex = -1;

            addoptions.Enabled = false;

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
            String _questions = questions.Text;
            addcontent.Hide();

            int optCount = Int32.Parse(optioncount.Text);
            String[] OptArr = new String[optCount];
            int countVal = 0;




            for (int i = 1; i <= optCount; ++i)
            {

                string name = "Options" + i;

                TextBox txtBox = optionplot.Controls[name] as TextBox;

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
            int inx = 0;
            int InnerIndex = 0;
            int to = optCountNum + 1; int froms = InnerIndex + 1;
         

         

           // foreach (contents item in contentsobj)
           // {
                int restArrLen = contentsobj.Count - 1;
            string context = "";
            for (int k = 0; k < contentsobj.Count; k++) {
               // for (int i = 0; i < ; i++)
              //  {
                    contetObjOpt[k] = ConvertStringArrayToString(contentsobj[k].OptArr);
                  /*  context += contentsobj[k].OptArr[i];
                    for (int m = 1; m <= restArrLen; m++)
                    {
                        for (int s = 0; s < contentsobj[m].OptArr.Length; s++)
                        {
                            context += contentsobj[m].OptArr[s];
                        }
                           
                    }*/

        ///    }

                //   MessageBox.Show("items" + contentsobj.OptArr.Count);
                //vstoWorksheet2.Range[GetColumnName(1) + InnerIndex + 1, GetColumnName(1)+ plottill].Value2 = contentsobj[0].OptArr[k];
                /*  for (int k = 0; k <item.OptArr.Length; k++)
               {
                     //   String consVal = contentsobj[inx].OptArr[k];

                     if (inx == 0)
                     {
                     //    vstoWorksheet2.Range[GetColumnName(1) + froms, GetColumnName(1) + to].Value2 = item.OptArr[k];
                        // froms = to + 1;
                        // to = froms + optCountNum;

                         for (int p = 0; p < restArrLen; p++)
                         {
                             //  consVal+=
                         }
                     }
                        


           // }
            */
                inx++;
                

            }

            for (int c = 0; c <optCountNum; c++)
            {
              //  string opt = contetObjOpt[c].Replace(".", "");
            //    MessageBox.Show("items" + opt.Length);
            }
            var array1 = new[] { 1, 2, 3 };
            var array2 = new[] { 4, 5 };
            var array3 = new[] { 6,7 };


            foreach (var a in array1)
            {
                foreach (var b in array2)
                {
                    foreach (var c in array3)
                    {
                        string _cons = a + "_" + b + "_" + c;
                        MessageBox.Show(_cons);
                        //   Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                }
            }
            MessageBox.Show("items" + context);
            
        }
        static string ConvertStringArrayToStringJoin(string array)
        {
            // Use string Join to concatenate the string elements.
            string result = string.Join(".", array);
            return result;
        }
        static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
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
      
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }



    }
}
