﻿using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace WebsiteQuanAo.Models
{
    public class ProCom
    {
        public ProcductDetails procductDetails { get; set; }
        public IPagedList<BinhLuan> Comments { get; set; }
    }
}