public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
        {
            Array.Sort(piles, (x, y) => y.CompareTo(x));
            int l = 1, ans = 0,md;
            long r = 9999999999;
            while (l <= r)
            {
                md = (int)(l + r) / 2;
                if (valid(md, piles,h))
                {
                    r = md - 1;
                    ans = md;
                }
                else
                {
                    l = md + 1;
                }
            }
            return ans;
        }

        private bool valid(int md, int[] p,int h)
        {
            int f = 0;
            int checker = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > md)
                {
                    f = p[i] / md;
                    if (p[i] % md != 0)
                        f++;
                    checker += f;
                    //checker = 
                }
                else
                {
                    f = p.Length - i;
                    checker += f;
                    break;
                }
            }
            return (checker <= h);
        }
}
