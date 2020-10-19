using System;
using System.ComponentModel;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string n = num.ToString();
            int a = 0;
            string ret = "";
            string z = "";
            if (n.Length < 4)
            {
                ret = n;
            }
            else if (n.Length < 7)
            {
                switch (n.Length % 3)
                {
                    case 1:
                        {
                            ret = "" + n[0] + ",";
                            a = 1;
                            break;
                        }
                    case 2:
                        {
                            ret = "" + n[0] + n[1] + ",";
                            a = 2;
                            break;
                        }
                    default:
                        {
                            ret = "";
                            a = 0;
                            break;
                        }
                }
                for (int i = a; i < n.Length; i++)
                {
                    z = z + n[i];
                }
                for (int i = 0; i < z.Length - 1; i = i + 3)
                {
                    ret = ret + z[i] + z[i + 1] + z[i + 2] + ",";
                }
                string q = ret;
                ret = "";
                for (int i = 0; i < q.Length - 1; i++)
                {
                    ret = ret + q[i];
                }
            }
            else
            {
                switch (n.Length % 3)
                {
                    case 1:
                        {
                            ret = "" + n[0] + Convert.ToChar(160);
                            a = 1;
                            break;
                        }
                    case 2:
                        {
                            ret = "" + n[0] + n[1] + Convert.ToChar(160);
                            a = 2;
                            break;
                        }
                    default:
                        {
                            ret = "";
                            a = 0;
                            break;
                        }
                }
                for (int i = a; i < n.Length; i++)
                {
                    z = z + n[i];
                }
                for (int i = 0; i < z.Length - 1; i = i + 3)
                {
                    ret = ret + z[i] + z[i + 1] + z[i + 2] + Convert.ToChar(160);
                }
                string q = ret;
                ret = "";
                for (int i = 0; i < q.Length - 1; i++)
                {
                    ret = ret + q[i];
                }
            }
            return ret;
        }
    }
}
