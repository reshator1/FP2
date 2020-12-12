using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Transform _transform;
    public float speedX = 5;
 
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.position = new Vector3(_transform.position.x - (speedX * Time.deltaTime), _transform.position.y, _transform.position.z);
    }
}
