class LinkedListExample
{
        public static void LinkedListExample1(){
                var sehirler = new LinkedList<string>(); 
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"),"Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next,"Giresun");
            foreach (string item in sehirler)
            {
            Console.WriteLine(item);
            }

            var eleman = sehirler.First;
            while (eleman!= null)
            {
            Console.WriteLine(eleman.Value);
            eleman= eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var gecici =  sehirler.Last;
            while(gecici !=null){
            Console.WriteLine(gecici.Value);
            gecici = gecici.Previous;
            }
    }
}