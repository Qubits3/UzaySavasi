using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{
    /// <summary>
    /// Geminin maksimum hız limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Uzay gemisinin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// Maksimum hız değerini döner
    /// </summary>
    public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }

    /// <summary>
    /// Geminin rengini döner
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }

    /// <summary>
    /// Maksimum hızı yazın
    /// </summary>
    /// <param name="maksimumHiz"></param>
    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }

    /// <summary>
    /// Maksimum hız ve rengi yazın
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }

    /// <summary>
    /// Uzay Gemisi hızlandrma süper gücü
    /// </summary>
    public void hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }
    
    /// <summary>
    /// Uzay Gemisi yavaşlatma
    /// </summary>
    public void yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }
}
