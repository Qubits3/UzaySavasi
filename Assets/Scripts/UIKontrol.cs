using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject oyunAdiText = default;

    [SerializeField]
    GameObject oyunBittiText = default;

    [SerializeField]
    Text puanText = default;

    [SerializeField]
    GameObject oynaButon = default;

    int puan;

    // Start is called before the first frame update
    void Start()
    {
        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);
    }

    public void oyunBasladi()
    {
        oyunAdiText.gameObject.SetActive(false);
        oynaButon.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBittiText.gameObject.SetActive(false);

        puaniGuncelle();
    }

    public void oyunBitti()
    {
        oyunBittiText.gameObject.SetActive(true);
        oynaButon.gameObject.SetActive(true);
        puan = 0;
    }

    void puaniGuncelle()
    {
        puanText.text = "PUAN: " + puan;
    }

    public void AsteroidYokOldu(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case '1':
                puan += 5;
                puaniGuncelle();
                break;
            case '2':
                puan += 10;
                puaniGuncelle();
                break;
            case '3':
                puan += 15;
                puaniGuncelle();
                break;
            default:
                break;
        }
    }
}
