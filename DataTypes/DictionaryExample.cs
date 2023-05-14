using System.Collections.Generic;
class DictionaryExample
{
    public static void Dictionaries2(){
        var personel = new Dictionary<int,Personel>(){
            {110,new Personel("Mehmet","Sonsuz",5000)},
            {112,new Personel("Merve","karsız",5000)}
        };
        personel.Add(120,new Personel("Mercan","Asan",40000));
        foreach (var item in personel)
        {
            Console.WriteLine(item);
        }
    }




    public static void DictionaryExample1(){
        var telefonKodlari = new Dictionary<int,string>(){
            {332,"Osmaniye"},
            {424,"Elazığ"},
            {466,"Artvin"}
        };
        telefonKodlari.Add(322,"Adana");
        telefonKodlari.Add(212,"İstanbul");
        telefonKodlari.Add(216,"İstanbul");
         //ContainsKey
       if(!telefonKodlari.ContainsKey(312)){
            Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
            telefonKodlari.Add(312,"Ankara");
            Console.WriteLine("Yeni kod eklendi.");
       }
       //ContainsValue
       if (!telefonKodlari.ContainsValue("Malatya")){
         Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
            telefonKodlari.Add(422,"Ankara");
            Console.WriteLine("Yeni kod eklendi.");
       }
       telefonKodlari.Remove(322);
      
        foreach (var item in telefonKodlari)
        {
            Console.WriteLine(item);
        }
    }
}
public class Personel{
    public Personel(string adi, string soyad, decimal maas)
    {
        Adi = adi;
        Soyad = soyad;
        this.maas = maas;
    }

    public int SicilNo { get; set; }
    public string Adi { get; set; }
    public string Soyad { get; set; }
    public decimal maas { get; set; }
}