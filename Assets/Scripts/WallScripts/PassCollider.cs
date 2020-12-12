using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PassCollider : MonoBehaviour
{
    public AudioClip pointSound;
    public Text score;
    AudioSource _audio;
    
    
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _audio.PlayOneShot(pointSound);
            score.text = "Score: " + 1;
        }
    }
}
