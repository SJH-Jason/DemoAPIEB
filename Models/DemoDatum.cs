﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DemoAPIEB.Models
{
    public partial class DemoDatum
    {
        public int 出表日期 { get; set; }
        public int 資料年月 { get; set; }
        public int 公司代號 { get; set; }
        public string 公司名稱 { get; set; }
        public string 產業別 { get; set; }
        public int? 營業收入當月營收 { get; set; }
        public int? 營業收入上月營收 { get; set; }
        public int? 營業收入去年當月營收 { get; set; }
        public double? 營業收入上月比較增減 { get; set; }
        public double? 營業收入去年同月增減 { get; set; }
        public int? 累計營業收入當月累計營收 { get; set; }
        public int? 累計營業收入去年累計營收 { get; set; }
        public double? 累計營業收入前期比較增減 { get; set; }
        public string 備註 { get; set; }
    }
}