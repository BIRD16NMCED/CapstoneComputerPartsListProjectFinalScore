namespace CapstoneComputerPartsListProject
{
    partial class CalculatorForm
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
            System.Windows.Forms.Label lbl_operandOne;
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_addPartPrice = new System.Windows.Forms.Button();
            this.txtbox_OperandOne = new System.Windows.Forms.TextBox();
            this.txtbox_OperandTwo = new System.Windows.Forms.TextBox();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.lbl_operandTwo = new System.Windows.Forms.Label();
            this.btn_addPriceToFile = new System.Windows.Forms.Button();
            this.lbl_priceCalc = new System.Windows.Forms.Label();
            this.txtbox_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txtbox_workstationPriceEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_filePriceOutput = new System.Windows.Forms.RichTextBox();
            this.txtbox_totalWorkstationsUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_WorkstationUnitLabel = new System.Windows.Forms.TextBox();
            this.lbl_EnterLabel = new System.Windows.Forms.Label();
            this.lbl_partlistPriceOutput = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_txtPNG = new System.Windows.Forms.PictureBox();
            lbl_operandOne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_txtPNG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_operandOne
            // 
            lbl_operandOne.AutoSize = true;
            lbl_operandOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_operandOne.Location = new System.Drawing.Point(41, 156);
            lbl_operandOne.Name = "lbl_operandOne";
            lbl_operandOne.Size = new System.Drawing.Size(90, 14);
            lbl_operandOne.TabIndex = 4;
            lbl_operandOne.Text = "Operand One:";
            lbl_operandOne.Click += new System.EventHandler(this.lbl_operandOne_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_Close.Location = new System.Drawing.Point(950, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(169, 36);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close Program";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_addPartPrice
            // 
            this.btn_addPartPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_addPartPrice.Location = new System.Drawing.Point(44, 328);
            this.btn_addPartPrice.Name = "btn_addPartPrice";
            this.btn_addPartPrice.Size = new System.Drawing.Size(169, 36);
            this.btn_addPartPrice.TabIndex = 1;
            this.btn_addPartPrice.Text = "Add Part Price";
            this.btn_addPartPrice.UseVisualStyleBackColor = true;
            this.btn_addPartPrice.Click += new System.EventHandler(this.btn_addPartPrice_Click);
            // 
            // txtbox_OperandOne
            // 
            this.txtbox_OperandOne.Location = new System.Drawing.Point(44, 222);
            this.txtbox_OperandOne.Name = "txtbox_OperandOne";
            this.txtbox_OperandOne.Size = new System.Drawing.Size(169, 20);
            this.txtbox_OperandOne.TabIndex = 2;
            // 
            // txtbox_OperandTwo
            // 
            this.txtbox_OperandTwo.Location = new System.Drawing.Point(44, 173);
            this.txtbox_OperandTwo.Name = "txtbox_OperandTwo";
            this.txtbox_OperandTwo.Size = new System.Drawing.Size(169, 20);
            this.txtbox_OperandTwo.TabIndex = 2;
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_multiply.Location = new System.Drawing.Point(44, 387);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(169, 36);
            this.btn_multiply.TabIndex = 1;
            this.btn_multiply.Text = "Multiply Total";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // lbl_operandTwo
            // 
            this.lbl_operandTwo.AutoSize = true;
            this.lbl_operandTwo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operandTwo.Location = new System.Drawing.Point(41, 205);
            this.lbl_operandTwo.Name = "lbl_operandTwo";
            this.lbl_operandTwo.Size = new System.Drawing.Size(91, 14);
            this.lbl_operandTwo.TabIndex = 4;
            this.lbl_operandTwo.Text = "Operand Two:";
            this.lbl_operandTwo.Click += new System.EventHandler(this.lbl_operandOne_Click);
            // 
            // btn_addPriceToFile
            // 
            this.btn_addPriceToFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_addPriceToFile.Location = new System.Drawing.Point(318, 328);
            this.btn_addPriceToFile.Name = "btn_addPriceToFile";
            this.btn_addPriceToFile.Size = new System.Drawing.Size(169, 36);
            this.btn_addPriceToFile.TabIndex = 1;
            this.btn_addPriceToFile.Text = "Add Price to File";
            this.btn_addPriceToFile.UseVisualStyleBackColor = true;
            this.btn_addPriceToFile.Click += new System.EventHandler(this.btn_addToListBox_Click);
            // 
            // lbl_priceCalc
            // 
            this.lbl_priceCalc.AutoSize = true;
            this.lbl_priceCalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Underline);
            this.lbl_priceCalc.Location = new System.Drawing.Point(114, 3);
            this.lbl_priceCalc.Name = "lbl_priceCalc";
            this.lbl_priceCalc.Size = new System.Drawing.Size(745, 40);
            this.lbl_priceCalc.TabIndex = 6;
            this.lbl_priceCalc.Text = "Workstation Price Calculator and Price List";
            // 
            // txtbox_Total
            // 
            this.txtbox_Total.Location = new System.Drawing.Point(44, 280);
            this.txtbox_Total.Name = "txtbox_Total";
            this.txtbox_Total.Size = new System.Drawing.Size(169, 20);
            this.txtbox_Total.TabIndex = 2;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(41, 263);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(40, 14);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Total:";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_operandOne_Click);
            // 
            // txtbox_workstationPriceEntry
            // 
            this.txtbox_workstationPriceEntry.Location = new System.Drawing.Point(318, 173);
            this.txtbox_workstationPriceEntry.Name = "txtbox_workstationPriceEntry";
            this.txtbox_workstationPriceEntry.Size = new System.Drawing.Size(219, 20);
            this.txtbox_workstationPriceEntry.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Workstation Price to File";
            // 
            // rtb_filePriceOutput
            // 
            this.rtb_filePriceOutput.Location = new System.Drawing.Point(642, 173);
            this.rtb_filePriceOutput.Name = "rtb_filePriceOutput";
            this.rtb_filePriceOutput.Size = new System.Drawing.Size(447, 247);
            this.rtb_filePriceOutput.TabIndex = 9;
            this.rtb_filePriceOutput.Text = "";
            // 
            // txtbox_totalWorkstationsUnits
            // 
            this.txtbox_totalWorkstationsUnits.Location = new System.Drawing.Point(318, 222);
            this.txtbox_totalWorkstationsUnits.Name = "txtbox_totalWorkstationsUnits";
            this.txtbox_totalWorkstationsUnits.Size = new System.Drawing.Size(219, 20);
            this.txtbox_totalWorkstationsUnits.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Units (i.e. 1-1000)\r\n";
            // 
            // txtbox_WorkstationUnitLabel
            // 
            this.txtbox_WorkstationUnitLabel.Location = new System.Drawing.Point(320, 280);
            this.txtbox_WorkstationUnitLabel.Name = "txtbox_WorkstationUnitLabel";
            this.txtbox_WorkstationUnitLabel.Size = new System.Drawing.Size(219, 20);
            this.txtbox_WorkstationUnitLabel.TabIndex = 7;
            // 
            // lbl_EnterLabel
            // 
            this.lbl_EnterLabel.AutoSize = true;
            this.lbl_EnterLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterLabel.Location = new System.Drawing.Point(318, 249);
            this.lbl_EnterLabel.Name = "lbl_EnterLabel";
            this.lbl_EnterLabel.Size = new System.Drawing.Size(171, 28);
            this.lbl_EnterLabel.TabIndex = 11;
            this.lbl_EnterLabel.Text = "Add Label to Price \r\n(i.e. Factory Office 1st Floor)";
            // 
            // lbl_partlistPriceOutput
            // 
            this.lbl_partlistPriceOutput.AutoSize = true;
            this.lbl_partlistPriceOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partlistPriceOutput.Location = new System.Drawing.Point(639, 156);
            this.lbl_partlistPriceOutput.Name = "lbl_partlistPriceOutput";
            this.lbl_partlistPriceOutput.Size = new System.Drawing.Size(128, 14);
            this.lbl_partlistPriceOutput.TabIndex = 8;
            this.lbl_partlistPriceOutput.Text = "Partlist Price Output:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapstoneComputerPartsListProject.Properties.Resources.WorkstationExNew;
            this.pictureBox2.Location = new System.Drawing.Point(318, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapstoneComputerPartsListProject.Properties.Resources.fe1680d9e81708fd79fc27b791401673_flat_calculator_icon_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(44, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_txtPNG
            // 
            this.ptb_txtPNG.Image = global::CapstoneComputerPartsListProject.Properties.Resources.txtFileLogo;
            this.ptb_txtPNG.Location = new System.Drawing.Point(642, 81);
            this.ptb_txtPNG.Name = "ptb_txtPNG";
            this.ptb_txtPNG.Size = new System.Drawing.Size(78, 72);
            this.ptb_txtPNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_txtPNG.TabIndex = 10;
            this.ptb_txtPNG.TabStop = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1131, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_EnterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptb_txtPNG);
            this.Controls.Add(this.rtb_filePriceOutput);
            this.Controls.Add(this.lbl_partlistPriceOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_WorkstationUnitLabel);
            this.Controls.Add(this.txtbox_totalWorkstationsUnits);
            this.Controls.Add(this.txtbox_workstationPriceEntry);
            this.Controls.Add(this.lbl_priceCalc);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_operandTwo);
            this.Controls.Add(lbl_operandOne);
            this.Controls.Add(this.txtbox_Total);
            this.Controls.Add(this.txtbox_OperandTwo);
            this.Controls.Add(this.txtbox_OperandOne);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_addPriceToFile);
            this.Controls.Add(this.btn_addPartPrice);
            this.Controls.Add(this.btn_Close);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_txtPNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_addPartPrice;
        private System.Windows.Forms.TextBox txtbox_OperandOne;
        private System.Windows.Forms.TextBox txtbox_OperandTwo;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Label lbl_operandTwo;
        private System.Windows.Forms.Button btn_addPriceToFile;
        private System.Windows.Forms.Label lbl_priceCalc;
        private System.Windows.Forms.TextBox txtbox_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txtbox_workstationPriceEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_filePriceOutput;
        private System.Windows.Forms.PictureBox ptb_txtPNG;
        private System.Windows.Forms.TextBox txtbox_totalWorkstationsUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_WorkstationUnitLabel;
        private System.Windows.Forms.Label lbl_EnterLabel;
        private System.Windows.Forms.Label lbl_partlistPriceOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}