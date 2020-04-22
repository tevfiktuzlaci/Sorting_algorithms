using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort: SortBase
    {
        public override void Sort(int[] items)
        {
            quickSort(items, 0, items.Length - 1);
        }

        public void quickSort(int[] items, int altindis, int ustindis)
        {
            // altindis o adımda sıralanan altdizinin ek küçük indisidir
            // üstindis o adımda sıralanan altdizinin ek büyük indisidir
            int i = altindis, j = ustindis, temp;

            // pivot
            int pivot = items[(altindis + ustindis) / 2];
            
            // Takas ile diziyi ayrıştırma
            do
            {                
                while (items[i] < pivot)
                    i++;
                
                while (items[j] > pivot)
                    j--;
            
                if (i <= j)
                {
                    temp = items[i]; 
                    items[i] = items[j]; 
                    items[j] = temp; 
                    i++;
                    j--;
                }
            } while (i <= j);

            // recursion
            if (altindis < j)
                quickSort(items, altindis, j);
            
            if (i < ustindis)
                quickSort(items, i, ustindis);
        } 

    }
}
