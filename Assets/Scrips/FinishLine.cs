using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private string TAG_PLAYER = "Player";

    [SerializeField] private ParticleSystem finishEffect;
    [SerializeField] private float reloadDelay = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAG_PLAYER)
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadDelay);
        }
          
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
