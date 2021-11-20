using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];
        Color[,] TempArray = new Color[320, 240];

        //arr: array of averages, l: Left side, m: Middle, r: Right Side
        //not using merge sort. Old colde
        public void Merging(int[] arr, int l, int m, int r)
        {
            //Sizes of each side
            int SideL = m - 1;
            int SideR = r - m;

            //Temp arrays of both sides
            int[] Left = new int [SideL];
            int[] Right = new int[SideR];

            for (int i = 0; i < SideL; ++i)
                Left[i] = arr[l + i];

            for (int j = 0; j < SideR; ++j)
                Right[j] = arr[m + 1 + j];
            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int x = 0, y = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (x < SideL && y < SideR)
            {
                if (Left[x] <= Right[y])
                {
                    arr[k] = Left[x];
                    x++;
                }
                else
                {
                    arr[k] = Right[y];
                    y++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (x < SideL)
            {
                arr[k] = Left[x];
                x++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (y < SideR)
            {
                arr[k] = Right[y];
                y++;
                k++;
            }
        }
        public void Sort(int []arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // Merge the sorted halves 
                Merging(arr, l, m, r);
            }
        }

        public void Reset()
        {
            for (int i = 0; i < 320; i++)
                for (int k = 0; k < 240; k++)
                    ImageArray[i, k] = TempArray[i, k];
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

        //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    SetArayFromBitmap();
                    myStream.Close();
                }
            }

            
            for (int i = 0; i < 320; i++)
                for (int k = 0; k < 240; k++)
                    TempArray[i, k] = ImageArray[i, k];
        }
        private void SetBitmapFromAray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                 bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                
        }

        private void SetArayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        private void BtnRGREENB_Click(object sender, EventArgs e)
        {
            Reset();
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)         
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    //Displays with a green filter
                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnREDGB_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Red;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the red channel of a pixel and assign the color only to red channel

            for (int i = 0; i < iWidth; i++)           
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;

                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnRGBLUE_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the blue element of the color
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 320; i++)
                for (int k = 0; k < 240; k++)
                    ImageArray[i, k] = TempArray[i, k]; 
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Reset();
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Red,Green,Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Grabbing values of each colour
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 255 - Red, 255 -  Green, 255 - Blue);
                    ImageArray[i, j] = newColor;

                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnLighten_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Grabbing values of each colour
                    Red = col.R + 50;
                    Green = col.G + 30;
                    Blue = col.B + 10;
                    //Checking if the values are greater or less than 255
                    if(Blue > 255)  
                        Blue = 255;
                    if(Red > 255)
                        Red = 255;
                    if(Green > 255)
                        Green = 255;
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnDarken_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Grabbing values of each colour
                    Red = col.R - 50;
                    Green = col.G - 30;
                    Blue = col.B - 10;
                    //Checking if values are less than 0
                    if (Blue < 0)
                        Blue = 0;
                    if (Red < 0)
                        Red = 0;
                    if (Green < 0)
                        Green = 0;
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnSunset_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Swapped values of red and blue
                    Red = col.B;
                    Green = col.G;
                    Blue = col.R;

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnGreyscale_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue, Grey;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;
                    //Found the average of every colour. This average is the grey value that will be used
                    Grey = (col.R + col.G + col.B) / 3;
                    Color newColor = Color.FromArgb(255, Grey, Grey, Grey);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnPolarize_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red = 0, Green = 0, Blue = 0;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Grabbing values of each colour
                    Red = col.R + Red;
                    Green = col.G + Green;
                    Blue = col.B + Blue;
                }
            //Average of RGB
            int AvR = Red / (iWidth * iHeight);
            int AvG = Green / (iWidth * iHeight);
            int AvB = Blue / (iWidth * iHeight);

            //Processing the image
            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    if(Red < AvR)
                        Red = 0;
                    else
                        Red = 255;
                    if(Green < AvG)
                        Green = 0;
                    else
                        Green = 255;
                    if(Blue < AvB)
                        Blue = 0;
                    else
                        Blue = 255;
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnFHoriz_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < (iWidth/2); i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color TempColour = ImageArray[i, j];

                    ImageArray[i,j] = ImageArray[(iWidth - 1) - i, j]; // Equal to first half

                    ImageArray[(iWidth - 1) - i, j] = TempColour;

                }        
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnFVerti_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < (iHeight / 2); j++)
                {
                    Color TempColour = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[i, (iHeight - 1) - j];

                    ImageArray[i, (iHeight - 1) - j] = TempColour;

                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void Btn180Deg_Click(object sender, EventArgs e)
        {
            Reset();

            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < (iWidth / 2); i++)
                for (int j = 0; j < iHeight; j++)
                {
                    Color TempColour = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[(iWidth - 1) - i, j]; // Equal to first half

                    ImageArray[(iWidth - 1) - i, j] = TempColour;

                }
            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < (iHeight / 2); j++)
                {
                    Color TempColour = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[i, (iHeight - 1) - j];

                    ImageArray[i, (iHeight - 1) - j] = TempColour;

                }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
        private void BtnCornersSwitch_Click(object sender, EventArgs e)
        {
            //Reset();
            Color[,] TempArray = new Color[320, 240];

            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                    TempArray[i, j] = ImageArray[i, j]; ;

            for (int i = 0; i < (iWidth / 2); i++)
                for (int j = 0; j < (iHeight/2); j++)
                {
                    ImageArray[i, j] = TempArray[160 + i, 120 + j];
                    ImageArray[160 + i, 120 + j] = TempArray[i,j];

                }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnLeftScroll_Click(object sender, EventArgs e)
        {
            Color[,] TempArray = new Color[320, 240];
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            //Clone the array
            for (int i = 0; i < (iWidth); i++)
                for (int j = 0; j < (iHeight); j++)
                    TempArray[i, j] = ImageArray[i, j];                 
            //Shifting the array then copying it to the other side
            for(int i = 0; i < iWidth; i++)
                for(int j = 0; j < iHeight; j++)
                    if(i-20 < 0) 
                         ImageArray[i - 20 + 320, j] = TempArray[i, j];
                    else
                        ImageArray[i - 20, j] = ImageArray[i, j];
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnPixel_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            //Goes up to width and height
            for (int i = 0; i < (iWidth); i+=4)
                for (int j = 0; j < (iHeight); j+=4)
                    //Increases based on these values. It restricts the area. 4x4 square
                    for(int x = 0; x < 4; x++)
                        for(int y = 0; y < 4; y++)
                            ImageArray[i + x, j + y] = ImageArray[i, j];
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void BtnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            //Copied version of original
            Color[,] TempArray = new Color[320,240];

            //int Red, Green, Blue;
            int iAvgR, iAvgG, iAvgB;
            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < (iWidth); i++)
                for (int j = 0; j < (iHeight); j++)
                    TempArray[i, j] = ImageArray[i, j];
            
            for (int i = 0; i < (iWidth); i++)
                for (int j = 0; j < (iHeight); j++)
                    //Top Left Corner
                    if ((i - 1) == -1 && (j - 1) == -1)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i + 1, j].R + TempArray[i, j + 1].R + TempArray[i + 1, j + 1].R ) / 4;

                        iAvgG = (TempArray[i, j].G + TempArray[i + 1, j].G + TempArray[i, j + 1].G + TempArray[i + 1, j + 1].G) / 4;

                        iAvgB = (TempArray[i, j].B + TempArray[i + 1, j].B + TempArray[i, j + 1].B + TempArray[i + 1, j + 1].B) / 4;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    //Bottom Left Corner
                    else if ((i - 1) == -1 && (j + 1) == 240)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i + 1, j].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R) / 4;

                        iAvgG = (TempArray[i, j].G + TempArray[i + 1, j].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G) / 4;

                        iAvgB = (TempArray[i, j].B + TempArray[i + 1, j].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B) / 4;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    //Top Right Corner
                    else if ((i + 1) == 320 && (j - 1) == -1)
                    {

                        iAvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i, j + 1].R + TempArray[i - 1, j + 1].R) / 4;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i, j + 1].G + TempArray[i - 1, j + 1].G) / 4;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i, j + 1].B + TempArray[i - 1, j + 1].B) / 4;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;

                    }
                    //Bottom Right Corner
                    else if ((i + 1) == 320 && (j + 1) == 240)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i, j - 1].R + TempArray[i - 1, j - 1].R) / 4;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i, j - 1].G + TempArray[i - 1, j - 1].G) / 4;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i, j - 1].B + TempArray[i - 1, j - 1].B) / 4;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    //Top Row
                    else if((j-1) == -1)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i + 1, j].R
                               + TempArray[i, j + 1].R + TempArray[i + 1, j + 1].R + TempArray[i - 1, j + 1].R) / 6;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i + 1, j].G
                               + TempArray[i, j + 1].G + TempArray[i + 1, j + 1].G + TempArray[i - 1, j + 1].G) / 6;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i + 1, j].B
                               + TempArray[i, j + 1].B + TempArray[i + 1, j + 1].B + TempArray[i - 1, j + 1].B) / 6;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    
                    //Right Row
                    else if((i+1) == 320)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i, j - 1].R 
                               + TempArray[i, j + 1].R + TempArray[i - 1, j - 1].R + TempArray[i - 1, j + 1].R) / 6;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i, j - 1].G
                               + TempArray[i, j + 1].G + TempArray[i - 1, j - 1].G + TempArray[i - 1, j + 1].G) / 6;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i, j - 1].B
                               + TempArray[i, j + 1].B + TempArray[i - 1, j - 1].B + TempArray[i - 1, j + 1].B) / 6;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    
                    //Bottom Row
                    else if((j+1) == 240)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i-1,j-1].R + TempArray[i, j-1].R 
                               + TempArray[i+1,j-1].R + TempArray[i-1,j].R + TempArray[i+1,j].R) / 6;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i + 1, j].G
                               + TempArray[i, j - 1].G + TempArray[i - 1, j - 1].G + TempArray[i + 1, j - 1].G) / 6;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i + 1, j].B
                               + TempArray[i, j - 1].B + TempArray[i - 1, j - 1].B + TempArray[i + 1, j - 1].B) / 6;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    
                    //Left Row
                    else if ((i - 1) == -1)
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i + 1, j].R + TempArray[i, j - 1].R
                               + TempArray[i, j + 1].R + TempArray[i + 1, j + 1].R + TempArray[i + 1, j - 1].R) / 6;

                        iAvgG = (TempArray[i, j].G + TempArray[i + 1, j].G + TempArray[i, j - 1].G
                               + TempArray[i, j + 1].G + TempArray[i + 1, j + 1].G + TempArray[i + 1, j - 1].G) / 6;

                        iAvgB = (TempArray[i, j].B + TempArray[i + 1, j].B + TempArray[i, j - 1].B
                               + TempArray[i, j + 1].B + TempArray[i + 1, j + 1].B + TempArray[i + 1, j - 1].B) / 6;

                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
                    //Center
                    else
                    {
                        iAvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i + 1, j].R
                           + TempArray[i, j - 1].R + TempArray[i, j + 1].R + TempArray[i - 1, j - 1].R
                           + TempArray[i + 1, j + 1].R + TempArray[i + 1, j - 1].R + TempArray[i - 1, j + 1].R) / 9;

                        iAvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i + 1, j].G
                               + TempArray[i, j - 1].G + TempArray[i, j + 1].G + TempArray[i - 1, j - 1].G
                               + TempArray[i + 1, j + 1].G + TempArray[i + 1, j - 1].G + TempArray[i - 1, j + 1].G) / 9;

                        iAvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i + 1, j].B
                               + TempArray[i, j - 1].B + TempArray[i, j + 1].B + TempArray[i - 1, j - 1].B
                               + TempArray[i + 1, j + 1].B + TempArray[i + 1, j - 1].B + TempArray[i - 1, j + 1].B) / 9;
                        Color newCol = Color.FromArgb(255, iAvgR, iAvgG, iAvgB);
                        ImageArray[i, j] = newCol;
                    }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
           // int Red, Green, Blue,Grey;
            int iWidth = 320, iHeight = 240;
       
            // Outer loop iterating through the elements of the array
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i,j];

                    int iValue = i - 1;
                    // copy the element we want to insert in a temp variable
                    int k = i - 1;
                    // Inner Loop moving from R->L through the items to the
                    // left of the iValue in order to make room for insertion
                    while (k >= 0)
                    {
                        if (ImageArray[k,j].B > col.B)
                            ImageArray[k + 1, j] = ImageArray[k,j];//move one space to the right
                        else
                            break;
                        k = k - 1;
                    }
                    ImageArray[k + 1,j] = col; //insert the Temparray in the correct location
                }
               
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }
        private void PicImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (bitmapImage == null)
                return;
            int iWidth = 320, iHeight = 240;

            Color[,] TempArray = new Color[320, 240];

            int xpos = 160 - 80;
            int ypos = 120 - 60;

            //Usage: Restrictions
            int xCounter = 0;
            int yCounter = 0;

            //pixelate
            //Goes up to width and height
            for (int i = 0; i < (iWidth); i += 2)
            {
                for (int j = 0; j < (iHeight); j += 2)
                {
                    //Increases based on these values. It restricts the area. 2x2 square
                    for (int x = 0; x < 2; x++)
                        for (int y = 0; y < 2; y++)
                            //restriction
                            if (xCounter < 160 && yCounter < 120)
                                TempArray[i + x, j + y] = ImageArray[xpos + xCounter, ypos + yCounter];
                    yCounter++;
                }
                xCounter++;
                //sets to zero it can do it again for other lines
                yCounter = 0;
            }
            //Copy Array
            for (int i = 0; i < iWidth; i++)
                for (int j = 0; j < iHeight; j++)
                    ImageArray[i, j] = TempArray[i, j];

            SetBitmapFromAray();
            picImage.Image = bitmapImage;


        }
    }
}
