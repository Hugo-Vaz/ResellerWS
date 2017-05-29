﻿using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public static class LocationMapper
    {
        public static Location[] ConvertDatatableToModel(DataTable data)
        {
            List<Location> list = new List<Location>();
            foreach(DataRow row in data.Rows)
            {
                Location l = new Location();
                l.WestconCode = row["Id"].ToString();
                l.Name = row["Name"].ToString();

                list.Add(l);
            }

            return list.ToArray();
        }
    }
}