using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;
    
    public void Start()
    {
        player = GameObject.Find("Player");
        _offset = transform.position - player.transform.position;
    }
    
    public void LateUpdate()
    {
        Relocate();
    }

    private void Relocate()
    {
        transform.position = player.transform.position + _offset;
    }
}
