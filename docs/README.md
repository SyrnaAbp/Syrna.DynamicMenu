# Abp.DynamicMenu

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FSyrna%2FAbp.DynamicMenu%2Fmaster%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/Syrna.Abp.DynamicMenu.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/Syrna.Abp.DynamicMenu.Domain.Shared)
[![NuGet Download](https://img.shields.io/nuget/dt/Syrna.Abp.DynamicMenu.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/Syrna.Abp.DynamicMenu.Domain.Shared)
[![Discord online](https://badgen.net/discord/online-members/xyg8TrRa27?label=Discord)](https://discord.gg/xyg8TrRa27)
[![GitHub stars](https://img.shields.io/github/stars/Syrna/Abp.DynamicMenu?style=social)](https://www.github.com/Syrna/Abp.DynamicMenu)

An abp module that dynamically creates menu items for ABP UI projects in runtime.

![demo.gif](/docs/images/demo.gif)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/Syrna/SyrnaGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * Syrna.Abp.DynamicMenu.Application
    * Syrna.Abp.DynamicMenu.Application.Contracts
    * Syrna.Abp.DynamicMenu.Domain
    * Syrna.Abp.DynamicMenu.Domain.Shared
    * Syrna.Abp.DynamicMenu.EntityFrameworkCore
    * Syrna.Abp.DynamicMenu.HttpApi
    * Syrna.Abp.DynamicMenu.HttpApi.Client
    * Syrna.Abp.DynamicMenu.Web

1. Add `DependsOn(typeof(AbpDynamicMenuXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/Syrna/SyrnaGuide/blob/master/docs/How-To.md#add-module-dependencies))

1. Add `builder.ConfigureAbpDynamicMenu();` to the `OnModelCreating()` method in **MyProjectMigrationsDbContext.cs**.

1. Add EF Core migrations and update your database. See: [ABP document](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=MVC&DB=EF#add-database-migration).

## Usage

1. Create a dynamic menu item on the management page.

2. Refresh the page and you can see the menu item you just created.

## Road map

- [ ] More customizable options for menu items.
