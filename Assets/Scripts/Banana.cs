using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banana : MonoBehaviour
{
    private int bananas = 0;



    [SerializeField] private Text ScoreText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bananas++;

            PlayerPrefs.SetInt("Score", bananas);
            ScoreText.text = "Score: " + bananas;
        }
    }
    void Start()
    {
        // Lấy điểm từ PlayerPrefs
        bananas = PlayerPrefs.GetInt("Score", 0);
        ScoreText.text = "Score: " + bananas;
    }
}
    
