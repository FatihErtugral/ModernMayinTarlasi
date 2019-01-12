using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class SlidingPanel
    {
        private Panel   span;
        private readonly Button  button;
        private Timer   tmr;
        private bool    hidden;
        private int     Xstart;
        private int     Xend;
        /// <summary>
        /// Panel konumunu yukarıdan aşağıya doğru ve tam tersi olacak şekile haraket ettiriryor
        /// </summary>
        /// <param name="pnl">Haraket ettirilecek panelin referansı</param>
        /// <param name="btn">Evente bağlanılacak bir buton referansı</param>
        /// <param name="locationX_Start">Başlangın x kordinatı</param>
        /// <param name="locationX_End">Hareket ettirilecek x kordinatı</param>
        public SlidingPanel(ref Panel pnl,ref Button btn, int locationX_Start, int locationX_End)
        {
            pnl.Top     = locationX_Start;
            this.span   = pnl;
            this.button = btn;
            hidden      = true;
            Xstart      = locationX_Start;
            Xend        = locationX_End;
            btn.Click   += new EventHandler(button_clicked);
            tmr = new Timer
            {
                Interval = 1
            };
            tmr.Tick    += new EventHandler(t_tick); 
        }

        private void button_clicked(object sender, EventArgs e)
        {
            tmr.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+10);
            else        ChangeSize(-10);
        }

        private void ChangeSize(int val)
        {
            span.Top += val;

            if(span.Top <= Xstart || span.Top >= Xend)
            {
                tmr.Stop();
                hidden = !hidden;
            }
        }
    }
}
