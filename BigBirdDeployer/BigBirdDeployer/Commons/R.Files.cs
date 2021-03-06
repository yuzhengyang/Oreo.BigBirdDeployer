﻿using Azylee.Core.IOUtils.DirUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigBirdDeployer.Commons
{
    public static partial class R
    {
        public static class Files
        {
            public static string App = Application.ExecutablePath;
            public static string Settings = DirTool.Combine(Paths.Settings, "Settings.ini");
            public static string NewStorageReadme = DirTool.Combine(Paths.NewStorage, "readme.txt");
        }
    }
}
