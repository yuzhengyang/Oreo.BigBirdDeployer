﻿using Azylee.Core.IOUtils.DirUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigBirdConsole.Commons
{
    public static partial class R
    {
        public static class Files
        {
            public static string App = Application.ExecutablePath;
            public static string Settings = DirTool.Combine(Paths.App, "Settings.ini");
            public static string NewStorageReadme = DirTool.Combine(Paths.NewStorage, "readme.txt");

            public static string ProjectStatus = DirTool.Combine(Paths.Store, "ProjectStatus.txt");
            public static string SystemStatus = DirTool.Combine(Paths.Store, "SystemStatus.txt");
        }
    }
}
