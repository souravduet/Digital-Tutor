namespace FormulaPedia
{
    partial class conversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conversionForm));
            this.categoriComboBox = new System.Windows.Forms.ComboBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultConvertCextBox = new System.Windows.Forms.TextBox();
            this.fromConvertComboBox = new System.Windows.Forms.ComboBox();
            this.toConvertComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriComboBox
            // 
            this.categoriComboBox.FormattingEnabled = true;
            this.categoriComboBox.ItemHeight = 13;
            this.categoriComboBox.Items.AddRange(new object[] {
            "Length",
            "Temperature",
            "Digital Storage",
            "Number System",
            "Time",
            "Volume",
            "Area",
            "Mass",
            "Volume",
            "Speed",
            "Acceleration",
            "Angle"});
            this.categoriComboBox.Location = new System.Drawing.Point(75, 79);
            this.categoriComboBox.Name = "categoriComboBox";
            this.categoriComboBox.Size = new System.Drawing.Size(438, 21);
            this.categoriComboBox.TabIndex = 0;
            this.categoriComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriComboBox_SelectedIndexChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(75, 171);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(180, 20);
            this.fromTextBox.TabIndex = 1;
            this.fromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(283, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultConvertCextBox
            // 
            this.resultConvertCextBox.Location = new System.Drawing.Point(333, 170);
            this.resultConvertCextBox.Name = "resultConvertCextBox";
            this.resultConvertCextBox.Size = new System.Drawing.Size(180, 20);
            this.resultConvertCextBox.TabIndex = 3;
            this.resultConvertCextBox.TextChanged += new System.EventHandler(this.resultConvertCextBox_TextChanged);
            // 
            // fromConvertComboBox
            // 
            this.fromConvertComboBox.FormattingEnabled = true;
            this.fromConvertComboBox.Items.AddRange(new object[] {
            "Kilometer",
            "Meter",
            "Centimeter",
            "Millimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.fromConvertComboBox.Location = new System.Drawing.Point(75, 144);
            this.fromConvertComboBox.Name = "fromConvertComboBox";
            this.fromConvertComboBox.Size = new System.Drawing.Size(180, 21);
            this.fromConvertComboBox.TabIndex = 4;
            this.fromConvertComboBox.SelectedIndexChanged += new System.EventHandler(this.fromConvertComboBox_SelectedIndexChanged);
            // 
            // toConvertComboBox
            // 
            this.toConvertComboBox.FormattingEnabled = true;
            this.toConvertComboBox.Items.AddRange(new object[] {
            "Kilometer",
            "Meter",
            "Centimeter",
            "Millimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.toConvertComboBox.Location = new System.Drawing.Point(333, 143);
            this.toConvertComboBox.Name = "toConvertComboBox";
            this.toConvertComboBox.Size = new System.Drawing.Size(180, 21);
            this.toConvertComboBox.TabIndex = 5;
            this.toConvertComboBox.SelectedIndexChanged += new System.EventHandler(this.toConvertComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(333, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(552, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 33);
            this.closeButton.TabIndex = 10;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // conversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toConvertComboBox);
            this.Controls.Add(this.fromConvertComboBox);
            this.Controls.Add(this.resultConvertCextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.categoriComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conversionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaPedia - Conversions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.conversionForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoriComboBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultConvertCextBox;
        private System.Windows.Forms.ComboBox fromConvertComboBox;
        private System.Windows.Forms.ComboBox toConvertComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;

    }
}