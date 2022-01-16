using MediatR;
using SumberMas2015.DDD.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.IntegrationEvent
{
    public class StokUnitAddedIntegrationEvent : INotification, IIntegrationEvent
    {
        public StokUnitAddedIntegrationEvent(Guid stokUnitId, Guid masterBarangId, string nomorRangka, string nomorMesin, string namaSupplier, string warna)
        {
            StokUnitId=stokUnitId;
            MasterBarangId=masterBarangId;
            NomorRangka=nomorRangka;
            NomorMesin=nomorMesin;
            NamaSupplier=namaSupplier;
            Warna=warna;
        }

        public Guid StokUnitId { get; set; }
        public Guid MasterBarangId { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public string Warna { get; set; }
        public string NamaSupplier { get; set; }
    }
}
