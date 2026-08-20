using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
        public GameObject gameOverUI;

        private void Start()
        {
            gameOverUI.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("untagged"))
            {
                gameOverUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    
}