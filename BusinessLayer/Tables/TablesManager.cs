using DataAcsess;
using DataAcsess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tables
{
    public class TablesManager
    {
        public static string InsertTables(Personel personel)   //kayıt
        {
            try
            {
                if (personel.Maas == 0)
                {
                    return "Error:Maaşı Hatalı girdiniz veya 0 olamaz";
                }

                TestDBContext context = new TestDBContext();
                //personel.Id = 41;
                context.Personels.Add(personel);
                context.SaveChanges();

                return "Messages:kayıt edildi";

            }
            catch (Exception ex)
            {

                return "Error:Hata ";
            }
        }

        public static string DeleteTables(int id)           //sil
        {
            TestDBContext context = new TestDBContext();
            string result = "Başarısız";
            var deleteQuery = context.Personels.Where(s => s.Id == id).FirstOrDefault();
            if (deleteQuery != null)
            {
                context.Personels.Remove(deleteQuery);
                context.SaveChanges();
                result = "Silme İşlemi Başarıyla yapıldı.";
            }
            return result;
        }

        public static string UpdateTables(int id, Personel personel)           //güncelle
        {
            TestDBContext context = new TestDBContext();
            string result = "Başarısız";
            var updateQuery = context.Personels.Where(s => s.Id == id).FirstOrDefault();
            if (updateQuery != null)
            {
                updateQuery.Adi = personel.Adi;
                updateQuery.Soyadi = personel.Soyadi;
                updateQuery.Maas = personel.Maas;
                context.Personels.Update(updateQuery);
                context.SaveChanges();

                result = "güncellendi";
            }
            return result;


        }
        public static List<Personel> TablesGetAll()
        {
            TestDBContext context = new TestDBContext();

            List<Personel> dataList = context.Personels.ToList();

            return dataList;
        }

        public static Personel TablesGetById(int id)
        {
            TestDBContext context = new TestDBContext();
            var data = context.Personels.Where(s => s.Id == id).FirstOrDefault();
            return data;
        }
    }
}

