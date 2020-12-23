using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{

    GeriSayimSayaci geriSayimSayaci;

    SiraliYokEdici siraliYokEdici;

    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();  // Bu scripti kullanan GameObjecte GeriSayımSayacı adlı scripti ekle

        siraliYokEdici = Camera.main.GetComponent<SiraliYokEdici>();  // Camera objesindeki SiraliYokEdiciScriptini çağır
        
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.BittiMi)
        {
            siraliYokEdici.hedefiYokEt();
            Destroy(gameObject);  // Bu scripti kullanan GameObjecti yok et
        }
    }
}
