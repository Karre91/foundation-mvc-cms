﻿using EPiServer.Authorization;
using EPiServer.Security;
using EPiServer.Shell.Navigation;
using System.Collections.Generic;

namespace Foundation.Infrastructure.Cms
{
    [MenuProvider]
    public class CmsMenuProvider : IMenuProvider
    {
        private const string MainMenuPath = MenuPaths.Global + "/extensions";

        public IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new SectionMenuItem("Extensions", MainMenuPath)
            {
                IsAvailable = (_) => PrincipalInfo.CurrentPrincipal.IsInRole(Roles.CmsAdmins),
                SortIndex = 6000
            });

            menuItems.Add(new UrlMenuItem("Bulk Update", MainMenuPath + "/bulkupdate", "/episerver/foundation/bulkupdate")
            {
                SortIndex = 100,
            });

            return menuItems;
        }
    }
}
