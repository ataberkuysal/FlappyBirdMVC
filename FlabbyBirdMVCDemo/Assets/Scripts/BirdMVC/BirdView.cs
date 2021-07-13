using System;
using UnityEngine;

public class BirdView : MonoBehaviour
{

    public event Action ActionJump;
    public event Action ActionScore;
    public event Action ActionOnDeath;
    public static Rigidbody2D vrigidbody2D;
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pipes")
        {
            ActionScore?.Invoke();
            Debug.Log("+1");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        ActionOnDeath?.Invoke();
    }

    private void Awake()
    {
        vrigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            ActionJump?.Invoke();
        }
        transform.eulerAngles = new Vector3(0, 0, vrigidbody2D.velocity.y*5f);
    }
}
