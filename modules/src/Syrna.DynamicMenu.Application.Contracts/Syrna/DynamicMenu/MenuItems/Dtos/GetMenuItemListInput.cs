﻿using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Syrna.DynamicMenu.MenuItems.Dtos
{
    public class GetMenuItemListInput : PagedAndSortedResultRequestDto
    {
        public string ParentId { get; set; }
        //public Func<string, Task> ParentIdChanged { get; set; }
    }
}