using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 _offset;
    private Vector3 _currentVelocity = Vector3.zero;
    private Camera _camera;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 0.3f;

   

 

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);


    }
}