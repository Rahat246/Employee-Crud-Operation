﻿using System.Web;
using System.Web.Mvc;

namespace Employee_Crud_Operation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
