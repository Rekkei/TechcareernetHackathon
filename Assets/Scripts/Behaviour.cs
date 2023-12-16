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

        Debug.Log("Bu ki�i i�in en uygun meslek" + job);
    }

    private string Finder()
    {
        if (ct.liderlik >= 6) return "Proje Y�neticisi";
        if (ct.liderlik >= 3 && ct.liderlik <= 5 && ct.yaraticilik >= 5) return "CEO veya Genel M�d�r";
        if (ct.liderlik >= 3 && ct.liderlik <= 5 && ct.analitikdusunce >= 5) return "�� Geli�tirme Y�neticisi";


        if (ct.analitikdusunce >= 6) return "Veri Analizi Uzman�";
        if (ct.analitikdusunce >= 3 && ct.analitikdusunce <= 5 && ct.yaraticilik >= 5) return "Teknoloji ve Bilgi Y�netimi Uzman�";
        if (ct.analitikdusunce >= 3 && ct.analitikdusunce <= 5 && ct.liderlik >= 5) return "Risk Y�netimi Uzman�";


        if (ct.yaraticilik >= 6) return "�novasyon Lideri";
        if (ct.yaraticilik >= 3 && ct.yaraticilik <= 5 && ct.liderlik >= 5) return "�nsan Kaynaklar� Y�neticisi";
        if (ct.yaraticilik >= 3 && ct.yaraticilik <= 5 && ct.analitikdusunce >= 5) return "�� Geli�tirme Y�neticisi";

        return "Bu ki�i i�in uygun bir i� yok";
    }
}
