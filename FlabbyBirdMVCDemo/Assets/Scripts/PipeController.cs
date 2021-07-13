
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float pipeSpeed =3f;
    
    private float threshold;


    void Start()
    {
        //Halfwidth of main camera on the left + size of object
        threshold = -Camera.main.orthographicSize * Camera.main.aspect-transform.localScale.x;
    }


    void Update()
    {
        //Inverse direction so that pipes are forced to follow world direction
        Vector2 relative = transform.InverseTransformDirection(Vector2.left);
        transform.Translate(relative * (pipeSpeed * Time.deltaTime));
        
        
        //Destroy Pipes beyond threshold
        if (gameObject.transform.position.x < threshold)
        {
            Destroy(gameObject);
        }
    }
}
