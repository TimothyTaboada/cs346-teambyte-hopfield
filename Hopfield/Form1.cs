using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hopfield
{
    public partial class Form1 : Form
    {
        int i;
        // + & - pattern
        int[] patrn1 = { -1, 1, -1, 1, 1, 1, -1, 1, -1 };
        int[] patrn2 = { -1, -1, -1, 1, 1, 1, -1, -1, -1 };
        int[] usrpatrn = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        int[] dfault = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        // weights
        int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
        int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
        int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
        int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
        int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
        int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
        int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
        int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
        int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            Test();
        }

        private void Test()
        {
            Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);
            h1.Activation(patrn1);
            for (i = 0; i < 9; i++)
            {
                if (h1.output[i] == patrn1[i])
                    Console.WriteLine("\n pattern= " + patrn1[i] + " output = " + h1.output[i] + " component matches");
                else
                    Console.WriteLine("\n pattern= " + patrn1[i] + " output = " + h1.output[i] + " discrepancy occurred");
            }
            Console.WriteLine("\nPattern +\n");
            h1.Activation(patrn2);
            for (i = 0; i < 9; i++)
            {
                if (h1.output[i] == patrn2[i])
                    Console.WriteLine("\n pattern= " + patrn2[i] + " output = " + h1.output[i] + " component matches");
                else
                    Console.WriteLine("\n pattern= " + patrn2[i] + " output = " + h1.output[i] + " discrepancy occurred");
            }
            Console.WriteLine("\nPattern -\n");
        }

        private void SetDisplay(Button btn, int state)
        {
            switch (state)
            {
                case 1:
                    btn.BackColor = Color.Black;
                    break;
                case -1:
                    btn.BackColor = Color.LightGray;
                    break;
            }
        }

        private void Anominaly(int[] input)
        {
            Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);
            int[] prev = input;
            int[] result = new int[9];
            List<int> anom = new List<int>();
            h1.Activation(input);
            for (int i = 0; i < 9; i++)
            {
                result[i] = h1.output[i];
                if (h1.output[i] != input[i])
                {
                    anom.Add(i);
                }
            }
            // rerun anomalies
            List<int> nuanom = new List<int>();
            while (!Enumerable.SequenceEqual(result, prev))
            {
                prev = result;
                while(anom.Count != 0)
                {
                    int errindex = anom[0];
                    anom.RemoveAt(0);
                    h1.TargetedActivation(result, errindex);
                    result[errindex] = h1.output[errindex];
                    if (h1.output[errindex] != input[errindex])
                    {
                        nuanom.Add(errindex);
                    }
                }
                anom = nuanom;
                nuanom.Clear();
            }
            //display
            SetDisplay(disptl, result[0]);
            SetDisplay(disptm, result[1]);
            SetDisplay(disptr, result[2]);
            SetDisplay(dispml, result[3]);
            SetDisplay(dispmm, result[4]);
            SetDisplay(dispmr, result[5]);
            SetDisplay(dispbl, result[6]);
            SetDisplay(dispbm, result[7]);
            SetDisplay(dispbr, result[8]);
        }

        private void ToggleButton(int index, Button btn)
        {
            switch(usrpatrn[index])
            {
                case -1:
                    usrpatrn[index] = 1;
                    btn.BackColor = Color.Black;
                    break;
                case 1:
                    usrpatrn[index] = -1;
                    btn.BackColor = Color.LightGray;
                    break;
            }
        }

        private void Clear()
        {
            usrpatrn = dfault;
            topleft.BackColor = Color.LightGray;
            topmid.BackColor = Color.LightGray;
            topright.BackColor = Color.LightGray;
            midleft.BackColor = Color.LightGray;
            midmid.BackColor = Color.LightGray;
            midright.BackColor = Color.LightGray;
            botleft.BackColor = Color.LightGray;
            botmid.BackColor = Color.LightGray;
            botright.BackColor = Color.LightGray;
            disptl.BackColor = Color.LightGray;
            disptm.BackColor = Color.LightGray;
            disptr.BackColor= Color.LightGray;
            dispml.BackColor = Color.LightGray;
            dispmm.BackColor = Color.LightGray;
            dispmr.BackColor = Color.LightGray;
            dispbl.BackColor = Color.LightGray;
            dispbm.BackColor = Color.LightGray;
            dispbr.BackColor = Color.LightGray;
        }

        private void topleft_Click(object sender, EventArgs e)
        {
            ToggleButton(0, ((Button)sender));
        }

        private void topmid_Click(object sender, EventArgs e)
        {
            ToggleButton(1, ((Button)sender));
        }

        private void topright_Click(object sender, EventArgs e)
        {
            ToggleButton(2, ((Button)sender));
        }

        private void midleft_Click(object sender, EventArgs e)
        {
            ToggleButton(3, ((Button)sender));
        }

        private void midmid_Click(object sender, EventArgs e)
        {
            ToggleButton(4, ((Button)sender));
        }

        private void midright_Click(object sender, EventArgs e)
        {
            ToggleButton(5, ((Button)sender));
        }

        private void botleft_Click(object sender, EventArgs e)
        {
            ToggleButton(6, ((Button)sender));
        }

        private void botmid_Click(object sender, EventArgs e)
        {
            ToggleButton(7, ((Button)sender));
        }

        private void botright_Click(object sender, EventArgs e)
        {
            ToggleButton(8, ((Button)sender));
        }

        private void identify_Click(object sender, EventArgs e)
        {
            Anominaly(usrpatrn);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
