﻿using Umbraco.Core;
using Umbraco.Core.Builder;
using Umbraco.Core.Composing;

namespace Umbraco.Web.Common.Profiler
{
    internal class WebProfilerComposer : ComponentComposer<WebProfilerComponent>, ICoreComposer
    {
        public override void Compose(IUmbracoBuilder builder)
        {
            base.Compose(builder);

            builder.Services.AddUnique<WebProfilerHtml>();
        }
    }
}
