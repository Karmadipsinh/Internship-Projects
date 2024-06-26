﻿using HalloDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDoc.DataLayer.ViewModels.AdminViewModels
{
    public class PatientRecordViewModel
    {
        public List<RequestWithFileCountModel> Query { get; set; }
        public AdminNavbarViewModel? adminNavbarViewModel { get; set; }
    }
}
