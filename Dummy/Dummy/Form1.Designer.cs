
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
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.pathBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.findAllCheck = new System.Windows.Forms.CheckBox();
            this.bfsBtn = new System.Windows.Forms.RadioButton();
            this.dfsBtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.RoyalBlue;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(37, 16);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(205, 42);
            this.title.TabIndex = 0;
            this.title.Text = "search.me";
            // 
            // inputTitle
            // 
            this.inputTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitle.Location = new System.Drawing.Point(45, 128);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.ReadOnly = true;
            this.inputTitle.Size = new System.Drawing.Size(92, 23);
            this.inputTitle.TabIndex = 0;
            this.inputTitle.Text = "Input";
            // 
            // fileNameInput
            // 
            this.fileNameInput.AccessibleDescription = "";
            this.fileNameInput.BackColor = System.Drawing.Color.White;
            this.fileNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameInput.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameInput.Location = new System.Drawing.Point(45, 272);
            this.fileNameInput.Multiline = true;
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(311, 25);
            this.fileNameInput.TabIndex = 0;
            this.fileNameInput.WordWrap = false;
            this.fileNameInput.TextChanged += new System.EventHandler(this.fileNameInput_TextChanged);
            // 
            // pathBtn
            // 
            this.pathBtn.BackColor = System.Drawing.Color.Transparent;
            this.pathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBtn.Location = new System.Drawing.Point(45, 190);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(138, 34);
            this.pathBtn.TabIndex = 1;
            this.pathBtn.Text = "Choose Folder...";
            this.pathBtn.UseVisualStyleBackColor = false;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pathBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.Location = new System.Drawing.Point(189, 198);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(167, 16);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "No File Choosen";
            // 
            // findAllCheck
            // 
            this.findAllCheck.AutoSize = true;
            this.findAllCheck.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllCheck.ForeColor = System.Drawing.Color.Black;
            this.findAllCheck.Location = new System.Drawing.Point(45, 303);
            this.findAllCheck.Name = "findAllCheck";
            this.findAllCheck.Size = new System.Drawing.Size(150, 22);
            this.findAllCheck.TabIndex = 2;
            this.findAllCheck.Text = "Find all occurence";
            this.findAllCheck.UseVisualStyleBackColor = true;
            this.findAllCheck.CheckedChanged += new System.EventHandler(this.findAllCheck_CheckedChanged);
            // 
            // bfsBtn
            // 
            this.bfsBtn.AutoSize = true;
            this.bfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfsBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfsBtn.ForeColor = System.Drawing.Color.Black;
            this.bfsBtn.Location = new System.Drawing.Point(45, 372);
            this.bfsBtn.Name = "bfsBtn";
            this.bfsBtn.Size = new System.Drawing.Size(55, 22);
            this.bfsBtn.TabIndex = 3;
            this.bfsBtn.TabStop = true;
            this.bfsBtn.Text = "BFS";
            this.bfsBtn.UseVisualStyleBackColor = true;
            this.bfsBtn.CheckedChanged += new System.EventHandler(this.bfsBtn_CheckedChanged);
            // 
            // dfsBtn
            // 
            this.dfsBtn.AutoSize = true;
            this.dfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dfsBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsBtn.ForeColor = System.Drawing.Color.Black;
            this.dfsBtn.Location = new System.Drawing.Point(128, 372);
            this.dfsBtn.Name = "dfsBtn";
            this.dfsBtn.Size = new System.Drawing.Size(56, 22);
            this.dfsBtn.TabIndex = 3;
            this.dfsBtn.TabStop = true;
            this.dfsBtn.Text = "DFS";
            this.dfsBtn.UseVisualStyleBackColor = true;
            this.dfsBtn.CheckedChanged += new System.EventHandler(this.dfsBtn_CheckedChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(45, 419);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 52);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "search!";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(439, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 305);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(439, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Output";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(45, 166);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(314, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Choose starting directory";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(45, 245);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(314, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Input file name";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(45, 347);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(314, 26);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Searching method";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(-1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 88);
            this.panel2.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Location = new System.Drawing.Point(37, 48);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(376, 24);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "ready to search your file as fast as the wind";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(941, 534);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dfsBtn);
            this.Controls.Add(this.bfsBtn);
            this.Controls.Add(this.findAllCheck);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Dummy";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox fileNameInput;
        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.CheckBox findAllCheck;
        private System.Windows.Forms.RadioButton bfsBtn;
        private System.Windows.Forms.RadioButton dfsBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
    }
}

