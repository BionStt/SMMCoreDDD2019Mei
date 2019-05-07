using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Domain.Entities
{
    public class MasterKategoriCaraPembayaran
    {

        public int NoUrutCaraBayar { get; set; }
       
        public string CaraPembayaran { get; set; }
    }
}
