namespace ImageProcessing
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
            this.btnRGREENB = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnREDGB = new System.Windows.Forms.Button();
            this.btnRGBLUE = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnGreyscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnFHoriz = new System.Windows.Forms.Button();
            this.btnFVerti = new System.Windows.Forms.Button();
            this.btn180Deg = new System.Windows.Forms.Button();
            this.btnCornersSwitch = new System.Windows.Forms.Button();
            this.btnLeftScroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRGREENB
            // 
            this.btnRGREENB.Location = new System.Drawing.Point(506, 116);
            this.btnRGREENB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRGREENB.Name = "btnRGREENB";
            this.btnRGREENB.Size = new System.Drawing.Size(112, 35);
            this.btnRGREENB.TabIndex = 5;
            this.btnRGREENB.Text = "Green";
            this.btnRGREENB.UseVisualStyleBackColor = true;
            this.btnRGREENB.Click += new System.EventHandler(this.BtnRGREENB_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(506, 26);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(18, 18);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(480, 369);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            this.picImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicImage_MouseClick);
            // 
            // btnREDGB
            // 
            this.btnREDGB.Location = new System.Drawing.Point(506, 71);
            this.btnREDGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnREDGB.Name = "btnREDGB";
            this.btnREDGB.Size = new System.Drawing.Size(112, 35);
            this.btnREDGB.TabIndex = 6;
            this.btnREDGB.Text = "Red";
            this.btnREDGB.UseVisualStyleBackColor = true;
            this.btnREDGB.Click += new System.EventHandler(this.BtnREDGB_Click);
            // 
            // btnRGBLUE
            // 
            this.btnRGBLUE.Location = new System.Drawing.Point(506, 161);
            this.btnRGBLUE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRGBLUE.Name = "btnRGBLUE";
            this.btnRGBLUE.Size = new System.Drawing.Size(112, 35);
            this.btnRGBLUE.TabIndex = 7;
            this.btnRGBLUE.Text = "Blue";
            this.btnRGBLUE.UseVisualStyleBackColor = true;
            this.btnRGBLUE.Click += new System.EventHandler(this.BtnRGBLUE_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 397);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(506, 206);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(112, 35);
            this.btnNegative.TabIndex = 9;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(506, 251);
            this.btnLighten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(112, 35);
            this.btnLighten.TabIndex = 10;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.BtnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(506, 296);
            this.btnDarken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(112, 35);
            this.btnDarken.TabIndex = 11;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.BtnDarken_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(506, 341);
            this.btnSunset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(112, 35);
            this.btnSunset.TabIndex = 12;
            this.btnSunset.Text = "Sunset";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.BtnSunset_Click);
            // 
            // btnGreyscale
            // 
            this.btnGreyscale.Location = new System.Drawing.Point(506, 386);
            this.btnGreyscale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGreyscale.Name = "btnGreyscale";
            this.btnGreyscale.Size = new System.Drawing.Size(112, 35);
            this.btnGreyscale.TabIndex = 13;
            this.btnGreyscale.Text = "Greyscale";
            this.btnGreyscale.UseVisualStyleBackColor = true;
            this.btnGreyscale.Click += new System.EventHandler(this.BtnGreyscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(626, 296);
            this.btnPolarize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(112, 35);
            this.btnPolarize.TabIndex = 14;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.BtnPolarize_Click);
            // 
            // btnFHoriz
            // 
            this.btnFHoriz.Location = new System.Drawing.Point(626, 251);
            this.btnFHoriz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFHoriz.Name = "btnFHoriz";
            this.btnFHoriz.Size = new System.Drawing.Size(112, 35);
            this.btnFHoriz.TabIndex = 15;
            this.btnFHoriz.Text = "Flip Horiz";
            this.btnFHoriz.UseVisualStyleBackColor = true;
            this.btnFHoriz.Click += new System.EventHandler(this.BtnFHoriz_Click);
            // 
            // btnFVerti
            // 
            this.btnFVerti.Location = new System.Drawing.Point(626, 206);
            this.btnFVerti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFVerti.Name = "btnFVerti";
            this.btnFVerti.Size = new System.Drawing.Size(112, 35);
            this.btnFVerti.TabIndex = 16;
            this.btnFVerti.Text = "Flip Verti";
            this.btnFVerti.UseVisualStyleBackColor = true;
            this.btnFVerti.Click += new System.EventHandler(this.BtnFVerti_Click);
            // 
            // btn180Deg
            // 
            this.btn180Deg.Location = new System.Drawing.Point(626, 161);
            this.btn180Deg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn180Deg.Name = "btn180Deg";
            this.btn180Deg.Size = new System.Drawing.Size(112, 35);
            this.btn180Deg.TabIndex = 17;
            this.btn180Deg.Text = "180 Deg";
            this.btn180Deg.UseVisualStyleBackColor = true;
            this.btn180Deg.Click += new System.EventHandler(this.Btn180Deg_Click);
            // 
            // btnCornersSwitch
            // 
            this.btnCornersSwitch.Location = new System.Drawing.Point(790, 91);
            this.btnCornersSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCornersSwitch.Name = "btnCornersSwitch";
            this.btnCornersSwitch.Size = new System.Drawing.Size(112, 35);
            this.btnCornersSwitch.TabIndex = 18;
            this.btnCornersSwitch.Text = "Corners";
            this.btnCornersSwitch.UseVisualStyleBackColor = true;
            this.btnCornersSwitch.Click += new System.EventHandler(this.BtnCornersSwitch_Click);
            // 
            // btnLeftScroll
            // 
            this.btnLeftScroll.Location = new System.Drawing.Point(790, 161);
            this.btnLeftScroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeftScroll.Name = "btnLeftScroll";
            this.btnLeftScroll.Size = new System.Drawing.Size(112, 35);
            this.btnLeftScroll.TabIndex = 21;
            this.btnLeftScroll.Text = "<---------";
            this.btnLeftScroll.UseVisualStyleBackColor = true;
            this.btnLeftScroll.Click += new System.EventHandler(this.BtnLeftScroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Scrolling";
            // 
            // btnPixel
            // 
            this.btnPixel.Location = new System.Drawing.Point(790, 206);
            this.btnPixel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(112, 35);
            this.btnPixel.TabIndex = 23;
            this.btnPixel.Text = "Pixelate";
            this.btnPixel.UseVisualStyleBackColor = true;
            this.btnPixel.Click += new System.EventHandler(this.BtnPixel_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(790, 251);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(112, 35);
            this.btnBlur.TabIndex = 24;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.BtnBlur_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(790, 296);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 35);
            this.btnSort.TabIndex = 25;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 446);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnPixel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeftScroll);
            this.Controls.Add(this.btnCornersSwitch);
            this.Controls.Add(this.btn180Deg);
            this.Controls.Add(this.btnFVerti);
            this.Controls.Add(this.btnFHoriz);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnGreyscale);
            this.Controls.Add(this.btnSunset);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRGBLUE);
            this.Controls.Add(this.btnREDGB);
            this.Controls.Add(this.btnRGREENB);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRGREENB;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnREDGB;
        private System.Windows.Forms.Button btnRGBLUE;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnGreyscale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnFHoriz;
        private System.Windows.Forms.Button btnFVerti;
        private System.Windows.Forms.Button btn180Deg;
        private System.Windows.Forms.Button btnCornersSwitch;
        private System.Windows.Forms.Button btnLeftScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSort;
    }
}

