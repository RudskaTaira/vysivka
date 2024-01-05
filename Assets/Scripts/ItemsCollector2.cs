using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsCollector2 : MonoBehaviour
{
    private int bread = 0;

    [SerializeField] private Text breadsText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bread"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bread++;
            breadsText.text = "’Î≥·: " + bread;
        }
    }
}