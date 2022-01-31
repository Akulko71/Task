using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    static class Function
    {
        public static void SortCmb(ref List<NameCmb> ListCmb, List<FormatDataEmpl> db)
        {
            foreach (FormatDataEmpl f in db)
            {
                bool isRepeat = false;
                foreach (NameCmb d in ListCmb)
                {
                    if (d.name == f.dep)
                    {
                        isRepeat = true;
                        break;
                    }
                }
                if (isRepeat)
                {
                    continue;
                }
                else
                {
                    ListCmb.Add(new NameCmb { name = f.dep });
                }
            }
        }
    }
}
