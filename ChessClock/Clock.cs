using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClock
{
    class Clock
    {
        int hms;
        bool paused;
        long now;

        public Clock(int h, int m, int s)
        {
            set_time(h, m, s);
        }

        public void set_time(int h, int m, int s)
        {
            hms = 10*(h * 3600 + m * 60 + s);
            paused = true;
            set_now();
        }

        public void stop_Clock()
        {
            if (!paused)
                tick_clock();
            paused = true;
        }

        public void play_Clock()
        {
            if (paused)
                set_now();
            paused = false;
        }

        private void set_now()
        {
            now = DateTime.Now.Ticks/1000/1000;
        }

        private void tick_clock()
        {
            if (paused) return;
            long old = now;
            set_now();
            int delta = Convert.ToInt32(now - old);
            hms -= delta;
            if (hms < 0) hms = 0;
        }

        public string show_Clock()
        {
            tick_clock();
            int h, m, s, s10;
            s10 = hms % 10;
            s = hms /10% 60;
            m = hms /10% 3600 / 60;
            h = hms /10/ 3600;
            return 
                (h==0?"" : h.ToString() + ":") + 
                m.ToString("00") + ":" + 
                s.ToString("00")+"."+s10.ToString();
        }
    }
}
