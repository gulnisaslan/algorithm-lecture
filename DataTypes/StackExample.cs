
class StackExample
{
   private static void ExampleStack(){
      var karakterYigini = new Stack<char>();
      karakterYigini.Push('A');
      Console.WriteLine(karakterYigini.Peek());
      karakterYigini.Push('B');
      Console.WriteLine(karakterYigini.Peek());
      karakterYigini.Push('C');
      Console.WriteLine(karakterYigini.Peek());
  
       Console.WriteLine(karakterYigini.Pop());
       Console.WriteLine(karakterYigini.Pop());
       Console.WriteLine(karakterYigini.Pop());
  }

  private static void ExampleStack2(){
          var karakterYigini = new Stack<char>();
       for(int i = 65; i<=90;i++){
  
       }



      while(karakterYigini.Count>0){
        Console.WriteLine(karakterYigini.Pop());
      }
  }
  private static void ExampleStack3(){
     Console.WriteLine("Lütfen sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());

    var sayiYigini = new Stack<int>();
     while(sayi>0){
       int k = sayi%10;
       sayiYigini.Push(k);
       sayi = sayi/10;
     }
     //int i =0;
     int n = sayiYigini.Count-1;
      foreach(var item in sayiYigini){
        Console.WriteLine($"{item} x {Math.Pow(10,n-1)}={item*Math.Pow(10,n-1)}");
      }

}} 
