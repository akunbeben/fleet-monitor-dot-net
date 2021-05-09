using FleetMonitoring.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FleetMonitoring.WebUI.ViewModels
{
    public class UnitViewModel
    {
        public UnitModel Unit { get; set; }

        public SelectList Owner { get; set; }
    }
}