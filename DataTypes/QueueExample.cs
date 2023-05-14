class QueueExample
{
      public static void KuyrukTemelleri(){
      var karakterKuyrugu = new Queue<char>();
    karakterKuyrugu.Enqueue('a');
    karakterKuyrugu.Enqueue('e');
    karakterKuyrugu.Enqueue('ı');
    karakterKuyrugu.Enqueue('i');
    System.Console.WriteLine(karakterKuyrugu.Count);


    var queueToArray = karakterKuyrugu.ToArray();
    System.Console.WriteLine($"Kuyruğun başındaki eleman : {karakterKuyrugu.Peek()}");
    System.Console.WriteLine(karakterKuyrugu.Dequeue());
    
  }
  public static void Queue(){
       var sesliHarfler = new List<char>(){
      'a','e','i','ı','u','ü','o','ö'
    };
    ConsoleKeyInfo secim;

     var kuyruk = new Queue<char>();
     foreach (char k in sesliHarfler)
     {
       Console.WriteLine();
       Console.Write($"{k,-5} kuyruğa eklesin mi?");
       secim=Console.ReadKey();
       Console.WriteLine();
       if(secim.Key==ConsoleKey.E){
           kuyruk.Enqueue(k);
           Console.WriteLine($"\n{k,-5} kuyruğa eklendi");
           Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
           Console.WriteLine();
       }
     }
     Console.WriteLine();
     Console.WriteLine("Kuyruktan elemanların kaldırılması için ESC tuşuna basın.");
     secim = Console.ReadKey();
     if (secim.Key == ConsoleKey.Escape)
     {
      Console.WriteLine();
     while (kuyruk.Count>0)
     {
       Console.WriteLine();
       Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkarılıyor");
       Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkarılıyor");
                 Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
     }
     Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı.");
     }
     Console.WriteLine("Program Bitti");
      Console.ReadKey();
  }
 
}