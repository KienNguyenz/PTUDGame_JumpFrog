﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
           
        }
    }

    private void Die()
    {
        deathSoundEffect.Play();

        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        PlayerPrefs.SetInt("Score", 0);
    
        //Gọi hàm RestartLevel sau 2 giây
        Invoke("RestartLevel", 2f);
    }
   

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
