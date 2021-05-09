using FleetMonitoring.Entity.Models;
using FleetMonitoring.WebUI.Models;
using System;
using Mapster;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public static string MockLocation()
        {
            string[] coordinates = new string[5]
            {
                "-2.293974605144342,114.87087965011598",
                "-2.832958795292959,114.7855854034424",
                "-3.762121219821541,114.43393707275392",
                "-4.028681556578677,116.03265702724458",
                "-3.3300042181994853,114.55140709877016"
            };

            return coordinates[new Random().Next(0, coordinates.Length)];
        }
    }
}