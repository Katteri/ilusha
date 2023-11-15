using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetScript : MonoBehaviour
{
    public AudioClip _eatingAudio;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == this.gameObject.tag)
        {
            Destroy(collider.gameObject);
            audioSource.PlayOneShot(_eatingAudio);
        }
    }
}
