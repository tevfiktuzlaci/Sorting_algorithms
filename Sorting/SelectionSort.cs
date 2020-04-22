using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort: SortBase
    {
        public override void Sort(int[] items)
        {
            int kucukSayi;
            
            for (int i = 0; i < items.Length - 1; i++)
            {
                kucukSayi = i;

                for (int j = i+1 ; j < items.Length; j++)
                {
                    if (items[j]<items[kucukSayi])
                    {
                        kucukSayi = j;
                    }
                }

                int temp;

                temp = items[i];
                items[i] = items[kucukSayi];
                items[kucukSayi] = temp;
               

            }
           
        }
    }
}
