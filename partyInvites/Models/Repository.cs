namespace PartyInvites.Models;

public static class Repository
{
    public static List<ZiyaretciCevabi> cevaplar = new();
    public static IEnumerable<ZiyaretciCevabi>Cevaplar=>cevaplar;
    public static void CevapEkle(ZiyaretciCevabi cevap){
        Cevaplar.Add(cevap);
    }
    
}
