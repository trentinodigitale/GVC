using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common
{
    public enum PageActions : int
    {
        OnlyCreate = 0,
        Show = 2,
        ShowDialog = 4,
        ShowMdiChild = 8
    }

    public enum TabSheetNames : int
    {
        Adhesions = 100,
        ComunicationsBaseSocial = 200,
        Revisions = 300,
        ForcedProcedures = 400,
        StatutaryChanges = 500,
        ForcedLiquidations = 600
    }
}
