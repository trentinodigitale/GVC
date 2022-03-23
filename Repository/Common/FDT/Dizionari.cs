using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    [Serializable]
    public partial class Dizionari : List<DizionarioFDT>
    {
        public void AddRange(object items)
        {
            if (items != null &&
                items is DizionarioFDT[])
            {
                List<DizionarioFDT> allItems = new List<DizionarioFDT>(items as DizionarioFDT[]);
                if (allItems != null &&
                    allItems.Count > 0)
                {
                    foreach (DizionarioFDT item in allItems)
                    {
                        this.Add(item);
                    }
                }
            }
        }

        public DizionarioFDT FindByID(int id)
        {
            DizionarioFDT returnValue = null;
            if (this.Count > 0)
            {
                foreach (DizionarioFDT item in this)
                {
                    if (item.IdElemento == id)
                    {
                        returnValue = item;
                        break;
                    }
                }
            }
            return returnValue;
        }
    }
}
