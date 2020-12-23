using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject uzayGemisiPrefab;

    GameObject uzayGemisi;

    // Start is called before the first frame update
    void Start()
    {
        uzayGemisi = Instantiate(uzayGemisiPrefab);
        uzayGemisi.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
