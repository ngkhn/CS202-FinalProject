using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentModule
{
    public partial class uscClock : UserControl
    {
        int mm, ss, ms;
        int _mmBegin, _ssBegin;

        public delegate void uscEClock_ExitHandle();
        public event uscEClock_ExitHandle uscEClock_Exit;

        
        public int _mm
        {
            get { return _mmBegin; }
            set
            {
                if (value < 0)
                    _mmBegin = 0;
                else
                    if (value > 99)
                    _mmBegin = 99;
                else
                    _mmBegin = value;
                mm1.Image = imageList.Images[_mmBegin / 10];
                mm2.Image = imageList.Images[_mmBegin % 10];
            }
        }

        public int _ss
        {
            get { return _ssBegin; }
            set
            {
                if (value < 0)
                    _ssBegin = 0;
                else
                if (value > 60)
                    _ssBegin = 99;
                else
                    _ssBegin = value;
                ss1.Image = imageList.Images[_ssBegin / 10];
                ss2.Image = imageList.Images[_ssBegin % 10];
            }
        }

        public uscClock()
        {
            InitializeComponent();
            line1.Image = imageList.Images[10];
            line2.Image = imageList.Images[10];
            SetImage();
        }

        private void SetImage()
        {
            mm1.Image = imageList.Images[mm / 10];
            mm2.Image = imageList.Images[mm % 10];
            ss1.Image = imageList.Images[ss / 10];
            ss2.Image = imageList.Images[ss % 10];
            ms1.Image = imageList.Images[ms / 10];
            ms2.Image = imageList.Images[ms % 10];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ms--;
            if (ms < 0)
            {
                ms = 99;
                ss--;
            }
            if (ss < 0)
            {
                ss = 59;
                mm--;
            }
            if (mm < 0)
                mm = 99;
          
            SetImage();

            if (mm == 0 && ss == 0 && ms == 0)
                uscEClock_Exit(); 

        }

        public void Start()
        {
            timer.Enabled = true;
            mm = _mmBegin;
            ss = _ssBegin;
                
        }

        public void Stop()
        {
            timer.Enabled = false;
            mm = ss = ms = 0;
            line1.Image = imageList.Images[10];
            line2.Image = imageList.Images[10];
            SetImage();
        }
    }
}
