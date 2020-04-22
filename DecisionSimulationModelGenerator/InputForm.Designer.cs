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
            this.addoptions = new System.Windows.Forms.Button();
            this.quesLen = new System.Windows.Forms.Label();
            this.optioncount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionplot = new System.Windows.Forms.FlowLayoutPanel();
            this.addcontent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quesleng = new System.Windows.Forms.ComboBox();
            this.quesgroup = new System.Windows.Forms.GroupBox();
            this.questionbox.SuspendLayout();
            this.quesgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // addquestion
            // 
            this.addquestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addquestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addquestion.ForeColor = System.Drawing.Color.Black;
            this.addquestion.Location = new System.Drawing.Point(556, 33);
            this.addquestion.Name = "addquestion";
            this.addquestion.Size = new System.Drawing.Size(128, 24);
            this.addquestion.TabIndex = 0;
            this.addquestion.Text = "Add";
            this.addquestion.UseVisualStyleBackColor = false;
            this.addquestion.Click += new System.EventHandler(this.addquestion_Click);
            // 
            // generatormodel
            // 
            this.generatormodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.generatormodel.Location = new System.Drawing.Point(29, 537);
            this.generatormodel.Name = "generatormodel";
            this.generatormodel.Size = new System.Drawing.Size(678, 41);
            this.generatormodel.TabIndex = 1;
            this.generatormodel.Text = "Generator Model";
            this.generatormodel.UseVisualStyleBackColor = false;
            this.generatormodel.Visible = false;
            this.generatormodel.Click += new System.EventHandler(this.generatormodel_Click);
            // 
            // questionbox
            // 
            this.questionbox.Controls.Add(this.addoptions);
            this.questionbox.Controls.Add(this.quesLen);
            this.questionbox.Controls.Add(this.optioncount);
            this.questionbox.Controls.Add(this.label2);
            this.questionbox.Controls.Add(this.questions);
            this.questionbox.Controls.Add(this.label1);
            this.questionbox.Location = new System.Drawing.Point(29, 172);
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(690, 243);
            this.questionbox.TabIndex = 2;
            this.questionbox.TabStop = false;
            this.questionbox.Visible = false;
            // 
            // addoptions
            // 
            this.addoptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addoptions.Enabled = false;
            this.addoptions.Location = new System.Drawing.Point(556, 162);
            this.addoptions.Name = "addoptions";
            this.addoptions.Size = new System.Drawing.Size(128, 24);
            this.addoptions.TabIndex = 4;
            this.addoptions.Text = "Add Options";
            this.addoptions.UseVisualStyleBackColor = false;
            this.addoptions.Click += new System.EventHandler(this.addoptions_Click);
            // 
            // quesLen
            // 
            this.quesLen.AutoSize = true;
            this.quesLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesLen.Location = new System.Drawing.Point(22, 17);
            this.quesLen.Name = "quesLen";
            this.quesLen.Size = new System.Drawing.Size(100, 20);
            this.quesLen.TabIndex = 8;
            this.quesLen.Text = "Question 1";
            this.quesLen.Visible = false;
            // 
            // optioncount
            // 
            this.optioncount.FormattingEnabled = true;
            this.optioncount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.optioncount.Location = new System.Drawing.Point(313, 162);
            this.optioncount.Name = "optioncount";
            this.optioncount.Size = new System.Drawing.Size(212, 24);
            this.optioncount.TabIndex = 3;
            this.optioncount.SelectedIndexChanged += new System.EventHandler(this.optioncount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many options for the question";
            // 
            // questions
            // 
            this.questions.Location = new System.Drawing.Point(313, 21);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(371, 93);
            this.questions.TabIndex = 1;
            this.questions.Text = "";
            this.questions.TextChanged += new System.EventHandler(this.questions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // optionplot
            // 
            this.optionplot.Location = new System.Drawing.Point(29, 421);
            this.optionplot.Name = "optionplot";
            this.optionplot.Size = new System.Drawing.Size(690, 110);
            this.optionplot.TabIndex = 3;
            this.optionplot.Visible = false;
            // 
            // addcontent
            // 
            this.addcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addcontent.Location = new System.Drawing.Point(29, 634);
            this.addcontent.Name = "addcontent";
            this.addcontent.Size = new System.Drawing.Size(676, 40);
            this.addcontent.TabIndex = 5;
            this.addcontent.Text = "Add ";
            this.addcontent.UseVisualStyleBackColor = false;
            this.addcontent.Visible = false;
            this.addcontent.Click += new System.EventHandler(this.addcontent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.MaximumSize = new System.Drawing.Size(250, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many question sets  do you want?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // quesleng
            // 
            this.quesleng.FormattingEnabled = true;
            this.quesleng.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.quesleng.Location = new System.Drawing.Point(313, 31);
            this.quesleng.Name = "quesleng";
            this.quesleng.Size = new System.Drawing.Size(227, 24);
            this.quesleng.TabIndex = 7;
            // 
            // quesgroup
            // 
            this.quesgroup.Controls.Add(this.label3);
            this.quesgroup.Controls.Add(this.quesleng);
            this.quesgroup.Controls.Add(this.addquestion);
            this.quesgroup.Location = new System.Drawing.Point(29, 15);
            this.quesgroup.Name = "quesgroup";
            this.quesgroup.Size = new System.Drawing.Size(690, 93);
            this.quesgroup.TabIndex = 9;
            this.quesgroup.TabStop = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(749, 686);
            this.Controls.Add(this.quesgroup);
            this.Controls.Add(this.addcontent);
            this.Controls.Add(this.optionplot);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.generatormodel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Model Data";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.questionbox.ResumeLayout(false);
            this.questionbox.PerformLayout();
            this.quesgroup.ResumeLayout(false);
            this.quesgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addquestion;
        private System.Windows.Forms.Button generatormodel;
        private System.Windows.Forms.GroupBox questionbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox questions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addoptions;
        private System.Windows.Forms.ComboBox optioncount;
        private System.Windows.Forms.FlowLayoutPanel optionplot;
        private System.Windows.Forms.Button addcontent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quesleng;
        private System.Windows.Forms.Label quesLen;
        private System.Windows.Forms.GroupBox quesgroup;
    }
}