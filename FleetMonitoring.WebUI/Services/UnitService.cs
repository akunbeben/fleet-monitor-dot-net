using FleetMonitoring.Entity.Models;
using FleetMonitoring.WebUI.Models;
using System;
using Mapster;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FleetMonitoring.WebUI.ViewModels;

namespace FleetMonitoring.WebUI.Services
{
    public static class UnitService
    {
        public static UnitModel MappingToView(Unit collection)
        {
            UnitModel unit = collection.Adapt<UnitModel>();

            return unit;
        }

        public static Unit MappingToModel(UnitModel collection, bool onUpdate = false)
        {
            var unit = collection.Adapt<Unit>();

            if (!onUpdate)
            {
                unit.CreatedBy = "Benny Rahmat";
                unit.CreatedAt = DateTime.Now;
            }

            unit.UpdatedAt = DateTime.Now;

            return unit;
        }
    }
}