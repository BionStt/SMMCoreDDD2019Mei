using SumberMas2015.SalesMarketing.Dto.DataKonsumen;
using SumberMas2015.SalesMarketing.Dto.DataSPK;
using SumberMas2015.SalesMarketing.Dto.MasterBarang;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.Dto.PermohonanBPKB;
using SumberMas2015.SalesMarketing.Dto.PermohonanFaktur;
using SumberMas2015.SalesMarketing.Dto.PermohonanSTNK;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualanDetail;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKendaraan;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKredit;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKLeasing;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKSurvei;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using SumberMas2015.SalesMarketing.ServiceApplication.Penjualan.Commands.CreatePenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.PermohonanBPKB.Commands.CreatePermohonanBPKB;
using SumberMas2015.SalesMarketing.ServiceApplication.PermohonanFaktur.Commands.CreatePermohonanFaktur;
using SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Commands.CreatePermohonanSTNK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.DtoMapping
{
    public static class DataKonsumenRequestMapping
    {
        public static CreatePermohonanBPKBCommand ToCommand(this CreatePermohonanBPKBRequest model)
        {
            return new CreatePermohonanBPKBCommand {
            NoBpkb = model.NoBPKB,
            NoUrutFaktur = model.NoUrutFaktur ,
            TanggalTerimaBPKB = model.TanggalTerimaBPKB

            };
        }
        public static CreatePermohonanSTNKCommand ToCommand(this CreatePermohonanSTNKRequest model) 
        {
            return new CreatePermohonanSTNKCommand { 
            BbnPabrik = model.BbnPabrik,
            BiayaTambahan = model.BiayaTambahan,
            ProgresifKe = model.ProgresifKe,
            FormA = model.FormA,
            PajakProgresif = model.PajakProgresif,
            Birojasa = model.Birojasa,
            NomorPlat = model.NomorPlat,
            NoStnk = model.NoStnk,
            NoUrutFaktur = model.NoUrutFaktur,
            PajakStnk = model.PajakStnk,
            Perwil = model.Perwil,
            TanggalBayarSTNK = model.TanggalBayarSTNK

            
            };
        }
        public static CreateDataPenjualanDetailCommand ToCommand(this CreateDataPenjualanDetailRequest model)
        {
            return new CreateDataPenjualanDetailCommand {
            bBN=model.BBN,
            dataPenjualanId = model.KodePenjualan,
            dendaWilayah = model.DendaWilayah,
            diskonKredit = model.DiskonKredit,
            diskonTunai = model.DiskonTunai,
            hargaOTR = model.HargaOTR,
            joinPromo1 = model.JoinPromo1,
            joinPromo2 = model.JoinPromo2,
            komisi = model.Komisi,
               offTheRoad = model.OffTheRoad,
               promosi = model.promosi,
               sellOut = model.SellOut,
               sPF = model.SPF,
                stokUnitId = model.NoUrutSO,
                subsidi = model.Subsidi,
                uangMuka = model.uangMuka





            };
        }
        public static CreatePenjualanCommand ToCommand(this CreatePenjualanRequest model)
        {
            return new CreatePenjualanCommand {
                DataSPKId = model.DataSPKId,
                DataKonsumenId = model.DataKonsumenId,
                MasterLeasingCabang = model.MasterLeasingCabang,
                NoBuku = model.NoBuku,
                MasterKategoriPenjualan = model.MasterKategoriPenjualan,
                Keterangan = model.Keterangan,
                UserNameInput =model.UserNameInput,
                Mediator = model.Mediator

            };

        }
        public static CreateMasterBarangCommand ToCommand(this CreateMasterBarangRequest model)
        {
            return new CreateMasterBarangCommand {
                NamaBarang = model.NamaBarang,
                NomorRangka = model.NomorRangka,
                NomorMesin =model.NomorMesin,
                Merek = model.Merek,
                KapasitasMesin = model.KapasitasMesin,
                HargaOff = model.HargaOff,
                BBn = model.BBn,
                TahunPerakitan = model.TahunPerakitan,
                TypeKendaraan  = model.TypeKendaraan

            };
        }
        public static CreateDataSPKKendaraanCommand ToCommand(this CreateDataSPKKendaraanRequest model)
        {
            return new CreateDataSPKKendaraanCommand {
            MasterBarangId = model.MasterBarangId,
            NamaSTNK = model.NamaSTNK,
            NoKTPSTNK = model.NoKTPSTNK,
            TahunPerakitan = model.TahunPerakitan,
            Warna = model.Warna


            };
        }
        public static CreateDataSPKLeasingCommand ToCommand(this CreateDataSPKLeasingRequest model)
        {
            return new CreateDataSPKLeasingCommand {
                Angsuran = model.Angsuran,
                Mediator = model.Mediator,
                NamaSales = model.NamaSalesId,
                NamaCMO = model.NamaCMO,
                Tenor = model.Tenor,
                TanggalSurvei = model.TanggalSurvei


            };
        }
        public static CreateDataSPKKreditCommand ToCommand(this CreateDataSPKKreditRequest model)
        {
            return new CreateDataSPKKreditCommand {

                BiayaAdministrasiKredit = model.BiayaAdministrasiKredit,
                BiayaAdministrasiTunai = model.BiayaAdministrasiTunai,
                BBN = model.BBN,
                DendaWilayah = model.DendaWilayah,
                DiskonDP = model.DiskonDP,
                DiskonTunai = model.DiskonTunai,
                DPPriceList = model.DPPriceList,
                Komisi = model.Komisi,
                OffTheRoad =model.OffTheRoad,
                Promosi = model.Promosi,
                UangTandaJadiTunai = model.UangTandaJadiTunai,
               UangTandaJadiKredit=model.UangTandaJadiKredit,
               DataSPKId = model.DataSPKId

            };
        }
        public static CreateDataSPKSurveiCommand ToCommand(this CreateDataSPKSurveiRequest model)
        {
            return new CreateDataSPKSurveiCommand {
                NamaPemesan = Domain.ValueObjects.Name.CreateName(model.NamaDepan, model.NamaBelakang),
                AlamatPemesan = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan, model.Kelurahan, model.Kecamatan, model.Kota, model.Propinsi, model.KodePos,
                model.NomorTelepon, model.NomorFaks, model.NomorHandphone),
                NoKTPPemesan = model.NomorKTPPemesan,
                PekerjaanPemesan = model.PekerjaanPemesan,
                DataNPWPPemesan = Domain.ValueObjects.DataNPWP.Create(model.NomorNPWP,model.NamaNPWP,Domain.ValueObjects.Alamat.CreateAlamat(model.JalanNPWP,model.KelurahanNPWP,model.KecamatanNPWP,
                model.KotaNPWP,model.PropinsiNPWP,model.KodePosNPWP,model.NomorTeleponNPWP,model.NomorFaksNPWP,model.NomorHandphoneNPWP)),
                DataSPKId = model.DataSPKId,
                LokasiSPK = model.LokasiSPK

            };
        }
        public static CreateDataKonsumenCommand ToCommand(this CreateDataKonsumenRequest model )
        {
            return new CreateDataKonsumenCommand
            {
                Nama = Domain.ValueObjects.Name.CreateName(model.NamaDepan, model.NamaBelakang),
                Alamat = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan,model.Kelurahan,model.Kecamatan,
                model.Kota,model.Propinsi,model.KodePos,model.NomorTelepon,model.NomorFaks,model.NomorHandphone),
                JenisKelamin = model.JenisKelamin,
                AlamatKirim = Domain.ValueObjects.Alamat.CreateAlamat(model.JalanKirim, model.KelurahanKirim, model.KecamatanKirim,
                model.KotaKirim, model.PropinsiKirim, model.KodePosKirim, model.NomorTeleponKirim, model.NomorFaksKirim, model.NomorHandphoneKirim),
                NamaBPKB = Domain.ValueObjects.Name.CreateName(model.NamaDepanBPKB, model.NamaBelakangBPKB),
                NoKtp = model.NomorKtp,
                Agama = model.Agama,
                TanggalLahir = model.TangggalLahir,
                KodeBidangPekerjaan = model.KodeBidangPekerjaan,
                NamaBidangPekerjaan = model.NamaBidangPekerjaan,
                KodeBidangUsaha = model.KodeBidangUsaha,
                NamaBidangUsaha = model.NamaBidangUsaha,
                Email = model.Email,
                UserIDPeg = model.UserIDPeg,
                UserInput = model.UserInput



            };
        }

        public static CreatePermohonanFakturCommand ToCommand(this CreatePermohonanFakturRequest model) 
        {
            return new CreatePermohonanFakturCommand { 
            Alamat = model.Alamat,
            HandphoneF = model.HandphoneF,
            Kecamatan = model.Kecamatan,
            Kelurahan = model.Kelurahan,
            KodePenjualanDetail = model.KodePenjualanDetail,
            KodePos = model.KodePos,
            Kota = model.Kota,
            NamaFaktur = model.NamaFaktur,
            NomorFaks = model.NomorFaks,
            NomorKTP = model.NomorKTP,
            Propinsi = model.Propinsi,
            TanggalInput = model.TanggalInput,
            TanggalLahir = model.TanggalLahir,
            Telepon = model.Telepon
            
            };
        }

    }
}
