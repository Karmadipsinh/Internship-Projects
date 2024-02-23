﻿using Hallodoc.Data;
using HalloDoc.DataLayer.ViewModels;
using Hallodoc.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDoc.LogicLayer.Patient_Repository.PatientRequest
{
    public class CreateConciergeRequest
    {
        private readonly ApplicationDbContext _db;

        public CreateConciergeRequest(ApplicationDbContext db)
        {
            _db = db;
        }

        public BlockRequest EmailFromBlockReq(RequestViewModelConcierge model)
        {
            return _db.BlockRequests.FirstOrDefault(u => u.Email == model.Email);
        }
        //public Region StateFromRegionInCreateConciergeRequest(RequestViewModelPatient model)
        //{
        //    return _db.Regions.FirstOrDefault(u => u.Name == model.State.Trim().ToLower().Replace(" ", ""));
        //}
        //public AspNetUser EmailFromAspnetuser(RequestViewModelPatient model)
        //{
        //    return _db.AspNetUsers.SingleOrDefault(u => u.Email == model.Email);
        //}
    }
}
