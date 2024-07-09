using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private float reloadDelay = 2f;

    private string TAG_GROUND = "Ground";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAG_GROUND)
        {
            crashEffect.Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
