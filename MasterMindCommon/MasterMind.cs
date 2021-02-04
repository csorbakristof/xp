using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MasterMindCommon
{
    public class MasterMind
    {
        public (int black, int white) Eval(string correct, string g)
        {
            var c = correct.ToCharArray();
            if (g == correct) return (g.Length, 0);
            int black = 0;
            int white = 0;
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] == correct[i])
                {
                    black++;
                    c[i] = '-';
                }
            }
            for (int i = 0; i < g.Length; i++)
            {
                if (c.Contains(g[i]))
                {
                    white++;
                }
            }

            return (black, white);
        }
    }
}