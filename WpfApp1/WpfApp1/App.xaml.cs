﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "Contactos.db";
        static string folderpath = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments);
        public static string databasepath = System.IO.Path.Combine(folderpath, databaseName);
    }
}
