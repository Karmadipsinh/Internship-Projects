﻿using HalloDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDoc.DataLayer.ViewModels.AdminViewModels
{
    public class BlockHistoryViewModel
    {
        //public List<BlockRequest> Query { get; set; }
        public List<BlockHistoryTable> Query { get; set; }
        public int PatientId { get; set; }
        public AdminNavbarViewModel? adminNavbarViewModel { get; set; }
        public string FirstName { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
}
