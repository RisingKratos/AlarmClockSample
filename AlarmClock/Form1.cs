using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public int alarmTime;
        public int hour;
        public int minute;
        public int setHour;
        public int setMinute;
        public int time;
        public int setTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetAlarmClock_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            hour = Convert.ToInt32(System.DateTime.Now.Hour);
            minute = Convert.ToInt32(System.DateTime.Now.Minute);
            setHour = Convert.ToInt32(textBox1.Text);
            setMinute = Convert.ToInt32(textBox2.Text);
            time = hour * 60 + minute;
            setTime = setHour * 60 + setMinute;
            
                if (setHour < hour)
                {
                    setHour += 12;
                }
            alarmTime = setTime - time;

            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) 
            {
                if (form.yourChoice == 'l') 
                {
                    MessageBox.Show("You've chosen less time");
                }
                if (form.yourChoice == 'm')
                {
                    MessageBox.Show("You've chosen more time");
                }
            }
            MessageBox.Show(alarmTime.ToString());
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            alarmTime--;
            if (alarmTime == 0)
            {
                SoundPlayer alarmSound = new SoundPlayer(@"C:\Users\asus\Downloads\TheXXCrystalised.wav");
                alarmSound.Play();
            }
        }
    }
}
