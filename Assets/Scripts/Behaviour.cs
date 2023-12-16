using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavour : MonoBehaviour
{
    private Counter ct;
    private string job;
    void Start()
    {
        job=Finder();
    }

    
    void Update()
    {

        Debug.Log("Bu kişi için en uygun meslek" + job);
    }

    private string Finder()
    {
        if (ct.liderlik >= 6) return "Proje Yöneticisi";
        if (ct.liderlik >= 3 && ct.liderlik <= 5 && ct.yaraticilik >= 5) return "CEO veya Genel Müdür";
        if (ct.liderlik >= 3 && ct.liderlik <= 5 && ct.analitikdusunce >= 5) return "İş Geliştirme Yöneticisi";


        if (ct.analitikdusunce >= 6) return "Veri Analizi Uzmanı";
        if (ct.analitikdusunce >= 3 && ct.analitikdusunce <= 5 && ct.yaraticilik >= 5) return "Teknoloji ve Bilgi Yönetimi Uzmanı";
        if (ct.analitikdusunce >= 3 && ct.analitikdusunce <= 5 && ct.liderlik >= 5) return "Risk Yönetimi Uzmanı";


        if (ct.yaraticilik >= 6) return "İnovasyon Lideri";
        if (ct.yaraticilik >= 3 && ct.yaraticilik <= 5 && ct.liderlik >= 5) return "İnsan Kaynakları Yöneticisi";
        if (ct.yaraticilik >= 3 && ct.yaraticilik <= 5 && ct.analitikdusunce >= 5) return "İş Geliştirme Yöneticisi";

        return "Bu kişi için uygun bir iş yok";
    }
}
