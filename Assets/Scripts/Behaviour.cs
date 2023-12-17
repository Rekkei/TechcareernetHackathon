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
        if (ct.A >= 36) return "Proje Y�neticisi";
        if (ct.A >= 18 && ct.A <= 30 && ct.C >= 30) return "CEO veya Genel M�d�r";
        if (ct.A >= 18 && ct.A <= 30 && ct.B >= 30) return "�� Geli�tirme Y�neticisi";


        if (ct.B >= 36) return "Veri Analizi Uzman�";
        if (ct.B >= 18 && ct.B <= 30 && ct.C >= 30) return "Teknoloji ve Bilgi Y�netimi Uzman�";
        if (ct.B >= 18 && ct.B <= 30 && ct.A >= 30) return "Risk Y�netimi Uzman�";


        if (ct.C >= 36) return "�novasyon Lideri";
        if (ct.C >= 18 && ct.C <= 30 && ct.A >= 30) return "�nsan Kaynaklar� Y�neticisi";
        if (ct.C >= 18 && ct.C <= 30 && ct.B >= 30) return "�� Geli�tirme Y�neticisi";

        return "Bu ki�i i�in uygun bir i� yok";
    }
}
