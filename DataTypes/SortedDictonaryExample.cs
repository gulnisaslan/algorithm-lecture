using System.Collections.Generic;
public class SortedDictonaryExample
{
    public static void SortedDictonaryExample1(){
       var kitapIndeks = new SortedDictionary<string,List<int>>(){
            {"HTML",new List<int>{8,10,12}},
            {"CSS",new List<int>{70,80,90}},
            {"JQuery",new List<int>{14,15,19}},
            {"SQL",new List<int>{140,150,180}}
       };
       kitapIndeks.Add("FTP",new List<int>{3,5,6});
        kitapIndeks.Add("ASP.NET",new List<int>{60,90});
        foreach (var item in kitapIndeks)
        {
            Console.WriteLine(item.Key);
            item.Value.ForEach(s=>Console.WriteLine("/t>"+s));
        }
    }
      public static void SortedDictonaryExample2(){
        
    }
}