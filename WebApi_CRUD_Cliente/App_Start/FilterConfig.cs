﻿using System.Web;
using System.Web.Mvc;

namespace WebApi_CRUD_Cliente
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
