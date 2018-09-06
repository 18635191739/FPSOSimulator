using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSOSimulator.MyClass
{
    //class NumericalIteration
    //{
    //}

    public static class NumericalIterationEquation
    {
        //二分法
        //[x1,x2]为近似解区间，e为求解精度，fun为求解方程
        public static double Dichotomy(Func<double, double> fun, double x1, double x2, double e)
        {
            double x = 0;
            while (Math.Abs(x2 - x1) >= e)
            {
                x = (x1 + x2) / 2;
                if (fun(x1) * fun(x) < 0)
                {
                    x2 = x;
                }
                if (fun(x2) * fun(x) < 0)
                {
                    x1 = x;
                }
                if (0 == fun(x))
                {
                    return x;
                }
            }
            return x;
        }

        //牛顿迭代法
        //fun为牛顿迭代公式！！f(x)=x-f(x)/f'(x)
        //x1为方程初始解，e为方程求解精度
        public static double Newton(Func<double, double> fun, double x1, double e)
        {
            int count = 0;
            double x2 = fun(x1);
            while (Math.Abs(x2 - x1) >= e)
            {
                x1 = x2;
                x2 = fun(x1);
                count++;
            }
            return x2;
        }

        //单点弦截法,即不动点迭代法
        //f(x)=x0-(x-x0)/(f(x)-f(x0))*f(x0) x0为不动点，一般常选取区间的一个端点。
        //x1为区间的另一个端点，e为方程解的精度
        public static double Single(Func<double, double> fun, double x1, double e)
        {
            int count = 0;
            double x2 = fun(x1);
            while (Math.Abs(x2 - x1) >= e)
            {
                x1 = x2;
                x2 = fun(x1);
                count++;
            }
            return x2;
        }

        //割线法
        public static double Sec(Func<double, double, double> fun, double x1, double x2, double e)
        {
            int count = 0;
            double x3 = 0;
            while (Math.Abs(x2 - x1) > e)
            {
                x3 = fun(x1, x2);
                x1 = x2;
                x2 = x3;
                count++;
            }
            return x3;
        }
    }
}
