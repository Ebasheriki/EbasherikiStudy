﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IFaculty
    {
        IEnumerable<Faculty> Faculties { get; }
    }
}