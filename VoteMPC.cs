using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgrVoting
{
    public partial class Vote : Form
    {
        List<Vote_SPDZ> Voters = new List<Vote_SPDZ>();
        public Vote()
        {
            InitializeComponent();
        }

        private void buttonoddajglos_Click(object sender, EventArgs e)
        {
            int ind = 0;
            if (radioButtonAD.Checked)
                ind = 0;
            if (radioButtonAZ.Checked)
                ind = 1;
            if (radioButtonJKM.Checked)
                ind = 2;
            if (radioButtonDT.Checked)
                ind = 3;
            Voters.Add(new Vote_SPDZ(ind));
            foreach(Vote_SPDZ v in Voters)
            {
                v.update_udzial();
                v.reset_received_rx();
            }
            foreach(Vote_SPDZ vi in Voters)
            {
                foreach(Vote_SPDZ vj in Voters)
                {
                    for(int i=0;i<4;i++)
                    {
                        vi.dodaj_rx(i, vj.send_r(i));
                    }
                }
            }

            foreach (Vote_SPDZ vi in Voters)
            {
                foreach (Vote_SPDZ vj in Voters)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if((vj.getnr()-1)==0)
                        {
                            vj.set_udzial(i, vi.getnr()-1, vj.send_r(i) + vi.send_x_min_r(i));
                        }
                        else
                        {
                            vj.set_udzial(i, vi.getnr() - 1, vj.send_r(i));
                        }
                    }
                }

            }
            MessageBox.Show("Dziękujemy za oddanie głosu");
            radioButtonAD.Checked = true;
        }

        private void buttonsprawdz_Click(object sender, EventArgs e)
        {
            int[] wyn = new int[4];
            for(int i=0;i<wyn.Length;i++)
            {
                wyn[i] = 0;
            }
            int loc_sum = 0;

            for(int i=0;i<wyn.Length;i++)
            {
                for (int j = 0; j < Vote_SPDZ.voter_cnt; j++)
                {
                    foreach (Vote_SPDZ v in Voters)
                    {
                        loc_sum += v.get_udzial(i, j);
                    }
                }
                wyn[i] += loc_sum;
                loc_sum = 0;
            }
            int wyn_sum = 0;
            for(int i=0;i<wyn.Length;i++)
            {
                wyn_sum += wyn[i];
            }
            string[] wyb = new string[] { "Andrzej Duda", "Adrian Zandberg", "Janusz Korwin-Mikke", "Donald Tusk" };
            double[] percent = new double[4];
            for(int i=0;i<percent.Length;i++)
            {
                if (wyn_sum == 0)
                {
                    percent[i] = 0;
                }
                else
                {
                    percent[i] = (double)wyn[i] / (double)wyn_sum * 100;
                    percent[i] = Math.Round(percent[i], 2);
                    Console.WriteLine(wyn[i]);
                }
                
            }
            string wyniki = string.Empty;
            for(int i=0;i<wyb.Length;i++)
            {
                wyniki += wyb[i] + ": " + percent[i].ToString() + "%" + Environment.NewLine;
            }
            MessageBox.Show(wyniki);
        }
    }
}
