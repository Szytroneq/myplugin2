﻿using Exiled.API.Interfaces;

namespace myplugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        public bool Debug { get; set; }
    }
}
