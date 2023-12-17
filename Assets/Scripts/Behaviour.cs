using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Behavour : MonoBehaviour
{
    public Counter ct;

    public TextMeshProUGUI jobText;

    void Update()
    {
        jobText.text = Finder();
    }

    string Finder()
    {
        if (ct.A >= 36) return "Proje Yöneticisi";
        if (ct.A >= 18 && ct.A <= 30 && ct.C >= 30) return "CEO veya Genel Müdür";
        if (ct.A >= 18 && ct.A <= 30 && ct.B >= 30) return "Ýþ Geliþtirme Yöneticisi";


        if (ct.B >= 36) return "Veri Analizi Uzmaný";
        if (ct.B >= 18 && ct.B <= 30 && ct.C >= 30) return "Teknoloji ve Bilgi Yönetimi Uzmaný";
        if (ct.B >= 18 && ct.B <= 30 && ct.A >= 30) return "Risk Yönetimi Uzmaný";


        if (ct.C >= 36) return "Ýnovasyon Lideri";
        if (ct.C >= 18 && ct.C <= 30 && ct.A >= 30) return "Ýnsan Kaynaklarý Yöneticisi";
        if (ct.C >= 18 && ct.C <= 30 && ct.B >= 30) return "Ýþ Geliþtirme Yöneticisi";

        return "Bu kiþi için uygun bir iþ yok";
    }
}
