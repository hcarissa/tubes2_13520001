
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textboxInputFilename = new System.Windows.Forms.TextBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.checkboxAllOccurence = new System.Windows.Forms.CheckBox();
            this.buttonBFS = new System.Windows.Forms.RadioButton();
            this.buttonDFS = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelSubheader = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelChooseFolder = new System.Windows.Forms.Label();
            this.labelFolderChosen = new System.Windows.Forms.Label();
            this.labelInputFilename = new System.Windows.Forms.Label();
            this.labelSearchMethod = new System.Windows.Forms.Label();
            this.graphPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hyperlinkLabel = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.multiplePath = new System.Windows.Forms.LinkLabel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxInputFilename
            // 
            this.textboxInputFilename.AccessibleDescription = "";
            this.textboxInputFilename.BackColor = System.Drawing.Color.White;
            this.textboxInputFilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxInputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxInputFilename.Location = new System.Drawing.Point(45, 272);
            this.textboxInputFilename.Multiline = true;
            this.textboxInputFilename.Name = "textboxInputFilename";
            this.textboxInputFilename.Size = new System.Drawing.Size(311, 25);
            this.textboxInputFilename.TabIndex = 0;
            this.textboxInputFilename.WordWrap = false;
            this.textboxInputFilename.TextChanged += new System.EventHandler(this.fileNameInput_TextChanged);
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.BackColor = System.Drawing.Color.Transparent;
            this.buttonChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFolder.Location = new System.Drawing.Point(45, 190);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(138, 34);
            this.buttonChooseFolder.TabIndex = 1;
            this.buttonChooseFolder.Text = "Choose Folder...";
            this.buttonChooseFolder.UseVisualStyleBackColor = false;
            this.buttonChooseFolder.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // checkboxAllOccurence
            // 
            this.checkboxAllOccurence.AutoSize = true;
            this.checkboxAllOccurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAllOccurence.ForeColor = System.Drawing.Color.Black;
            this.checkboxAllOccurence.Location = new System.Drawing.Point(45, 303);
            this.checkboxAllOccurence.Name = "checkboxAllOccurence";
            this.checkboxAllOccurence.Size = new System.Drawing.Size(138, 20);
            this.checkboxAllOccurence.TabIndex = 2;
            this.checkboxAllOccurence.Text = "Find all occurence";
            this.checkboxAllOccurence.UseVisualStyleBackColor = true;
            this.checkboxAllOccurence.CheckedChanged += new System.EventHandler(this.findAllCheck_CheckedChanged);
            // 
            // buttonBFS
            // 
            this.buttonBFS.AutoSize = true;
            this.buttonBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBFS.ForeColor = System.Drawing.Color.Black;
            this.buttonBFS.Location = new System.Drawing.Point(45, 368);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(54, 20);
            this.buttonBFS.TabIndex = 3;
            this.buttonBFS.TabStop = true;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.CheckedChanged += new System.EventHandler(this.bfsBtn_CheckedChanged);
            // 
            // buttonDFS
            // 
            this.buttonDFS.AutoSize = true;
            this.buttonDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDFS.ForeColor = System.Drawing.Color.Black;
            this.buttonDFS.Location = new System.Drawing.Point(128, 368);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(55, 20);
            this.buttonDFS.TabIndex = 3;
            this.buttonDFS.TabStop = true;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.CheckedChanged += new System.EventHandler(this.dfsBtn_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(44, 421);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 52);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "search!";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.pictureLogo);
            this.panelHeader.Controls.Add(this.labelSubheader);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-1, -4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1102, 90);
            this.panelHeader.TabIndex = 11;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(995, 20);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(51, 53);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 13;
            this.pictureLogo.TabStop = false;
            // 
            // labelSubheader
            // 
            this.labelSubheader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubheader.AutoSize = true;
            this.labelSubheader.BackColor = System.Drawing.Color.Transparent;
            this.labelSubheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubheader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSubheader.Location = new System.Drawing.Point(42, 54);
            this.labelSubheader.Name = "labelSubheader";
            this.labelSubheader.Size = new System.Drawing.Size(291, 18);
            this.labelSubheader.TabIndex = 12;
            this.labelSubheader.Text = "ready to search your file as fast as the wind";
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeader.Location = new System.Drawing.Point(39, 21);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(155, 32);
            this.labelHeader.TabIndex = 12;
            this.labelHeader.Text = "search.me";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.Transparent;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(40, 126);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(49, 22);
            this.labelInput.TabIndex = 12;
            this.labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.Color.Transparent;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(434, 126);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(64, 22);
            this.labelOutput.TabIndex = 13;
            this.labelOutput.Text = "Output";
            // 
            // labelChooseFolder
            // 
            this.labelChooseFolder.AutoSize = true;
            this.labelChooseFolder.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseFolder.Location = new System.Drawing.Point(41, 166);
            this.labelChooseFolder.Name = "labelChooseFolder";
            this.labelChooseFolder.Size = new System.Drawing.Size(187, 18);
            this.labelChooseFolder.TabIndex = 14;
            this.labelChooseFolder.Text = "Choose your starting folder";
            // 
            // labelFolderChosen
            // 
            this.labelFolderChosen.AutoSize = true;
            this.labelFolderChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolderChosen.Location = new System.Drawing.Point(189, 198);
            this.labelFolderChosen.Name = "labelFolderChosen";
            this.labelFolderChosen.Size = new System.Drawing.Size(117, 16);
            this.labelFolderChosen.TabIndex = 15;
            this.labelFolderChosen.Text = "No folder choosen";
            // 
            // labelInputFilename
            // 
            this.labelInputFilename.AutoSize = true;
            this.labelInputFilename.BackColor = System.Drawing.Color.Transparent;
            this.labelInputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputFilename.Location = new System.Drawing.Point(41, 248);
            this.labelInputFilename.Name = "labelInputFilename";
            this.labelInputFilename.Size = new System.Drawing.Size(102, 18);
            this.labelInputFilename.TabIndex = 16;
            this.labelInputFilename.Text = "Input file name";
            // 
            // labelSearchMethod
            // 
            this.labelSearchMethod.AutoSize = true;
            this.labelSearchMethod.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMethod.Location = new System.Drawing.Point(41, 344);
            this.labelSearchMethod.Name = "labelSearchMethod";
            this.labelSearchMethod.Size = new System.Drawing.Size(128, 18);
            this.labelSearchMethod.TabIndex = 17;
            this.labelSearchMethod.Text = "Searching method";
            // 
            // graphPanel
            // 
            this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPanel.AutoSize = true;
            this.graphPanel.ColumnCount = 1;
            this.graphPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.graphPanel.Location = new System.Drawing.Point(439, 166);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphPanel.MaximumSize = new System.Drawing.Size(900, 600);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.RowCount = 1;
            this.graphPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.Size = new System.Drawing.Size(606, 461);
            this.graphPanel.TabIndex = 19;
            // 
            // hyperlinkLabel
            // 
            this.hyperlinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hyperlinkLabel.AutoSize = true;
            this.hyperlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabel.Location = new System.Drawing.Point(40, 478);
            this.hyperlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperlinkLabel.Name = "hyperlinkLabel";
            this.hyperlinkLabel.Size = new System.Drawing.Size(0, 20);
            this.hyperlinkLabel.TabIndex = 20;
            this.hyperlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hyperlinkLabel_LinkClicked);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(39, 478);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 21;
            // 
            // multiplePath
            // 
            this.multiplePath.AutoSize = true;
            this.multiplePath.Location = new System.Drawing.Point(42, 483);
            this.multiplePath.Name = "multiplePath";
            this.multiplePath.Size = new System.Drawing.Size(0, 16);
            this.multiplePath.TabIndex = 22;
            this.multiplePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.multiplePath_LinkClicked);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(435, 637);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 20);
            this.timeLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1098, 677);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.multiplePath);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.hyperlinkLabel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.labelSearchMethod);
            this.Controls.Add(this.labelInputFilename);
            this.Controls.Add(this.labelFolderChosen);
            this.Controls.Add(this.labelChooseFolder);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.checkboxAllOccurence);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.textboxInputFilename);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "search.me";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxInputFilename;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.CheckBox checkboxAllOccurence;
        private System.Windows.Forms.RadioButton buttonBFS;
        private System.Windows.Forms.RadioButton buttonDFS;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelSubheader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelChooseFolder;
        private System.Windows.Forms.Label labelFolderChosen;
        private System.Windows.Forms.Label labelInputFilename;
        private System.Windows.Forms.Label labelSearchMethod;
        private System.Windows.Forms.TableLayoutPanel graphPanel;
        private System.Windows.Forms.LinkLabel hyperlinkLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.LinkLabel multiplePath;
        private System.Windows.Forms.Label timeLabel;
    }
}

