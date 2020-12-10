using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{

    GeriSayimSayaci geriSayimSayaci;
    float baslangicZamani;

    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();  //Bu scripti kullanan GameObjecte GeriSayımSayacı adlı scripti ekle
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();

        baslangicZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.BittiMi)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log("Gecen sure: " + gecenSure);

            baslangicZamani = Time.time;
            geriSayimSayaci.Calistir();
        }
    }
}
