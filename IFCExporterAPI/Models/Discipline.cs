﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCExporterAPI.Models
{
    public class Discipline
    {
        public string Name { get; set; }
        public List<Export> Exports { get; set; }
        public FileData StartFile { get; set; }
    }
}
