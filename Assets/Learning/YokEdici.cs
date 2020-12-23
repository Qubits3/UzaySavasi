using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;

    GeriSayimSayaci yokEdiciGeriSayım;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSayım = gameObject.AddComponent<GeriSayimSayaci>();  //Bu scripti kullanan GameObjecte GeriSayımSayacı adlı scripti ekle
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayım.BittiMi)
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);  // Patlama efektini spawnla
            Destroy(gameObject);  // Bu scripti kullanan objeyi yok et
        }
    }

    public void asteroidYokEdici(int sure)
    {
        yokEdiciGeriSayım.ToplamSure = sure;
        yokEdiciGeriSayım.Calistir();  // Geri Sayım Sayacından çalıştır
    }
}
