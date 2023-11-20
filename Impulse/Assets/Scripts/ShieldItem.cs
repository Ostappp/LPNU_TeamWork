using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItem : MonoBehaviour
{
    public AudioClip ActiveShieldSound;
    public AudioClip DestroyShieldSound;
    AudioSource SoundSource;
    Collider _objCollider;
    // Start is called before the first frame update
    void Start()
    {
        _objCollider = GetComponent<Collider>();
        SoundSource = GetComponent<AudioSource>();
        if(ActiveShieldSound != null)
        {
            SoundSource.clip = ActiveShieldSound;
            SoundSource.loop = false;
            SoundSource.Play();
        }
        
    }

    private void DestroyShield()
    {
        if(DestroyShieldSound != null)
        {
            SoundSource.clip = DestroyShieldSound;
            SoundSource.loop = false;
            SoundSource.Play();
        }
        
        Destroy(gameObject,0.2f);
        Debug.Log("Shield destroyed");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_objCollider != null && other.tag == "Obstacle")
        {
            other.gameObject.SetActive(false);
            DestroyShield();
        }
    }
}
