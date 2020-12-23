using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80, 100));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(80, 100), "Gri");

        gemi1.yavaslatici();
        gemi2.yavaslatici();

        if(gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi1");
        }else if(gemi2.MaksimumHiz > gemi1.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi2");
        }
        else
        {
            Debug.Log("Berabere");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
