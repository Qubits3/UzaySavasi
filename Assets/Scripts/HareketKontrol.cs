using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    float colliderBoyYarim;
    float colliderEnYarim;

    // Start is called before the first frame update
    void Start()
    {
        //Uzay gemisini hareket ettir
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);

        BoxCollider2D collider = GetComponent<BoxCollider2D>();  // Bu scripti kullanan GameObjectin BoxCollider2D componentına eriş

        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim = collider.size.x / 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Kemerlerinizi Bağlayın!");
    }

    // Update is called once per frame
    void Update()
    {
        //Asteroid mouse imlecini takip etsin
        Vector3 positon = Input.mousePosition;
        positon.z = -Camera.main.transform.position.z;
        positon = Camera.main.ScreenToWorldPoint(positon);

        transform.position = positon;
        
        EkrandaKal();
    }

    /// <summary>
    /// Objenin oyun ekranında kalmasını sağla
    /// </summary>
    void EkrandaKal()
    {
        Vector3 position = transform.position;
        if(position.x - colliderEnYarim < EkranHesaplayicisi.Sol)
        {
            position.x = EkranHesaplayicisi.Sol + colliderEnYarim;
        } else if(position.x + colliderEnYarim > EkranHesaplayicisi.Sag)
        {
            position.x = EkranHesaplayicisi.Sag - colliderEnYarim;
        }
        if(position.y + colliderBoyYarim > EkranHesaplayicisi.Ust)
        {
            position.y = EkranHesaplayicisi.Ust - colliderBoyYarim;
        }else if(position.y - colliderBoyYarim < EkranHesaplayicisi.Alt)
        {
            position.y = EkranHesaplayicisi.Alt + colliderBoyYarim;
        }

        transform.position = position;  // Yeni posizyonu bu scipti kullanan GameObjectin pozisyonuna ata
    }
}
