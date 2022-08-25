using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int pineCount = 0;
    [SerializeField] private Text PineappleText;
    [SerializeField] private AudioSource ItemSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pineapple"))
        {
            Destroy(collision.gameObject);
            pineCount++;
            PineappleText.text = "Pineapple: " + pineCount;
            ItemSound.Play();
        }
    }
}
