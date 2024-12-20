﻿using Blazorise.DataGrid;
using Syrna.DynamicMenu.MenuItems.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Volo.Abp.BlazoriseUI.Components;

namespace Syrna.DynamicMenu.Blazor.Components;

public partial class MenuItemPathComponent : ComponentBase
{
    [Parameter]
    public object Data { get; set; }

    private MenuItemViewModel Info => Data.As<MenuItemViewModel>();

    [CascadingParameter]
    public DataGridColumn<object>? DataGridColumn { get; set; }
    
    protected virtual async Task ClickedAsync()
    {
        await Info.ParentIdChanged(Info.Id);
    }
}