﻿using System.Threading.Tasks;
using Agility.NET.FetchAPI.Helpers;
using Agility.NET.FetchAPI.Models;
using Agility.NET.FetchAPI.Models.Data;
using Agility.NET.FetchAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agility.NET.Starter.ViewComponents.PageModules
{
    public class TextBlockWithImage: ViewComponent
    {
        private readonly FetchApiService _fetchApiService;

        public TextBlockWithImage(FetchApiService fetchApiService)
        {
            _fetchApiService = fetchApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(ModuleModel moduleModel)
        {
            var getParams = new GetItemParameters
            {
                ContentId = moduleModel.Model.Item.ContentID,
                Locale = moduleModel.Locale
            };
            var textBlockWithImage = await _fetchApiService.GetTypedContentItem<Agility.Models.TextBlockWithImage>(getParams);
            return View("/Views/PageModules/TextBlockWithImage.cshtml", textBlockWithImage);
        }
    }
}
