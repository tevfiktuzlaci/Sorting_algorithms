using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class frmSorting : Form
    {
        public frmSorting()
        {
            InitializeComponent();
        }
        int[] dizi = { 5, 1, 12, -5, 16 };
        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort bs = new BubbleSort();
            txtOnce.Text = bs.PrintItems(dizi);
            bs.Sort(dizi);
            txtSonra.Text = bs.PrintItems(dizi);
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            
            SelectionSort ss = new SelectionSort();
            txtOnce.Text = ss.PrintItems(dizi);
            ss.Sort(dizi);
            txtSonra.Text = ss.PrintItems(dizi);

        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
                       
            InsertionSort ins = new InsertionSort();
            txtOnce.Text = ins.PrintItems(dizi);
            ins.Sort(dizi);
            txtSonra.Text = ins.PrintItems(dizi);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            //int[] dizi = { 2, 17, -4, 42, 9, 26, 11, 3, 5 };
            QuickSort QS = new QuickSort();
            txtOnce.Text = QS.PrintItems(dizi);
            QS.Sort(dizi);
            txtSonra.Text = QS.PrintItems(dizi);

        }
    }
}
