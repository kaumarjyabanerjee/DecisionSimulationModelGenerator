namespace DecisionSimulationModelGenerator
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addquestion = new System.Windows.Forms.Button();
            this.generatormodel = new System.Windows.Forms.Button();
            this.questionbox = new System.Windows.Forms.GroupBox();
            this.clearoptions = new System.Windows.Forms.Button();
            this.addoptions = new System.Windows.Forms.Button();
            this.optioncount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionplot = new System.Windows.Forms.FlowLayoutPanel();
            this.addcontent = new System.Windows.Forms.Button();
            this.questionbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addquestion
            // 
            this.addquestion.Location = new System.Drawing.Point(29, 26);
            this.addquestion.Name = "addquestion";
            this.addquestion.Size = new System.Drawing.Size(128, 41);
            this.addquestion.TabIndex = 0;
            this.addquestion.Text = "Add Question";
            this.addquestion.UseVisualStyleBackColor = true;
            this.addquestion.Click += new System.EventHandler(this.addquestion_Click);
            // 
            // generatormodel
            // 
            this.generatormodel.Location = new System.Drawing.Point(382, 26);
            this.generatormodel.Name = "generatormodel";
            this.generatormodel.Size = new System.Drawing.Size(128, 41);
            this.generatormodel.TabIndex = 1;
            this.generatormodel.Text = "Generator Model";
            this.generatormodel.UseVisualStyleBackColor = true;
            this.generatormodel.Click += new System.EventHandler(this.generatormodel_Click);
            // 
            // questionbox
            // 
            this.questionbox.Controls.Add(this.clearoptions);
            this.questionbox.Controls.Add(this.addoptions);
            this.questionbox.Controls.Add(this.optioncount);
            this.questionbox.Controls.Add(this.label2);
            this.questionbox.Controls.Add(this.questions);
            this.questionbox.Controls.Add(this.label1);
            this.questionbox.Location = new System.Drawing.Point(29, 128);
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(481, 259);
            this.questionbox.TabIndex = 2;
            this.questionbox.TabStop = false;
            this.questionbox.Visible = false;
            // 
            // clearoptions
            // 
            this.clearoptions.Location = new System.Drawing.Point(314, 189);
            this.clearoptions.Name = "clearoptions";
            this.clearoptions.Size = new System.Drawing.Size(122, 32);
            this.clearoptions.TabIndex = 5;
            this.clearoptions.Text = "Clear Option";
            this.clearoptions.UseVisualStyleBackColor = true;
            this.clearoptions.Click += new System.EventHandler(this.clearoptions_Click);
            // 
            // addoptions
            // 
            this.addoptions.Enabled = false;
            this.addoptions.Location = new System.Drawing.Point(25, 189);
            this.addoptions.Name = "addoptions";
            this.addoptions.Size = new System.Drawing.Size(115, 32);
            this.addoptions.TabIndex = 4;
            this.addoptions.Text = "Add Options";
            this.addoptions.UseVisualStyleBackColor = true;
            this.addoptions.Click += new System.EventHandler(this.addoptions_Click);
            // 
            // optioncount
            // 
            this.optioncount.FormattingEnabled = true;
            this.optioncount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.optioncount.Location = new System.Drawing.Point(25, 135);
            this.optioncount.Name = "optioncount";
            this.optioncount.Size = new System.Drawing.Size(223, 24);
            this.optioncount.TabIndex = 3;
            this.optioncount.SelectedIndexChanged += new System.EventHandler(this.optioncount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many options for the question";
            // 
            // questions
            // 
            this.questions.Location = new System.Drawing.Point(142, 34);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(294, 32);
            this.questions.TabIndex = 1;
            this.questions.Text = "";
            this.questions.TextChanged += new System.EventHandler(this.questions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // optionplot
            // 
            this.optionplot.Location = new System.Drawing.Point(29, 393);
            this.optionplot.Name = "optionplot";
            this.optionplot.Size = new System.Drawing.Size(481, 163);
            this.optionplot.TabIndex = 3;
            this.optionplot.Visible = false;
            // 
            // addcontent
            // 
            this.addcontent.Location = new System.Drawing.Point(29, 576);
            this.addcontent.Name = "addcontent";
            this.addcontent.Size = new System.Drawing.Size(481, 37);
            this.addcontent.TabIndex = 5;
            this.addcontent.Text = "Add ";
            this.addcontent.UseVisualStyleBackColor = true;
            this.addcontent.Visible = false;
            this.addcontent.Click += new System.EventHandler(this.addcontent_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 667);
            this.Controls.Add(this.addcontent);
            this.Controls.Add(this.optionplot);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.generatormodel);
            this.Controls.Add(this.addquestion);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.questionbox.ResumeLayout(false);
            this.questionbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addquestion;
        private System.Windows.Forms.Button generatormodel;
        private System.Windows.Forms.GroupBox questionbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox questions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearoptions;
        private System.Windows.Forms.Button addoptions;
        private System.Windows.Forms.ComboBox optioncount;
        private System.Windows.Forms.FlowLayoutPanel optionplot;
        private System.Windows.Forms.Button addcontent;
    }
}