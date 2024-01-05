using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ItemsCollector : MonoBehaviour
{
    private int coins = 0;
    public Text collectedItemsText;

    [SerializeField] private Text coinsText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Копійочки: " + coins;
        }
    }



}
