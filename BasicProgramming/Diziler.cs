class Diziler
{
    public static void DizelerExample1(){
      Random r = new Random();
      Console.WriteLine("Dizi Boyutu Giriniz: ");
      int size =  Convert.ToInt32(Console.ReadLine());
      int[] numbers = new int[size];
      for (int i = 0; i < numbers.Length; i++)
      {
        numbers[i]=r.Next(1,10);
      }
      foreach (int  n in numbers)
      {
           Console.WriteLine((n,n)+" "+(n*n));
      }

  }
  public static void CokBoyutLuDizelerExample1(){
        double[,] matrisler = new double[,]
      { 
        {1,2,3},
        {2,3,4}
       };
       double toplam = 0;
       for (int i = 0; i < matrisler.GetLength(0); i++)
       {
         for (int j = 0;j <  matrisler.GetLength(1); j++)
         {
            if (i==j)
            {
               matrisler[i,j]=-1;
            }
            if (matrisler[i,j]%2==0)
            {
                matrisler[i,j]=0;
                Console.WriteLine(matrisler[i,j]);
               
            }
             toplam += matrisler[i,j];
             Console.WriteLine($"{matrisler[i,j],5}");

         }
       }

  }
}