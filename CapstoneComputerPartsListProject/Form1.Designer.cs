namespace CapstoneComputerPartsListProject
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
            this.btn_addMultiline = new System.Windows.Forms.Button();
            this.lbl_mainTitle = new System.Windows.Forms.Label();
            this.txtBox_multilinePart = new System.Windows.Forms.TextBox();
            this.lbl_multiline = new System.Windows.Forms.Label();
            this.lbl_userWarning = new System.Windows.Forms.Label();
            this.rtb_partListReader = new System.Windows.Forms.RichTextBox();
            this.btn_calculatorWindow = new System.Windows.Forms.Button();
            this.lbl_partlistRead = new System.Windows.Forms.Label();
            this.listbox_ComputerParts = new System.Windows.Forms.ListBox();
            this.lbl_partSelected = new System.Windows.Forms.Label();
            this.lbl_moreOptions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.png_TxtFile = new System.Windows.Forms.PictureBox();
            this.png_Computer = new System.Windows.Forms.PictureBox();
            this.btn_closeProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.png_TxtFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.png_Computer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addMultiline
            // 
            this.btn_addMultiline.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMultiline.ForeColor = System.Drawing.Color.Black;
            this.btn_addMultiline.Location = new System.Drawing.Point(12, 583);
            this.btn_addMultiline.Name = "btn_addMultiline";
            this.btn_addMultiline.Size = new System.Drawing.Size(178, 34);
            this.btn_addMultiline.TabIndex = 0;
            this.btn_addMultiline.Text = "Add Part to File";
            this.btn_addMultiline.UseVisualStyleBackColor = true;
            this.btn_addMultiline.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_mainTitle
            // 
            this.lbl_mainTitle.AutoSize = true;
            this.lbl_mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mainTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Underline);
            this.lbl_mainTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_mainTitle.Location = new System.Drawing.Point(347, -7);
            this.lbl_mainTitle.Name = "lbl_mainTitle";
            this.lbl_mainTitle.Size = new System.Drawing.Size(590, 44);
            this.lbl_mainTitle.TabIndex = 1;
            this.lbl_mainTitle.Text = "Computer Part List Application";
            this.lbl_mainTitle.Click += new System.EventHandler(this.lbl_mainTitle_Click);
            // 
            // txtBox_multilinePart
            // 
            this.txtBox_multilinePart.Location = new System.Drawing.Point(12, 230);
            this.txtBox_multilinePart.Multiline = true;
            this.txtBox_multilinePart.Name = "txtBox_multilinePart";
            this.txtBox_multilinePart.Size = new System.Drawing.Size(561, 167);
            this.txtBox_multilinePart.TabIndex = 2;
            this.txtBox_multilinePart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_multiline
            // 
            this.lbl_multiline.AutoSize = true;
            this.lbl_multiline.BackColor = System.Drawing.Color.Transparent;
            this.lbl_multiline.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_multiline.ForeColor = System.Drawing.Color.Black;
            this.lbl_multiline.Location = new System.Drawing.Point(12, 209);
            this.lbl_multiline.Name = "lbl_multiline";
            this.lbl_multiline.Size = new System.Drawing.Size(242, 18);
            this.lbl_multiline.TabIndex = 3;
            this.lbl_multiline.Text = "Part and HyperLink Entry Box";
            this.lbl_multiline.Click += new System.EventHandler(this.lbl_multiline_Click);
            // 
            // lbl_userWarning
            // 
            this.lbl_userWarning.AutoSize = true;
            this.lbl_userWarning.Location = new System.Drawing.Point(288, 400);
            this.lbl_userWarning.Name = "lbl_userWarning";
            this.lbl_userWarning.Size = new System.Drawing.Size(266, 65);
            this.lbl_userWarning.TabIndex = 4;
            this.lbl_userWarning.Text = "*note: \r\nThis text box is a multi-line entry, meaning you can \r\nenter the part mo" +
    "del name, hyperlink, and price of your \r\ncomputer part as in the example image t" +
    "o the right.\r\n\r\n";
            // 
            // rtb_partListReader
            // 
            this.rtb_partListReader.Location = new System.Drawing.Point(669, 230);
            this.rtb_partListReader.Name = "rtb_partListReader";
            this.rtb_partListReader.Size = new System.Drawing.Size(592, 399);
            this.rtb_partListReader.TabIndex = 5;
            this.rtb_partListReader.Text = "";
            // 
            // btn_calculatorWindow
            // 
            this.btn_calculatorWindow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculatorWindow.Location = new System.Drawing.Point(1181, 34);
            this.btn_calculatorWindow.Name = "btn_calculatorWindow";
            this.btn_calculatorWindow.Size = new System.Drawing.Size(178, 34);
            this.btn_calculatorWindow.TabIndex = 6;
            this.btn_calculatorWindow.Text = "Price Calculator";
            this.btn_calculatorWindow.UseVisualStyleBackColor = true;
            this.btn_calculatorWindow.Click += new System.EventHandler(this.btn_calculatorWindow_Click);
            // 
            // lbl_partlistRead
            // 
            this.lbl_partlistRead.AutoSize = true;
            this.lbl_partlistRead.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_partlistRead.Location = new System.Drawing.Point(666, 209);
            this.lbl_partlistRead.Name = "lbl_partlistRead";
            this.lbl_partlistRead.Size = new System.Drawing.Size(134, 18);
            this.lbl_partlistRead.TabIndex = 10;
            this.lbl_partlistRead.Text = "Part List Output";
            this.lbl_partlistRead.Click += new System.EventHandler(this.lbl_partlistRead_Click);
            // 
            // listbox_ComputerParts
            // 
            this.listbox_ComputerParts.FormattingEnabled = true;
            this.listbox_ComputerParts.Items.AddRange(new object[] {
            "Processor",
            "Graphics Card",
            "RAM",
            "Motherboard",
            "Power Supply Unit",
            "Storage (HDD)",
            "Storage (SSD) ",
            "Case",
            "Monitor ",
            "Peripherals",
            "Software"});
            this.listbox_ComputerParts.Location = new System.Drawing.Point(12, 417);
            this.listbox_ComputerParts.Name = "listbox_ComputerParts";
            this.listbox_ComputerParts.Size = new System.Drawing.Size(178, 160);
            this.listbox_ComputerParts.TabIndex = 12;
            this.listbox_ComputerParts.SelectedIndexChanged += new System.EventHandler(this.listbox_ComputerParts_SelectedIndexChanged);
            // 
            // lbl_partSelected
            // 
            this.lbl_partSelected.AutoSize = true;
            this.lbl_partSelected.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partSelected.Location = new System.Drawing.Point(12, 400);
            this.lbl_partSelected.Name = "lbl_partSelected";
            this.lbl_partSelected.Size = new System.Drawing.Size(103, 14);
            this.lbl_partSelected.TabIndex = 13;
            this.lbl_partSelected.Text = "Select Part Type\r\n";
            // 
            // lbl_moreOptions
            // 
            this.lbl_moreOptions.AutoSize = true;
            this.lbl_moreOptions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moreOptions.Location = new System.Drawing.Point(1182, 9);
            this.lbl_moreOptions.Name = "lbl_moreOptions";
            this.lbl_moreOptions.Size = new System.Drawing.Size(79, 12);
            this.lbl_moreOptions.TabIndex = 14;
            this.lbl_moreOptions.Text = "More Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // png_TxtFile
            // 
            this.png_TxtFile.Image = ((System.Drawing.Image)(resources.GetObject("png_TxtFile.Image")));
            this.png_TxtFile.Location = new System.Drawing.Point(669, 110);
            this.png_TxtFile.Name = "png_TxtFile";
            this.png_TxtFile.Size = new System.Drawing.Size(100, 89);
            this.png_TxtFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.png_TxtFile.TabIndex = 8;
            this.png_TxtFile.TabStop = false;
            // 
            // png_Computer
            // 
            this.png_Computer.Image = ((System.Drawing.Image)(resources.GetObject("png_Computer.Image")));
            this.png_Computer.Location = new System.Drawing.Point(15, 110);
            this.png_Computer.Name = "png_Computer";
            this.png_Computer.Size = new System.Drawing.Size(114, 89);
            this.png_Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.png_Computer.TabIndex = 7;
            this.png_Computer.TabStop = false;
            // 
            // btn_closeProgram
            // 
            this.btn_closeProgram.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_closeProgram.Location = new System.Drawing.Point(1184, 94);
            this.btn_closeProgram.Name = "btn_closeProgram";
            this.btn_closeProgram.Size = new System.Drawing.Size(175, 34);
            this.btn_closeProgram.TabIndex = 15;
            this.btn_closeProgram.Text = "Close Program";
            this.btn_closeProgram.UseVisualStyleBackColor = true;
            this.btn_closeProgram.Click += new System.EventHandler(this.btn_closeProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1374, 666);
            this.Controls.Add(this.btn_closeProgram);
            this.Controls.Add(this.lbl_moreOptions);
            this.Controls.Add(this.lbl_partSelected);
            this.Controls.Add(this.listbox_ComputerParts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_partlistRead);
            this.Controls.Add(this.png_TxtFile);
            this.Controls.Add(this.png_Computer);
            this.Controls.Add(this.btn_calculatorWindow);
            this.Controls.Add(this.rtb_partListReader);
            this.Controls.Add(this.lbl_userWarning);
            this.Controls.Add(this.lbl_multiline);
            this.Controls.Add(this.txtBox_multilinePart);
            this.Controls.Add(this.lbl_mainTitle);
            this.Controls.Add(this.btn_addMultiline);
            this.Name = "Form1";
            this.Text = "Computer Part List Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.png_TxtFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.png_Computer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addMultiline;
        private System.Windows.Forms.Label lbl_mainTitle;
        private System.Windows.Forms.TextBox txtBox_multilinePart;
        private System.Windows.Forms.Label lbl_multiline;
        private System.Windows.Forms.Label lbl_userWarning;
        private System.Windows.Forms.RichTextBox rtb_partListReader;
        private System.Windows.Forms.Button btn_calculatorWindow;
        private System.Windows.Forms.PictureBox png_Computer;
        private System.Windows.Forms.PictureBox png_TxtFile;
        private System.Windows.Forms.Label lbl_partlistRead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listbox_ComputerParts;
        private System.Windows.Forms.Label lbl_partSelected;
        private System.Windows.Forms.Label lbl_moreOptions;
        private System.Windows.Forms.Button btn_closeProgram;
    }
}

