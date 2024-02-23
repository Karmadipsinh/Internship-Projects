﻿using Hallodoc.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDoc.LogicLayer.Patient_Interface.PatientDashboardInterface
{
    public interface IPatientDashboard
    {
        public User CurrentUserIdFromUser(int id);
        public List<TableContent> FetchDataFromContentTable(int id);
        
        
    }
}

