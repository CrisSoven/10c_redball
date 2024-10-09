using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public AudioSource audioMoneda;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            audioMoneda.PlayOneShot(audioMoneda.clip);
            Destroy(this.gameObject);
        }
    }

}
