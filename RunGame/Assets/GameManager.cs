using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject VarisNoktasi;
    public int AnlikKarakterSayisi = 1;

    public List<GameObject> Karakterler;

    public void AdamYonetimi(string Veri, Transform Pozisyon)
    {
        switch (Veri)
        {
            case "X2":
                int sayi = 0;
                foreach (var item in Karakterler)
                {
                    if (sayi < AnlikKarakterSayisi)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = Pozisyon.position;
                            item.SetActive(true);
                            sayi++;
                        }
                    }
                    else
                    {
                        sayi = 0;
                        break;
                    }
                }
                AnlikKarakterSayisi *= 2;
                break;

            case "+3":
                int sayi2 = 0;
                foreach (var item in Karakterler)
                {
                    if (sayi2 < 3)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = Pozisyon.position;
                            item.SetActive(true);
                            sayi2++;
                        }
                    }
                    else
                    {
                        sayi2 = 0;
                        break;
                    }
                }
                AnlikKarakterSayisi += 3;
                break;

            case "-4":

                if (AnlikKarakterSayisi < 4)
                {
                    foreach (var item in Karakterler)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    AnlikKarakterSayisi = 1;
                }
                else
                {
                    int sayi3 = 0;
                    foreach (var item in Karakterler)
                    {
                        if (sayi3 != 3)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                sayi3++;
                            }
                        }
                        else
                        {
                            sayi3 = 0;
                            break;
                        }
                    }
                    AnlikKarakterSayisi -= 4;
                }
                break;

            case "/2":

                if (AnlikKarakterSayisi <= 2)
                {
                    foreach (var item in Karakterler)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    AnlikKarakterSayisi = 1;
                }
                else
                {
                    int bolen = AnlikKarakterSayisi / 2;
                    int sayi3 = 0;
                    foreach (var item in Karakterler)
                    {
                        if (sayi3 != bolen)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                sayi3++;
                            }
                        }
                        else
                        {
                            sayi3 = 0;
                            break;
                        }
                    }
                    if (AnlikKarakterSayisi % 2 == 0)
                    {
                        AnlikKarakterSayisi /= 2;
                    }
                    else
                    {
                        AnlikKarakterSayisi /= 2;
                        AnlikKarakterSayisi++;
                    }
                }
                break;
        }
    }
}
