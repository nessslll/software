using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AdminWork
/// </summary>
public class AdminWork
{
    public AdminWork()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool KullanicLoginKontrol(string name, string password)
    {
        bool onay = false;
        List<SqlParameter> parameters = new List<SqlParameter>();
        parameters.Add(new SqlParameter("@name", name));
        parameters.Add(new SqlParameter("@parola", password));
        DataTable dt = DBW.GetDatas("kullaniciLogin", parameters);
        if (dt.Rows.Count > 0)
        {
            onay = true;
        }

        return onay;
    }
    public static bool AdminLoginControl(string name, string password)
    {
        bool onay = false;
        List<SqlParameter> parameters = new List<SqlParameter>();
        parameters.Add(new SqlParameter("@name", name));
        parameters.Add(new SqlParameter("@parola", password));
        DataTable dt = DBW.GetDatas("yoneticiLogin", parameters);
        if (dt.Rows.Count > 0)
        {
            onay = true;
        }

        return onay;
    }

    public static bool adresOlustur(int @kullaniciid, int @ilceid, int @mahalleid, int @subeid, string @adresbaslik, string @adrescadde, string @adressokak, string @adresapartman, string @adresdaire, string @adrestarif)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kullaniciid", kullaniciid));
        spParam.Add(new SqlParameter("@ilceid", ilceid));
        spParam.Add(new SqlParameter("@mahalleid", mahalleid));
        spParam.Add(new SqlParameter("@subeid", subeid));
        spParam.Add(new SqlParameter("@adresbaslik", adresbaslik));
        spParam.Add(new SqlParameter("@adrescadde", adrescadde));
        spParam.Add(new SqlParameter("@adressokak", adressokak));
        spParam.Add(new SqlParameter("@adresapartman", adresapartman));
        spParam.Add(new SqlParameter("@adresdaire", adresdaire));
        spParam.Add(new SqlParameter("@adrestarif", adrestarif));
        int rAff = DBW.InsertUpdateByProc("adresEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool icerikOlustur(string @icerikbaslik, string @icerikicerik)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@icerikbaslik", icerikbaslik));
        spParam.Add(new SqlParameter("@icerikicerik", icerikicerik));
        int rAff = DBW.InsertUpdateByProc("icerikEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool ilceOlustur(string @ilceadi)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@ilceadi", ilceadi));
        int rAff = DBW.InsertUpdateByProc("ilceEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool kullaniciOlustur(string @kullaniciadi,string @kullaniciisim,string @kullaniciparola,string @kullanicimail,string @kullanicitelefon,string @kullanicidogum,int @kullanicicinsiyet,int @istek,int onay)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kullaniciadi", kullaniciadi));
        spParam.Add(new SqlParameter("@kullaniciisim", kullaniciisim));
        spParam.Add(new SqlParameter("@kullaniciparola", kullaniciparola));
        spParam.Add(new SqlParameter("@kullanicimail", kullanicimail));
        spParam.Add(new SqlParameter("@kullanicitelefon", kullanicitelefon));
        spParam.Add(new SqlParameter("@kullanicidogum", kullanicidogum));
        spParam.Add(new SqlParameter("@kullanicicinsiyet", kullanicicinsiyet));
        spParam.Add(new SqlParameter("@istek", istek));
        spParam.Add(new SqlParameter("@onay", onay));
        int rAff = DBW.InsertUpdateByProc("kullaniciEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool mahalleOlustur(string @mahalleadi)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@mahalleadi", mahalleadi));
        int rAff = DBW.InsertUpdateByProc("mahalleEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool menuOlustur(string @menuadi)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@menuadi", menuadi));
        int rAff = DBW.InsertUpdateByProc("menuEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool mesajOlustur(string @gonderenadi,string @gonderenmail,string @gonderentelefon,string @gonderenmesaj)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@gonderenadi", gonderenadi));
        spParam.Add(new SqlParameter("@gonderenmail", gonderenmail));
        spParam.Add(new SqlParameter("@gonderentelefon", gonderentelefon));
        spParam.Add(new SqlParameter("gonderenmesaj", gonderenmesaj));
        int rAff = DBW.InsertUpdateByProc("mesajEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool subeOlustur(string @subeadi)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@subeadi", subeadi));
        int rAff = DBW.InsertUpdateByProc("subeEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool yiyecekOlustur(int @menuid,string @yiyecekadi,string @yiyecekicerik,decimal @yiyecekfiyat,string @yiyecekfotograf)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@menuid", menuid));
        spParam.Add(new SqlParameter("@yiyecekadi", yiyecekadi));
        spParam.Add(new SqlParameter("@yiyecekicerik", yiyecekicerik));
        spParam.Add(new SqlParameter("@yiyecekfiyat", yiyecekfiyat));
        spParam.Add(new SqlParameter("@yiyecekfotograf", yiyecekfotograf));
        int rAff = DBW.InsertUpdateByProc("yiyecekEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool albumOlustur(string @albumadi,string @albumresim)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@albumadi", albumadi));
        spParam.Add(new SqlParameter("@albumresim", albumresim));
        int rAff = DBW.InsertUpdateByProc("albumEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool fotografOlustur(int @albumid,string @fotoadi, string @fotourl)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@albumid", albumid));
        spParam.Add(new SqlParameter("@fotoadi", fotoadi));
        spParam.Add(new SqlParameter("@fotourl", fotourl));
        int rAff = DBW.InsertUpdateByProc("fotoEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool siparisOlustur(string @kullaniciadi, string @siparis, decimal @fiyat, DateTime @tarih, string @ip, string @subeadi, string @adres, string @adrestarifi, string @kampanyakodu, string @siparisaciklama)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kullaniciadi", kullaniciadi));
        spParam.Add(new SqlParameter("@siparis", siparis));
        spParam.Add(new SqlParameter("@fiyat", fiyat));
        spParam.Add(new SqlParameter("@tarih", tarih));
        spParam.Add(new SqlParameter("@ip", ip));
        spParam.Add(new SqlParameter("@subeadi", subeadi));
        spParam.Add(new SqlParameter("@adres", adres));
        spParam.Add(new SqlParameter("@adrestarifi", adrestarifi));
        spParam.Add(new SqlParameter("@kampanyakodu", kampanyakodu));
        spParam.Add(new SqlParameter("@siparisaciklama", siparisaciklama));
        int rAff = DBW.InsertUpdateByProc("siparisEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool kuponOlustur(string @kupon, decimal @tutar, DateTime @kuponbaslangic, DateTime @kuponbitis)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kupon", kupon));
        spParam.Add(new SqlParameter("@tutar", tutar));
        spParam.Add(new SqlParameter("@kuponbaslangic", kuponbaslangic));
        spParam.Add(new SqlParameter("@kuponbitis", kuponbitis));
        int rAff = DBW.InsertUpdateByProc("kuponEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool buyukSliderOlustur(string @fotourl)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@fotourl", fotourl));

        int rAff = DBW.InsertUpdateByProc("buyukSliderEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool kucukSliderOlustur(string @fotourl)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@fotourl", fotourl));

        int rAff = DBW.InsertUpdateByProc("kucukSliderEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }
    public static bool durumOlustur(string @durum,string @sure,int @aktif)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@durum", durum));
        spParam.Add(new SqlParameter("@sure", sure));
        spParam.Add(new SqlParameter("@aktif", aktif));
        int rAff = DBW.InsertUpdateByProc("durumEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool soruOlustur(string @soru, int @aktif)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@soru", soru));
        spParam.Add(new SqlParameter("@aktif", aktif));
        int rAff = DBW.InsertUpdateByProc("soruEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;
    }
    public static bool cevapOlustur(int @anketid, string @cevap, int @puan)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@anketid", anketid));
        spParam.Add(new SqlParameter("@cevap", cevap));
        spParam.Add(new SqlParameter("@puan", puan));
        int rAff = DBW.InsertUpdateByProc("cevapEkle", spParam.ToArray());
        if (rAff > 0)
        {
            return true;
        }
        return false;

    }

    public static bool adresGuncelle(int @kullaniciid, int @ilceid, int @mahalleid, int @subeid, string @adresbaslik, string @adrescadde, string @adressokak, string @adresapartman, string @adresdaire, string @adrestarif, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kullaniciid", kullaniciid));
        spParam.Add(new SqlParameter("@ilceid", ilceid));
        spParam.Add(new SqlParameter("@mahalleid", mahalleid));
        spParam.Add(new SqlParameter("@subeid", subeid));
        spParam.Add(new SqlParameter("@adresbaslik", adresbaslik));
        spParam.Add(new SqlParameter("@adrescadde", adrescadde));
        spParam.Add(new SqlParameter("@adressokak", adressokak));
        spParam.Add(new SqlParameter("@adresapartman", adresapartman));
        spParam.Add(new SqlParameter("@adresdaire", adresdaire));
        spParam.Add(new SqlParameter("@adrestarif", adrestarif));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("adresGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool icerikGuncelle(string @icerikbaslik, string @icerikicerik, int id)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@icerikbaslik", icerikbaslik));
        spParam.Add(new SqlParameter("@icerikicerik", icerikicerik));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("icerikGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool ilceGuncelle(string @ilceadi, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@ilceadi", ilceadi));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("ilceGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool kullaniciGuncelle(string @kullaniciadi, string @kullaniciisim, string @kullaniciparola, string @kullanicimail, string @kullanicitelefon, string @kullanicidogum, int @kullanicicinsiyet,int istek, int onay, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kullaniciadi", kullaniciadi));
        spParam.Add(new SqlParameter("@kullaniciisim", kullaniciisim));
        spParam.Add(new SqlParameter("@kullaniciparola", kullaniciparola));
        spParam.Add(new SqlParameter("@kullanicimail", kullanicimail));
        spParam.Add(new SqlParameter("@kullanicitelefon", kullanicitelefon));
        spParam.Add(new SqlParameter("@kullanicidogum", kullanicidogum));
        spParam.Add(new SqlParameter("@kullanicicinsiyet", kullanicicinsiyet));
        spParam.Add(new SqlParameter("@istek", istek));
        spParam.Add(new SqlParameter("@onay", onay));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("kullaniciGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool mahalleGuncelle(string @mahalleadi, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@mahalleadi", mahalleadi));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("mahalleGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool menuGuncelle(string @menuadi, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@menuadi", menuadi));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("menuGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool mesajGuncelle(string @gonderenadi, string @gonderenmail, string @gonderentelefon, string @gonderenmesaj, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@gonderenadi", gonderenadi));
        spParam.Add(new SqlParameter("@gonderenmail", gonderenmail));
        spParam.Add(new SqlParameter("@gonderentelefon", gonderentelefon));
        spParam.Add(new SqlParameter("gonderenmesaj", gonderenmesaj));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("mesajGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool subeGuncelle(string @subeadi, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@subeadi", subeadi));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("subeGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool yiyecekGuncelle(int @menuid, string @yiyecekadi, string @yiyecekicerik, decimal @yiyecekfiyat, string @yiyecekfotograf, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@menuid", menuid));
        spParam.Add(new SqlParameter("@yiyecekadi", yiyecekadi));
        spParam.Add(new SqlParameter("@yiyecekicerik", yiyecekicerik));
        spParam.Add(new SqlParameter("@yiyecekfiyat", yiyecekfiyat));
        spParam.Add(new SqlParameter("@yiyecekfotograf", yiyecekfotograf));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("yiyecekGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool albumGuncelle(string @albumadi, string @albumresim, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@albumadi", albumadi));
        spParam.Add(new SqlParameter("@albumresim", albumresim));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("albumGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool fotografGuncelle(int @albumid, string @fotoadi, string @fotourl, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@albumid", albumid));
        spParam.Add(new SqlParameter("@fotoadi", fotoadi));
        spParam.Add(new SqlParameter("@fotourl", fotourl));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("fotoGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool buyukSliderGuncelle(string @fotourl, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@fotourl", fotourl));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("buyukSliderGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool kucukSliderGuncelle(string @fotourl, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@fotourl", fotourl));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("kucukSliderGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool kuponGuncelle(string @kupon, decimal @tutar, DateTime @kuponbaslangic, DateTime @kuponbitis, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@kupon", kupon));
        spParam.Add(new SqlParameter("@tutar", tutar));
        spParam.Add(new SqlParameter("@kuponbaslangic", kuponbaslangic));
        spParam.Add(new SqlParameter("@kuponbitis", kuponbitis));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("kuponGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
    public static bool durumGuncelle(string @durum, string @sure, int @aktif, int id)
    {
        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@durum", durum));
        spParam.Add(new SqlParameter("@sure", sure));
        spParam.Add(new SqlParameter("@aktif", aktif));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("durumGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }

    public static void adresSil(int id)
    {
        DBW.DeleteData("adresSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void icerikSil(int id)
    {
        DBW.DeleteData("icerikSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void ilceSil(int id)
    {
        DBW.DeleteData("ilceSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void kullaniciSil(int id)
    {
        DBW.DeleteData("kullaniciSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void mahalleSil(int id)
    {
        DBW.DeleteData("mahalleSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void menuSil(int id)
    {
        DBW.DeleteData("menuSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void mesajSil(int id)
    {
        DBW.DeleteData("mesajSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void subeSil(int id)
    {
        DBW.DeleteData("subeSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void yiyecekSil(int id)
    {
        DBW.DeleteData("yiyecekSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void albumSil(int id)
    {
        DBW.DeleteData("albumSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void fotografSil(int id)
    {
        DBW.DeleteData("fotoSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void iletisimSil(int id)
    {
        DBW.DeleteData("iletisimSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void sepetSil(int id)
    {
        DBW.DeleteData("sepetSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void kuponSil(int id)
    {
        DBW.DeleteData("buyukSliderSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void buyukSliderSil(int id)
    {
        DBW.DeleteData("kucukSliderSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void kucukSliderSil(int id)
    {
        DBW.DeleteData("kuponSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
    public static void durumSil(int id)
    {
        DBW.DeleteData("durumSil", new List<SqlParameter> { new SqlParameter("@id", id) });
    }
}

