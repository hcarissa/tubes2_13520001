
namespace Dummy
{
    partial class Form1
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
            this.title = new System.Windows.Forms.TextBox();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.pathBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.findAllCheck = new System.Windows.Forms.CheckBox();
            this.bfsBtn = new System.Windows.Forms.RadioButton();
            this.dfsBtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(344, 12);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(284, 22);
            this.title.TabIndex = 0;
            this.title.Text = "Folder Crawling";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTitle
            // 
            this.inputTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputTitle.Location = new System.Drawing.Point(49, 62);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.ReadOnly = true;
            this.inputTitle.Size = new System.Drawing.Size(92, 22);
            this.inputTitle.TabIndex = 0;
            this.inputTitle.Text = "Input";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(49, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Choose Starting Directory";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Location = new System.Drawing.Point(49, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(167, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Input File Name";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.Location = new System.Drawing.Point(49, 319);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(167, 22);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Input Metode Pencarian";
            // 
            // fileNameInput
            // 
            this.fileNameInput.AccessibleDescription = "";
            this.fileNameInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileNameInput.Location = new System.Drawing.Point(49, 218);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(167, 22);
            this.fileNameInput.TabIndex = 0;
            this.fileNameInput.TextChanged += new System.EventHandler(this.fileNameInput_TextChanged);
            // 
            // pathBtn
            // 
            this.pathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathBtn.Location = new System.Drawing.Point(49, 131);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(130, 34);
            this.pathBtn.TabIndex = 1;
            this.pathBtn.Text = "Choose Folder...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pathBox.Location = new System.Drawing.Point(196, 137);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(167, 22);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "No File Choosen";
            // 
            // findAllCheck
            // 
            this.findAllCheck.AutoSize = true;
            this.findAllCheck.ForeColor = System.Drawing.Color.White;
            this.findAllCheck.Location = new System.Drawing.Point(49, 261);
            this.findAllCheck.Name = "findAllCheck";
            this.findAllCheck.Size = new System.Drawing.Size(145, 21);
            this.findAllCheck.TabIndex = 2;
            this.findAllCheck.Text = "Find all occurence";
            this.findAllCheck.UseVisualStyleBackColor = true;
            this.findAllCheck.CheckedChanged += new System.EventHandler(this.findAllCheck_CheckedChanged);
            // 
            // bfsBtn
            // 
            this.bfsBtn.AutoSize = true;
            this.bfsBtn.ForeColor = System.Drawing.Color.White;
            this.bfsBtn.Location = new System.Drawing.Point(49, 357);
            this.bfsBtn.Name = "bfsBtn";
            this.bfsBtn.Size = new System.Drawing.Size(55, 21);
            this.bfsBtn.TabIndex = 3;
            this.bfsBtn.TabStop = true;
            this.bfsBtn.Text = "BFS";
            this.bfsBtn.UseVisualStyleBackColor = true;
            this.bfsBtn.CheckedChanged += new System.EventHandler(this.bfsBtn_CheckedChanged);
            // 
            // dfsBtn
            // 
            this.dfsBtn.AutoSize = true;
            this.dfsBtn.ForeColor = System.Drawing.Color.White;
            this.dfsBtn.Location = new System.Drawing.Point(49, 384);
            this.dfsBtn.Name = "dfsBtn";
            this.dfsBtn.Size = new System.Drawing.Size(56, 21);
            this.dfsBtn.TabIndex = 3;
            this.dfsBtn.TabStop = true;
            this.dfsBtn.Text = "DFS";
            this.dfsBtn.UseVisualStyleBackColor = true;
            this.dfsBtn.CheckedChanged += new System.EventHandler(this.dfsBtn_CheckedChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(49, 425);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(167, 52);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "serach.me";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 622);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(443, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 305);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // outputTitle
            // 
            this.outputTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputTitle.Location = new System.Drawing.Point(625, 137);
            this.outputTitle.Name = "outputTitle";
            this.outputTitle.ReadOnly = true;
            this.outputTitle.Size = new System.Drawing.Size(92, 22);
            this.outputTitle.TabIndex = 0;
            this.outputTitle.Text = "Output";
            this.outputTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(977, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dfsBtn);
            this.Controls.Add(this.bfsBtn);
            this.Controls.Add(this.findAllCheck);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.outputTitle);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Dummy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox fileNameInput;
        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.CheckBox findAllCheck;
        private System.Windows.Forms.RadioButton bfsBtn;
        private System.Windows.Forms.RadioButton dfsBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox outputTitle;
    }
}

