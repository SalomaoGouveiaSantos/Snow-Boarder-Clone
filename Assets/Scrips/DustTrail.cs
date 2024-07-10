using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    private string TAG_GROUND = "Ground";

    [SerializeField] ParticleSystem dustParticles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == TAG_GROUND)
        {
            dustParticles.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == TAG_GROUND)
        {
            dustParticles.Stop();
        }
    }
}
