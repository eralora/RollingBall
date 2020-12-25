using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    float forwForce = 0;

    public bool isActive = false;
    public ParticleSystem particle = null;

    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "cube")
        {
            if (!isActive)
            {
                StartCoroutine(SlowSpeed());
            }

            isActive = true;

            //movement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
        }
    }

    IEnumerator SlowSpeed()
    {
        forwForce = movement.forwardForce;

        movement.forwardForce = forwForce / 10;

        ParticleSystem.EmissionModule em = particle.emission; 
        em.enabled = true; // activate particle

        Debug.Log("Slow speed");

        yield return new WaitForSeconds(3);

        em.enabled = false;

        movement.forwardForce = forwForce;
        Debug.Log("Fast speed");

        isActive = false;
    }
}
