using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomGroundController : MonoBehaviour
{
    
    [SerializeField]
    public float speed = 3f;
    
    void Update()
    {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }
}
