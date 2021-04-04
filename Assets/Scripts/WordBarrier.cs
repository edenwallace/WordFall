using UnityEngine;
using System; 
using UnityEngine.SceneManagement;

public class WordBarrier : MonoBehaviour 
{
    
     void OnTriggerEnter2D(Collider2D other) 
     {
         SceneManager.LoadScene("Exit");

    }
}
