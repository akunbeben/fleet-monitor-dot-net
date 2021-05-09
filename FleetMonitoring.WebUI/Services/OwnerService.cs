using FleetMonitoring.Entity.Models;
using System;
using System.Web.Mvc;
using System.Linq;
using FleetMonitoring.WebUI.Models;
using Mapster;
using System.Text;
using System.Text.RegularExpressions;

namespace FleetMonitoring.WebUI.Services
{
    public static class OwnerService
    {
        public static Owner MappingOwnerModel(OwnerModel collection, bool onUpdate = false)
        {
            var owner = collection.Adapt<Owner>();

            if (!onUpdate)
            {
                owner.CreatedBy = "Benny Rahmat";
                owner.CreatedAt = DateTime.Now;
            }

            owner.UpdatedAt = DateTime.Now;

            return owner;
        }

        public static OwnerModel MappingToView(Owner collection)
        {
            OwnerModel owner = collection.Adapt<OwnerModel>();

            return owner;
        }

        public static object GetModelStateErrors(ModelStateDictionary state)
        {
            var errorList = state.Where(kvp => kvp.Value.Errors.Count > 0).ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );

            return errorList;
        }

        private static string ToUrlSlug(string value)
        {

            //First to lower case 
            value = value.ToLowerInvariant();

            //Remove all accents
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);

            value = Encoding.ASCII.GetString(bytes);

            //Replace spaces 
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

            //Remove invalid chars 
            value = Regex.Replace(value, @"[^\w\s\p{Pd}]", "", RegexOptions.Compiled);

            //Trim dashes from end 
            value = value.Trim('-', '_');

            //Replace double occurences of - or \_ 
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }
    }
}