using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting
{
    public partial class Form1 : Form
    {
        DateTime startSession = new DateTime();
        List<int> allScores = new List<int>();
        int shots = 0;
        Queue<Button> buttons = new Queue<Button>();
        Queue<int> que = new Queue<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Shoot(Button1, Button2, Button3, Button8, Button15, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Shoot(Button2, Button1, Button3, Button9, Button16, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Shoot(Button3, Button2, Button4, Button10, Button17, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Shoot(Button4, Button3, Button5, Button11, Button18, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Shoot(Button5, Button4, Button6, Button12, Button19, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Shoot(Button6, Button5, Button7, Button13, Button20, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Shoot(Button7, Button6, Button5, Button14, Button21, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Shoot(Button8, Button1, Button9, Button10, Button15, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Shoot(Button9, Button8, Button2, Button10, Button16, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Shoot(Button10, Button9, Button3, Button11, Button17, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Shoot(Button11, Button10, Button4, Button12, Button18, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Shoot(Button12, Button11, Button5, Button13, Button19, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Shoot(Button13, Button12, Button6, Button14, Button20, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Shoot(Button14, Button12, Button13, Button7, Button21, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Shoot(Button15, Button8, Button16, Button17, Button22, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Shoot(Button16, Button15, Button9, Button17, Button23, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Shoot(Button17, Button16, Button10, Button18, Button24, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Shoot(Button18, Button17, Button11, Button19, Button25, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Shoot(Button19, Button18, Button12, Button20, Button26, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Shoot(Button20, Button19, Button13, Button21, Button27, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Shoot(Button21, Button19, Button20, Button14, Button28, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Shoot(Button22, Button15, Button23, Button24, Button29, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            Shoot(Button23, Button22, Button16, Button24, Button30, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Shoot(Button24, Button23, Button17, Button25, Button31, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            Shoot(Button25, Button24, Button18, Button26, Button32, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            Shoot(Button26, Button25, Button19, Button27, Button33, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            Shoot(Button27, Button26, Button20, Button28, Button34, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            Shoot(Button28, Button26, Button27, Button21, Button35, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            Shoot(Button29, Button22, Button30, Button31, Button36, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            Shoot(Button30, Button29, Button23, Button31, Button37,
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            Shoot(Button31, Button30, Button24, Button32, Button38, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            Shoot(Button32, Button31, Button25, Button33, Button39, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            Shoot(Button33, Button32, Button26, Button34, Button40,
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            Shoot(Button34, Button33, Button27, Button35, Button41,
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Shoot(Button35, Button33, Button28, Button34, Button42, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            Shoot(Button36, Button29, Button37, Button38, Button43,
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            Shoot(Button37, Button36, Button30, Button38, Button44, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            Shoot(Button38, Button37, Button31, Button39, Button45, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            Shoot(Button39, Button38, Button32, Button40, Button46, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            Shoot(Button40, Button39, Button33, Button41, Button47, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            Shoot(Button41, Button40, Button34, Button42, Button48, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            Shoot(Button42, Button40, Button41, Button35, Button49, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            Shoot(Button43, Button36, Button44, Button45, Button50, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            Shoot(Button44, Button43, Button37, Button45, Button51, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            Shoot(Button45, Button44, Button38, Button46, Button52, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            Shoot(Button46, Button45, Button39, Button47, Button53, 
                CurrentShotPointsText, CurrentTotalPointsText, ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            Shoot(Button47, Button46, Button40, Button48, Button54, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            Shoot(Button48, Button47, Button41, Button49, Button55,
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            Shoot(Button49, Button47, Button48, Button42, Button56, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            Shoot(Button50, Button43, Button36, Button51, Button52, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            Shoot(Button51, Button44, Button50, Button37, Button52, 
                CurrentShotPointsText, CurrentTotalPointsText,
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button52_Click(object sender, EventArgs e)
        {
            Shoot(Button52, Button45, Button51, Button38, Button53, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            Shoot(Button53, Button46, Button52, Button39, Button54,
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button54_Click(object sender, EventArgs e)
        {
            Shoot(Button54, Button47, Button53, Button40, Button55, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button55_Click(object sender, EventArgs e)
        {
            Shoot(Button55, Button48, Button54, Button41, Button56, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void Button56_Click(object sender, EventArgs e)
        {
            Shoot(Button56, Button49, Button54, Button55, Button42, 
                CurrentShotPointsText, CurrentTotalPointsText, 
                ref shots, allScores, ErrorBox, buttons, que);
        }

        private void StartTimeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndTimeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeElapsedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentShotPointsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentTotalPointsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalShotsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopShotText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalScoreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            que.Enqueue(0);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            Random rnd = new Random();
            End_Button.Visible = true;
            Button1.Visible = true; Button1.Text = rnd.Next(100, 1000).ToString(); Button1.ForeColor = Color.Black;
            Button2.Visible = true; Button2.Text = rnd.Next(100, 1000).ToString(); Button2.ForeColor = Color.Black;
            Button3.Visible = true; Button3.Text = rnd.Next(100, 1000).ToString(); Button3.ForeColor = Color.Black;
            Button4.Visible = true; Button4.Text = rnd.Next(100, 1000).ToString(); Button4.ForeColor = Color.Black;
            Button5.Visible = true; Button5.Text = rnd.Next(100, 1000).ToString(); Button5.ForeColor = Color.Black;
            Button6.Visible = true; Button6.Text = rnd.Next(100, 1000).ToString(); Button6.ForeColor = Color.Black;
            Button7.Visible = true; Button7.Text = rnd.Next(100, 1000).ToString(); Button7.ForeColor = Color.Black;
            Button8.Visible = true; Button8.Text = rnd.Next(100, 1000).ToString(); Button8.ForeColor = Color.Black;
            Button9.Visible = true; Button9.Text = rnd.Next(100, 1000).ToString(); Button9.ForeColor = Color.Black;
            Button10.Visible = true; Button10.Text = rnd.Next(100, 1000).ToString(); Button10.ForeColor = Color.Black;
            Button11.Visible = true; Button11.Text = rnd.Next(100, 1000).ToString(); Button11.ForeColor = Color.Black;
            Button12.Visible = true; Button12.Text = rnd.Next(100, 1000).ToString(); Button12.ForeColor = Color.Black;
            Button13.Visible = true; Button13.Text = rnd.Next(100, 1000).ToString(); Button13.ForeColor = Color.Black;
            Button14.Visible = true; Button14.Text = rnd.Next(100, 1000).ToString(); Button14.ForeColor = Color.Black;
            Button15.Visible = true; Button15.Text = rnd.Next(100, 1000).ToString(); Button15.ForeColor = Color.Black;
            Button16.Visible = true; Button16.Text = rnd.Next(100, 1000).ToString(); Button16.ForeColor = Color.Black;
            Button17.Visible = true; Button17.Text = rnd.Next(100, 1000).ToString(); Button17.ForeColor = Color.Black;
            Button18.Visible = true; Button18.Text = rnd.Next(100, 1000).ToString(); Button18.ForeColor = Color.Black;
            Button19.Visible = true; Button19.Text = rnd.Next(100, 1000).ToString(); Button19.ForeColor = Color.Black;
            Button20.Visible = true; Button20.Text = rnd.Next(100, 1000).ToString(); Button20.ForeColor = Color.Black;
            Button21.Visible = true; Button21.Text = rnd.Next(100, 1000).ToString(); Button21.ForeColor = Color.Black;
            Button22.Visible = true; Button22.Text = rnd.Next(100, 1000).ToString(); Button22.ForeColor = Color.Black;
            Button23.Visible = true; Button23.Text = rnd.Next(100, 1000).ToString(); Button23.ForeColor = Color.Black;
            Button24.Visible = true; Button24.Text = rnd.Next(100, 1000).ToString(); Button24.ForeColor = Color.Black;
            Button25.Visible = true; Button25.Text = rnd.Next(100, 1000).ToString(); Button25.ForeColor = Color.Black;
            Button26.Visible = true; Button26.Text = rnd.Next(100, 1000).ToString(); Button26.ForeColor = Color.Black;
            Button27.Visible = true; Button27.Text = rnd.Next(100, 1000).ToString(); Button27.ForeColor = Color.Black;
            Button28.Visible = true; Button28.Text = rnd.Next(100, 1000).ToString(); Button28.ForeColor = Color.Black;
            Button29.Visible = true; Button29.Text = rnd.Next(100, 1000).ToString(); Button29.ForeColor = Color.Black;
            Button30.Visible = true; Button30.Text = rnd.Next(100, 1000).ToString(); Button30.ForeColor = Color.Black;
            Button31.Visible = true; Button31.Text = rnd.Next(100, 1000).ToString(); Button31.ForeColor = Color.Black;
            Button32.Visible = true; Button32.Text = rnd.Next(100, 1000).ToString(); Button32.ForeColor = Color.Black;
            Button33.Visible = true; Button33.Text = rnd.Next(100, 1000).ToString(); Button33.ForeColor = Color.Black;
            Button34.Visible = true; Button34.Text = rnd.Next(100, 1000).ToString(); Button34.ForeColor = Color.Black;
            Button35.Visible = true; Button35.Text = rnd.Next(100, 1000).ToString(); Button35.ForeColor = Color.Black;
            Button36.Visible = true; Button36.Text = rnd.Next(100, 1000).ToString(); Button36.ForeColor = Color.Black;
            Button37.Visible = true; Button37.Text = rnd.Next(100, 1000).ToString(); Button37.ForeColor = Color.Black;
            Button38.Visible = true; Button38.Text = rnd.Next(100, 1000).ToString(); Button38.ForeColor = Color.Black;
            Button39.Visible = true; Button39.Text = rnd.Next(100, 1000).ToString(); Button39.ForeColor = Color.Black;
            Button40.Visible = true; Button40.Text = rnd.Next(100, 1000).ToString(); Button40.ForeColor = Color.Black;
            Button41.Visible = true; Button41.Text = rnd.Next(100, 1000).ToString(); Button41.ForeColor = Color.Black;
            Button42.Visible = true; Button42.Text = rnd.Next(100, 1000).ToString(); Button42.ForeColor = Color.Black;
            Button43.Visible = true; Button43.Text = rnd.Next(100, 1000).ToString(); Button43.ForeColor = Color.Black;
            Button44.Visible = true; Button44.Text = rnd.Next(100, 1000).ToString(); Button44.ForeColor = Color.Black;
            Button45.Visible = true; Button45.Text = rnd.Next(100, 1000).ToString(); Button45.ForeColor = Color.Black;
            Button46.Visible = true; Button46.Text = rnd.Next(100, 1000).ToString(); Button46.ForeColor = Color.Black;
            Button47.Visible = true; Button47.Text = rnd.Next(100, 1000).ToString(); Button47.ForeColor = Color.Black;
            Button48.Visible = true; Button48.Text = rnd.Next(100, 1000).ToString(); Button48.ForeColor = Color.Black;
            Button49.Visible = true; Button49.Text = rnd.Next(100, 1000).ToString(); Button49.ForeColor = Color.Black;
            Button50.Visible = true; Button50.Text = rnd.Next(100, 1000).ToString(); Button50.ForeColor = Color.Black;
            Button51.Visible = true; Button51.Text = rnd.Next(100, 1000).ToString(); Button51.ForeColor = Color.Black;
            Button52.Visible = true; Button52.Text = rnd.Next(100, 1000).ToString(); Button52.ForeColor = Color.Black;
            Button53.Visible = true; Button53.Text = rnd.Next(100, 1000).ToString(); Button53.ForeColor = Color.Black;
            Button54.Visible = true; Button54.Text = rnd.Next(100, 1000).ToString(); Button54.ForeColor = Color.Black;
            Button55.Visible = true; Button55.Text = rnd.Next(100, 1000).ToString(); Button55.ForeColor = Color.Black;
            Button56.Visible = true; Button56.Text = rnd.Next(100, 1000).ToString(); Button56.ForeColor = Color.Black;

            if (StartTimeText.Text == " ")
            {
                DateTime startTime = DateTime.Now;
                startSession = startTime;
                StartTimeText.Text = startSession.ToString();
            }

            Start_Button.Visible = false;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Start_Button.Visible = true;
            startSession = new DateTime();
            allScores = new List<int>();
            shots = 0;
            buttons = new Queue<Button>();
            que = new Queue<int>();

            StartTimeText.Text = " ";
            EndTimeText.Text = " ";
            TimeElapsedText.Text = " ";
            CurrentShotPointsText.Text = " ";
            CurrentTotalPointsText.Text = " ";
            TotalShotsText.Text = " ";
            TopShotText.Text = " ";
            TotalScoreText.Text = " ";

            Button1.Text = " "; Button1.ForeColor = Color.Black;
            Button2.Text = " "; Button2.ForeColor = Color.Black;
            Button3.Text = " "; Button3.ForeColor = Color.Black;
            Button4.Text = " "; Button4.ForeColor = Color.Black;
            Button5.Text = " "; Button5.ForeColor = Color.Black;
            Button6.Text = " "; Button6.ForeColor = Color.Black;
            Button7.Text = " "; Button7.ForeColor = Color.Black;
            Button8.Text = " "; Button8.ForeColor = Color.Black;
            Button9.Text = " "; Button9.ForeColor = Color.Black;
            Button10.Text = " "; Button10.ForeColor = Color.Black;
            Button11.Text = " "; Button11.ForeColor = Color.Black;
            Button12.Text = " "; Button12.ForeColor = Color.Black;
            Button13.Text = " "; Button13.ForeColor = Color.Black;
            Button14.Text = " "; Button14.ForeColor = Color.Black;
            Button15.Text = " "; Button15.ForeColor = Color.Black;
            Button16.Text = " "; Button16.ForeColor = Color.Black;
            Button17.Text = " "; Button17.ForeColor = Color.Black;
            Button18.Text = " "; Button18.ForeColor = Color.Black;
            Button19.Text = " "; Button19.ForeColor = Color.Black;
            Button20.Text = " "; Button20.ForeColor = Color.Black;
            Button21.Text = " "; Button21.ForeColor = Color.Black;
            Button22.Text = " "; Button22.ForeColor = Color.Black;
            Button23.Text = " "; Button23.ForeColor = Color.Black;
            Button24.Text = " "; Button24.ForeColor = Color.Black;
            Button25.Text = " "; Button25.ForeColor = Color.Black;
            Button26.Text = " "; Button26.ForeColor = Color.Black;
            Button27.Text = " "; Button27.ForeColor = Color.Black;
            Button28.Text = " "; Button28.ForeColor = Color.Black;
            Button29.Text = " "; Button29.ForeColor = Color.Black;
            Button30.Text = " "; Button30.ForeColor = Color.Black;
            Button31.Text = " "; Button31.ForeColor = Color.Black;
            Button32.Text = " "; Button32.ForeColor = Color.Black;
            Button33.Text = " "; Button33.ForeColor = Color.Black;
            Button34.Text = " "; Button34.ForeColor = Color.Black;
            Button35.Text = " "; Button35.ForeColor = Color.Black;
            Button36.Text = " "; Button36.ForeColor = Color.Black;
            Button37.Text = " "; Button37.ForeColor = Color.Black;
            Button38.Text = " "; Button38.ForeColor = Color.Black;
            Button39.Text = " "; Button39.ForeColor = Color.Black;
            Button40.Text = " "; Button40.ForeColor = Color.Black;
            Button41.Text = " "; Button41.ForeColor = Color.Black;
            Button42.Text = " "; Button42.ForeColor = Color.Black;
            Button43.Text = " "; Button43.ForeColor = Color.Black;
            Button44.Text = " "; Button44.ForeColor = Color.Black;
            Button45.Text = " "; Button45.ForeColor = Color.Black;
            Button46.Text = " "; Button46.ForeColor = Color.Black;
            Button47.Text = " "; Button47.ForeColor = Color.Black;
            Button48.Text = " "; Button48.ForeColor = Color.Black;
            Button49.Text = " "; Button49.ForeColor = Color.Black;
            Button50.Text = " "; Button50.ForeColor = Color.Black;
            Button51.Text = " "; Button51.ForeColor = Color.Black;
            Button52.Text = " "; Button52.ForeColor = Color.Black;
            Button53.Text = " "; Button53.ForeColor = Color.Black;
            Button54.Text = " "; Button54.ForeColor = Color.Black;
            Button55.Text = " "; Button55.ForeColor = Color.Black;
            Button56.Text = " "; Button56.ForeColor = Color.Black;
        }

        static void Shoot(Button A, Button B, Button C, Button D, Button E, 
            TextBox currentShot, TextBox currentTotalPoints, ref int shots, List<int> scores, 
            TextBox error, Queue<Button> buttonQue, Queue<int> command)
        {
            if (ValidateButtonValues(A, B, C, D, E))
            {
                int isDeque = command.Dequeue();
                if (isDeque == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Button change = buttonQue.Dequeue();
                        change.Text = " ";
                    }
                }

                int sum = int.Parse(A.Text) + int.Parse(B.Text) + int.Parse(C.Text) + int.Parse(D.Text) + int.Parse(E.Text);
                currentShot.Text = sum.ToString();
                currentTotalPoints.Text = scores.Sum().ToString();
                scores.Add(sum);
                shots++;

                A.ForeColor = Color.LimeGreen;
                B.ForeColor = Color.LimeGreen;
                C.ForeColor = Color.LimeGreen;
                D.ForeColor = Color.LimeGreen;
                E.ForeColor = Color.LimeGreen;

                buttonQue.Enqueue(A);
                buttonQue.Enqueue(B);
                buttonQue.Enqueue(C);
                buttonQue.Enqueue(D);
                buttonQue.Enqueue(E);

                error.Text = " ";
            }

            else
            {
                if (A.ForeColor == Color.LimeGreen)
                    A.Text = " ";

                error.Text = "ERROR";
            }
        }

        static bool ValidateButtonValues(Button A, Button B, Button C, Button D, Button E)
        {
            bool checkNull = A.Text == " " || B.Text == " " || C.Text == " " || D.Text == " " || E.Text == " ";
            bool checkColor = A.ForeColor == Color.LimeGreen || B.ForeColor == Color.LimeGreen ||
                C.ForeColor == Color.LimeGreen || D.ForeColor == Color.LimeGreen || E.ForeColor == Color.LimeGreen;

            if (checkNull || checkColor)
                return false;
            else
                return true;
        }
        private void End_Button_Click(object sender, EventArgs e)
        {
            DateTime started = startSession;
            DateTime endSession = DateTime.Now;
            TimeSpan timeElapsed = endSession - startSession;

            StartTimeText.Text = startSession.ToString();

            EndTimeText.Text = endSession.ToString();

            double totalSecondsElapsed = timeElapsed.TotalSeconds;
            TimeElapsedText.Text = Math.Round(totalSecondsElapsed, 2) + " seconds";

            CurrentShotPointsText.Text = " ";

            CurrentTotalPointsText.Text = " ";

            TopShotText.Text = allScores.Max().ToString();

            TotalShotsText.Text = shots.ToString();

            TotalScoreText.Text = allScores.Sum().ToString();
        }

        private void ErrorBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
