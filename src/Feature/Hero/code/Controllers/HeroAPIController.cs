﻿using System;
using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace Helixbase.Feature.Hero.Controllers
{
    public class HeroAPIController : SitecoreController
    {
        /// <summary>
        /// Not used, here to demonstrate routes found in RegisterRoutes.cs
        /// </summary>
        /// <returns></returns>
        public ActionResult TestAction()
        {
            throw new NotImplementedException("this is a test");
        }
    }
}