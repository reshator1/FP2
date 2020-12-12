using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 7.5f;
    public int _rotation = 30;
    public AudioClip JumpSound;
    Rigidbody2D _rigidbody;
    Transform _transform;
    Animator _animator;
    AudioSource _audio;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }

    public void Jump()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        _animator.Play("PlayerJump");
        _audio.PlayOneShot(JumpSound);
    }

    void Update()
    {
        Flip();
    }

    void Flip()
    {
        if (_rigidbody.velocity.y < 0)
        {
            _transform.rotation = Quaternion.Euler(new Vector3(_transform.rotation.x, _transform.rotation.y, -_rotation));
            _animator.Play("PlayerIdle");
        }
        else
        {
            _transform.rotation = Quaternion.Euler(new Vector3(_transform.rotation.x, _transform.rotation.y, _rotation));
        }
    }
}
