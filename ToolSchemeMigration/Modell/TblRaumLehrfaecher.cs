﻿using System;
using System.Collections.Generic;

namespace HtlWeiz.WkstPlaner.ToolSchemeMigration.Modell
{
    public partial class TblRaumLehrfaecher
    {
        public string Raumnummer { get; set; }
        public string LehrfachKurzbezeichnung { get; set; }

        public virtual TblLehrfaecher LehrfachKurzbezeichnungNavigation { get; set; }
        public virtual TblRaeume RaumnummerNavigation { get; set; }
    }
}