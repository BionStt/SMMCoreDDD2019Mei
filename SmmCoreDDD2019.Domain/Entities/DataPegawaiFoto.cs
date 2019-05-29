﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPegawaiFoto
    {
        public int NoUrut { get; set; }
        public byte[] Foto { get; set; }
    
        public DateTime? Tglinput { get; set; }
        public string Revisi { get; set; }
       
        public int? IDPegawai { get; set; }
        public string KodeBarcode { get; set; }
        public DataPegawai DataPegawai { get; set; }

    }
}