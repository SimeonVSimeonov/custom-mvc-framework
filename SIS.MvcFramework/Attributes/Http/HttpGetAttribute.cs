﻿using System;
using SIS.HTTP.Enums;

namespace SIS.MvcFramework.Attributes.Http
{
    public class HttpGetAttribute : BaseHttpAttribute
    {
        public override HttpRequestMethod Method => HttpRequestMethod.Get;
    }
}
