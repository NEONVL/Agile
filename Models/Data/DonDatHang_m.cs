﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project8.Models.Data
{
    public class DonDatHang_m
    {
        public int MaDDH { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayGiao { get; set; }
        public bool TinhTrang { get; set; }
        public int MaKH { get; set; }
    }
}