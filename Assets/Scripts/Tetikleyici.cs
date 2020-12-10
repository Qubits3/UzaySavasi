using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetikleyici : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // Bu sınıfı yapmamızın nedeni, Unity' nin oyun objelerine eklenmemiş scriptleri dikkate almaması
        EkranHesaplayicisi.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
