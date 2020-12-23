using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroidList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))  // Farenin sol tuşunu al
        {
            //Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;  // Mouse pozisyonu
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);  // Ekran piksellerini oyun koordinatlarına dönüştürür

            for (int i = 0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));  // Astreroid spawnla
            }
        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click.");
        //}

        if (Input.GetMouseButtonDown(1))
        {
            foreach (GameObject asteroid in asteroidList)
            {
                Destroy(asteroid);  // Sağ tıkta tüm asteroidleri sil
            }

            asteroidList.Clear();  // Tüm listeyi de temizle
        }

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click.");
        //}
    }
}
