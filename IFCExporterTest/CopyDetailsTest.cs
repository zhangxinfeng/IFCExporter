﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IFCExporter.Helpers;
using System.IO;

namespace IFCExporterTest
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void DirectoryCopy_CheckWhatFilesGetsCopied()
        {
            //var Copy = new Copier();
            //string destDir = @"C:\\IFCEXPORT\\Projects\\MH2\\RIE\\E41\\00 Modellfiler";
            //bool FileTypeBool = true;
            //string fileType = @".dwg";


            //Copy.DirectoryCopy(
            //    @"O:\\A050000\\A051350\\3.7 Tegninger\\E40 RIE\\E41\00 Modellfiler", 
            //    destDir, 
            //    false, 
            //    fileType               
            //    );

            //DirectoryInfo dir = new DirectoryInfo(destDir);

            //var Files = dir.GetFiles();

            //foreach (var file in Files)
            //{
            //    if (file.Extension != fileType && file.Extension != ".dwl2" && file.Extension != ".bak" && file.Extension != ".dwl")
            //    {                    
            //        System.Windows.Forms.MessageBox.Show("The file \"" + file.Name + "\" is not a dwg.");
            //        FileTypeBool = false;
            //    }
            //}

            //Assert.IsTrue(FileTypeBool);
        }



    }
}
