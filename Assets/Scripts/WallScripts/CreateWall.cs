using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    private float _Time = 0;
    public float coolDown = 3;
    private int objectCounter = 0;
    public GameObject prefab;
    Transform _transform;
    private void Start()
    {
        _transform = prefab.GetComponent<Transform>();
    }
    private void Update()
    {
        _Time -= Time.deltaTime;
        if (_Time <= 0)
        {
            _transform.position = new Vector3(0, Random.Range(-3f, 3f), 0);
            Instantiate(prefab, _transform);
            objectCounter++;
            if (objectCounter >= 5)
            {
                Destroy(GameObject.Find("Wall(Clone)"));
            }
            Debug.Log(_Time);
            _Time = coolDown;
        }
    }
}
