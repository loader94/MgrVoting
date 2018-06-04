using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgrVoting
{
    class Vote_SPDZ
    {
        int nr;
        public static int voter_cnt = 0;
        int[] x;
        int[] randovalues;
        int[,] udzial;
        int[] received_rx;
        public Vote_SPDZ(int ind)
        {
            voter_cnt++;
            x = new int[4];
            randovalues = new int[4];
            received_rx = new int[4];
            Random r = new Random();
            for(int i=0;i<x.Length;i++)
            {
                x[i] = 0;
                randovalues[i] = r.Next(1000);
                received_rx[i] = 0;
            }
            x[ind] = 1;
            
            udzial = new int[4,voter_cnt];
            nr = voter_cnt;
        }
        public int send_r(int i)
        {
            return randovalues[i];
        }
        public int send_x_min_r(int i)
        {
            return x[i] - received_rx[i];
        }
        public void update_udzial()
        {
            udzial = new int[4, voter_cnt];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < voter_cnt; j++)
                    udzial[i, j] = 0;
        }
        public void dodaj_rx(int i,int value)
        {
            received_rx[i] += value;
        }
        public void reset_received_rx()
        {
            for(int i=0;i<4;i++)
            {
                received_rx[i] = 0;
            }
        }
        public int getnr()
        {
            return nr;
        }
        public void set_udzial(int i, int j, int v)
        {
            udzial[i, j] = v;
        }
        public int get_udzial(int i, int j)
        {
            return udzial[i, j];
        }
    }
}
