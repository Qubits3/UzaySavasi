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
        yokEdiciGeriSayım.ToplamSure = Random.Range(1, 20);
        yokEdiciGeriSayım.Calistir();
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
}
