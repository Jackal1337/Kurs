using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    class Bus
    {
        public int h = DateTime.Now.Hour;
        public int m = DateTime.Now.Minute;
        public int s = DateTime.Now.Second;
        public int hours { get; set; }
        public int minutes { get; set; }
        public override string ToString()
        {
            if (hours < 10 && minutes < 10)
            {
                return "0" + hours + ":" + "0" + minutes;
            }
            else if (hours >= 10 && minutes >= 10)
            {
                return hours + ":" + minutes;
            }
            else if (hours < 10 && minutes >= 10)
            {
                return "0" + hours + ":" + minutes;
            }
            else
            {
                return hours + ":" + "0" + minutes;
            }

        }

        public string Tine()
        {
            string time = "";

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            return time;
        }

    }
    class Sort : Bus
        {
        public override string ToString()
        {
            if((hours<=h && minutes<m)||(hours<h && minutes>=m))
            {
                return null;
            }
            else 
            {
                if (hours < 10 && minutes < 10)
                {
                    return "0" + hours + ":" + "0" + minutes;
                }
                else if (hours >= 10 && minutes >= 10)
                {
                    return hours + ":" + minutes;
                }
                else if (hours < 10 && minutes >= 10)
                {
                    return "0" + hours + ":" + minutes;
                }
                else
                {
                    return hours + ":" + "0" + minutes;
                }
            }
        }
        }

}
