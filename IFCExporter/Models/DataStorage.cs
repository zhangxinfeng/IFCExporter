﻿using Autodesk.AutoCAD.Interop;
using IFCExporterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFCExporter.Models
{
    public static class DataStorage
    {
        public static IfcProjectInfo ProjectInfo { get; set; }
        public static List<string> ExportsToRun { get; set; }
        public static List<string> SelectedExports { get; set; }
        public static List<string> FilesWithChanges { get; set; }
        public static List<string> AllFiles { get; set; }
        public static AcadApplication app { get; set; }
        public static string logFileLocation { get; set; }
    }
}
