using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataPenjualan
    {

        public Guid DataPenjualanId { get; set; }
        public string NoRegistrasiPenjualan { get; private set; }
        public Guid? DataSPKId { get; private set; }
        public Guid? DataKonsumenId { get; private set; }
        public Guid? MasterLeasingCabangId { get; private set; }
        public string NoBuku { get; private set; }
        public Guid? SalesUserId { get; private set; }
        public string Keterangan { get; private set; }
        public string Batal { get; private set; }
        public Guid? MasterKategoriPenjualanId { get; private set; }
        public string Mediator { get; private set; }
        //   public int? KdMarco { get; set; }
        public Guid? UserInputId { get; private set; }
        public string UserNameInput { get; private set; }
        public DateTime? TanggalPenjualan { get; private set; }
        public int NoUrutId { get; set; }
        protected DataPenjualan()
        {

        }
        private DataPenjualan(Guid? dataSPKId, Guid? dataKonsumenId, Guid? masterLeasingCabangId, string noBuku, Guid? salesUserId, string keterangan,  Guid? masterKategoriPenjualanId, string mediator, string userNameInput)
        {
            DataPenjualanId = Guid.NewGuid();

        NoRegistrasiPenjualan = KodeRegistrasiPenjualan(DateTime.Now);
            DataSPKId = dataSPKId;
            DataKonsumenId = dataKonsumenId;
            MasterLeasingCabangId = masterLeasingCabangId;
            NoBuku = noBuku;
            SalesUserId = salesUserId;
            Keterangan = keterangan;
         //   Batal = batal;
            MasterKategoriPenjualanId = masterKategoriPenjualanId;
            Mediator = mediator;
           // UserInputId = userInputId;
            UserNameInput = userNameInput;
           // TanggalPenjualan = tanggalPenjualan;
        }
        public static DataPenjualan CreateDataPenjualan(Guid? dataSPKId, Guid? dataKonsumenId, Guid? masterLeasingCabangId, string noBuku, Guid? salesUserId, string keterangan, Guid? masterKategoriPenjualanId, string mediator, string userNameInput)
        {
            return new DataPenjualan(dataSPKId,dataKonsumenId,masterLeasingCabangId,noBuku,salesUserId,keterangan,masterKategoriPenjualanId,mediator,userNameInput);
        }

        private string KodeRegistrasiPenjualan(DateTime Tanggal)
        {
            var NoRegistrasiSPK = string.Format("{0}{1}{2}{3}", Tanggal.Year.ToString(), Tanggal.Month.ToString(), DateTime.UtcNow.Date.Day.ToString(), Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK");

            //var NoRegistrasiSPK = DateTime.UtcNow.Date.Year.ToString() +
            //  DateTime.UtcNow.Date.Month.ToString() +
            //  DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK";

            return NoRegistrasiSPK;

        }


        private readonly List<DataPenjualanDetail> _dataPenjualanDetails = new List<DataPenjualanDetail>();
        public IReadOnlyCollection<DataPenjualanDetail> DataPenjualanDetails => _dataPenjualanDetails.AsReadOnly();

        public DataPenjualanDetail AddDataPenjualanDetail(Guid? dataPenjualanId, Guid? stokUnitId, decimal? offTheRoad, decimal? bBN, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah)
        {
            var dtPenjualanDetail = DataPenjualanDetail.CreateDataPenjualanDetail(dataPenjualanId,stokUnitId,offTheRoad,bBN,hargaOTR,uangMuka,diskonKredit,diskonTunai,subsidi,promosi,komisi,joinPromo1,joinPromo2,sPF,sellOut,dendaWilayah);
                _dataPenjualanDetails.Add(dtPenjualanDetail);
                return dtPenjualanDetail;
        }

        public DataPenjualanDetail EditDataPenjualanDetail(Guid? dataPenjualanId, Guid? stokUnitId, decimal? offTheRoad, decimal? bBN, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid dataPenjualanDetailId)
        {
            var dtPenjualanDetail = _dataPenjualanDetails.FirstOrDefault(x=>x.DataPenjualanDetailId==dataPenjualanDetailId);
            dtPenjualanDetail.EditDataPenjualanDetail(dataPenjualanId,stokUnitId, offTheRoad, bBN, hargaOTR, uangMuka, diskonKredit, diskonTunai, subsidi, promosi, komisi, joinPromo1, joinPromo2, sPF, sellOut, dendaWilayah);

            return dtPenjualanDetail;

        }
    }
}
