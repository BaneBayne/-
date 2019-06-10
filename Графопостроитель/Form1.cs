using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Графопостроитель
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(0, 1);
            chart1.Series[0].Points.AddXY(1, 1);
            chart1.Series[0].Points.AddXY(2, 1);
            chart1.Series[0].Points.AddXY(3, 1);
            chart1.Series[0].Points.AddXY(4, 1);
            chart1.Series[0].Points.AddXY(5, 1);
            chart1.Series[0].Points.AddXY(5.76, 11);
            chart1.Series[0].Points.AddXY(6, 1);
            chart1.Series[0].Points.AddXY(7.23, 5);
            chart1.Series[0].Points.AddXY(7, 1);
            chart1.Series[0].Points.AddXY(8, 1);
            chart1.Series[0].Points.AddXY(9, 1);
            chart1.Series[0].Points.AddXY(10, 1);
            chart1.Series[0].Points.AddXY(11, 1);
            chart1.Series[0].Points.AddXY(12, 1);
            chart1.Series[0].Points.AddXY(13, 1);
            chart1.Series[0].Points.AddXY(14, 1);
            chart1.Series[0].Points.AddXY(15, 1);
            chart1.Series[0].Points.AddXY(16, 1);
            chart1.Series[0].Points.AddXY(17, 1);
            chart1.Series[0].Points.AddXY(18, 1);
            chart1.Series[0].Points.AddXY(19, 1);
            chart1.Series[0].Points.AddXY(20, 1);
            chart1.Series[0].Points.AddXY(21, 1);
            chart1.Series[0].Points.AddXY(22, 1);
            chart1.Series[0].Points.AddXY(23, 1);
            chart1.Series[0].Points.AddXY(24, 1);
            chart1.Series[0].Points.AddXY(25, 1);
        }





        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        //===================================== Вывод графика =====================================
        private void button4_Click(object sender, EventArgs e)
        {
            string data;
            
            double XX, YY;
            string u1, u2;

            if (Put.Text != "Обзор:")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);

                while ((data = file.ReadLine()) != null)
                {
                    int u = data.IndexOf(';');
                    u1 = data.Substring(0, u);
                    u2 = data.Substring(u + 1);
                    XX = Convert.ToDouble(u1);
                    YY = Convert.ToDouble(u2);
                    chart1.Series[0].Points.AddXY(XX, YY);
                }

                file.Close();
            }
        }
        //===========================================================================================




        //======================================= Выбор файла =======================================
        string filename;
        private void Put_TextChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            Put.Text = filename;
        }
        //===========================================================================================



        //====================================== Интервалы оси ======================================
        //double AutoXI, AutoYI;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //AutoXI = chart1.ChartAreas[0].AxisX.Interval;

            if (interX.Text == "") chart1.ChartAreas[0].AxisX.Interval = Double.NaN;
            else chart1.ChartAreas[0].AxisX.Interval = Convert.ToDouble (interX.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //AutoYI = chart1.ChartAreas[0].AxisY.Interval;

            if (interY.Text == "") chart1.ChartAreas[0].AxisY.Interval = Double.NaN;
            else chart1.ChartAreas[0].AxisY.Interval = Convert.ToDouble(interY.Text);
        }
        //===========================================================================================



        //========================================== Сетка ==========================================
        //double AutoXM, AutoYM;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //AutoXM = chart1.ChartAreas[0].AxisX.MajorGrid.Interval;

            if (GridX.Text == "") chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Double.NaN;
            else chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Convert.ToDouble(GridX.Text); 
        }

        private void GridY_TextChanged(object sender, EventArgs e)
        {
            //AutoYM = chart1.ChartAreas[0].AxisY.MajorGrid.Interval;

            if (GridY.Text == "") chart1.ChartAreas[0].AxisY.MajorGrid.Interval = Double.NaN;
            else chart1.ChartAreas[0].AxisY.MajorGrid.Interval = Convert.ToDouble(GridY.Text);
        }
        bool grider = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (grider == false)
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                grider = true;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

                grider = false;
            }
        }
        //===========================================================================================

        //====================================== Подпись X и Y ======================================
        private void Ytext_TextChanged(object sender, EventArgs e)
        {
            if (Ytext.Text == "")
            {
                chart1.ChartAreas[0].AxisY.Title = "";
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Title = Ytext.Text;
            }
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Xtext.Text == "")
            {
                chart1.ChartAreas[0].AxisX.Title = "";
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Title = Xtext.Text;
            }
        }
        //===========================================================================================



        //========================================= Очистка =========================================
        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }
        //===========================================================================================


        int MashX = 1000, MashY = 500;
        //========================================= Масштаб =========================================
        //**************************************** По оси Y *****************************************
        // -
        private void button6_Click(object sender, EventArgs e)
        {
            MashY += 50;
            chart1.ChartAreas[0].AxisY.ScaleView.Size = MashY;
        }

        // +
        private void button7_Click(object sender, EventArgs e)
        {

            MashY -= 50;
            chart1.ChartAreas[0].AxisY.ScaleView.Size = MashY;
        }

        //**************************************** По оси X *****************************************
        // -
        private void button5_Click(object sender, EventArgs e)
        {
            MashX += 100;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = MashX;
        }

        // +
        private void button1_Click(object sender, EventArgs e)
        {
            MashX -= 100;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = MashX;
        }
        private void button5_MouseDoubleClick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Size = Double.NaN;
            chart1.ChartAreas[0].AxisY.ScaleView.Size = Double.NaN;
        }
        //===========================================================================================



        //========================================= Размер ==========================================
        private void label2_Resize(object sender, EventArgs e)
        {
            if (tableLayoutPanel2.Height < 800)
            {
                label1.Font = new Font("Microsoft Sans Serif", 8);
                label2.Font = new Font("Microsoft Sans Serif", 8);
                label3.Font = new Font("Microsoft Sans Serif", 8);
                label4.Font = new Font("Microsoft Sans Serif", 8);
                label7.Font = new Font("Microsoft Sans Serif", 8);
                label8.Font = new Font("Microsoft Sans Serif", 8);
                checkBox1.Font = new Font("Microsoft Sans Serif", 10);
                checkBox2.Font = new Font("Microsoft Sans Serif", 10);
            }
            else
            {
                label1.Font = new Font("Microsoft Sans Serif", 11);
                label2.Font = new Font("Microsoft Sans Serif", 11);
                label3.Font = new Font("Microsoft Sans Serif", 11);
                label4.Font = new Font("Microsoft Sans Serif", 11);
                label7.Font = new Font("Microsoft Sans Serif", 11);
                label8.Font = new Font("Microsoft Sans Serif", 11);
                checkBox1.Font = new Font("Microsoft Sans Serif", 11);
                checkBox2.Font = new Font("Microsoft Sans Serif", 11);
            }
        }
        //===========================================================================================



        //======================================= Сохранение ========================================
        private void button2_Click(object sender, EventArgs e)
        {
            sfd.Title = "Сохранить изображение как ...";
            sfd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            //Bitmap bmp = new Bitmap(2100, 1500);
            //chart1.DrawToBitmap(bmp, new Rectangle(0, 0, 2100, 1500));
            switch (sfd.FilterIndex)
            {
                case 1: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break; 
                case 2: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                case 3: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
            }
        }
        //===========================================================================================
    }

}
