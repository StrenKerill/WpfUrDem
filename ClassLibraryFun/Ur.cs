using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFun
{
    public class Ur
    {
        public static void KvUr(double a, double b, double c,
                            out double dis, out double x1, out double x2,
                            out string message)
        {
            dis = x1 = x2 = double.NaN;

            dis = b * b - 4 * a * c;
            if (dis > 0)
            {
                x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                x2 = (-b + Math.Sqrt(dis)) / (2 * a);
                message = "2 корня";
            }
            else if (dis == 0)
            {
                x1 = -b / 2 / a;
                message = "1 корень";
            }
            else
                message = "Корней нет";

        }

        public static void LnUr(double a, double b, double c,
                           out double x1, out string message)
        {
            message = null;
            x1 = double.NaN;
            if (a == 0)
            {
                if (b == 0) message = "Прямая совпадает с осью, ответ R";
                else message = "Нет решений";
            }
            else if (c == 0)
                x1 = -b / a;
            else
                x1 = (c - b) / a;
        }
    }
}
