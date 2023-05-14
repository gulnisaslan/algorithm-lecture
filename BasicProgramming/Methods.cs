class Methods
{
    public static double SeriToplam(params double[] seri){
        double toplam=0;
        foreach (double item in seri)
        {
            toplam+=item;
        }
        return toplam;
    }
    //OverLoading
    static double SatisYap(double miktar){
        return miktar*1.18;
    }
    
    static double SatisYap(double miktar,double indirim){
        return (miktar(1,0-indirim)*1.18);
    }
}