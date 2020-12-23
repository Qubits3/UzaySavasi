using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    GeriSayimSayaci geriSayimSayaci;

    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();  //Bu scripti kullanan GameObjecte GeriSayımSayacı adlı scripti ekle
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.BittiMi)
        {
            //Spawn game object
            spawnAsteroid();
            geriSayimSayaci.Calistir();
        }
    }

    void spawnAsteroid()
    {
        Instantiate(asteroidPrefab);  // Oyun sırasında GameObject oluşturur
    }
}
