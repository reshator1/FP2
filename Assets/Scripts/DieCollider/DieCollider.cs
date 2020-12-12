using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DieCollider : MonoBehaviour
{
    public AudioClip deathSound;
    AudioSource _audio;
    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _audio.PlayOneShot(deathSound);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
