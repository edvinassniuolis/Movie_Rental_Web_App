﻿using System.Web.Mvc;

namespace Movie_Renta_Web_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RequireHttpsAttribute()); 
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
