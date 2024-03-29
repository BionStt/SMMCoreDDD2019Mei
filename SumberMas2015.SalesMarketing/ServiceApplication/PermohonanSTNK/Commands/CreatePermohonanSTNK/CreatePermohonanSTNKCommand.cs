﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Commands.CreatePermohonanSTNK
{
    public class CreatePermohonanSTNKCommand:IRequest<Guid>
    {
      
        public DateTime? TanggalBayarSTNK { get; set; }
      
        public int? NoUrutFaktur { get; set; }
     
        public string NoStnk { get; set; }
    
        public decimal PajakStnk { get; set; }
      
        public decimal Birojasa { get; set; }
      
        public decimal BiayaTambahan { get; set; }
      
        public decimal FormA { get; set; }
      
        public string NomorPlat { get; set; }
      
        public decimal? Perwil { get; set; }
   
        public decimal? PajakProgresif { get; set; }
       
        public decimal? BbnPabrik { get; set; }
     
        public int ProgresifKe { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
