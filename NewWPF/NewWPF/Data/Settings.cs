﻿using System.Globalization;
using System.IO;
using System.Reflection;

namespace NewWPF.Data
{
    public class Settings
    {
        /// <summary>
        /// Default Culture Info
        /// </summary>
        public static readonly CultureInfo CultureInfo = new CultureInfo("tr-TR");

        public static readonly string ImageFilter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|All files (*.*)|*.*";

        public static readonly string CurrentDirectory = new FileInfo(Assembly.GetEntryAssembly()?.Location).DirectoryName;

        public static readonly string UserAgentHeader =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
            "(KHTML, like Gecko) Chrome/81.0.4044.129 Safari/537.36 OPR/68.0.3618.63";
    }
}