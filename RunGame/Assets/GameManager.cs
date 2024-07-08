using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ghost;
public class GameManager : MonoBehaviour
{
    public GameObject VarisNoktasi;
    public static int AnlikKarakterSayisi = 1;

    public List<GameObject> Karakterler;

    public void AdamYonetimi(string islemTuru, int GelenSayi, Transform Pozisyon)
    {
        switch (islemTuru)
        {
            case "Carpma":
                Matematiksel_islemler.Carpma(GelenSayi, Karakterler, Pozisyon);
                break;

            case "Toplama":
                Matematiksel_islemler.Toplama(GelenSayi, Karakterler, Pozisyon);
                break;

            case "Cikartma":
                Matematiksel_islemler.Cikartma(GelenSayi, Karakterler, Pozisyon);
                break;

            case "Bolme":
                Matematiksel_islemler.Bolme(GelenSayi, Karakterler, Pozisyon);
                break;
        }
    }
}
