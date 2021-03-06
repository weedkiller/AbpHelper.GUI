﻿using System.Threading.Tasks;
using EasyAbp.AbpHelper.Gui.AbpCli.Add;
using Microsoft.AspNetCore.Components;

namespace EasyAbp.AbpHelper.Gui.Blazor.Pages.AbpCli.Components.Add
{
    public partial class AddModule
    {
        [Inject]
        private IAbpCliAddAppService Service { get; set; }
        
        protected override async Task InternalExecuteAsync()
        {
            await Service.AddModuleAsync(Input);
        }
    }
}
