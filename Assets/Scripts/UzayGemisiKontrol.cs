using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{
    const float hareketGucu = 5;

    bool topluyor = false;
    GameObject hedef;

    Rigidbody2D myRidigbody2D;

    Toplayici toplayici;

    // Start is called before the first frame update
    void Start()
    {
        myRidigbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplayici>();
    }

    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTopla();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject == hedef)
        {
            toplayici.yildizYokEt(hedef);
            myRidigbody2D.velocity = Vector2.zero;

            GitVeTopla();
        }
    }

    void GitVeTopla()
    {
        hedef = toplayici.hedefYildiz;
        if(hedef != null)
        {
            Vector2 gidilecekyer = new Vector2(hedef.transform.position.x - transform.position.x,
                                                hedef.transform.position.y - transform.position.y);  // Gidilecek yeri hesapla
            gidilecekyer.Normalize();

            myRidigbody2D.AddForce(gidilecekyer * hareketGucu, ForceMode2D.Impulse); // Gidilecek yere doğru kuvvet uygula
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal");  // Klavyeden gelen input
        //float dikeyInput = Input.GetAxis("Vertical");  // Klavyeden gelen input

        //if (yatayInput != 0)
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}

        //if (dikeyInput != 0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}

        //transform.position = position;  // Yeni posizyonu bu scipti kullanan GameObjectin pozisyonuna ata
    }
}
