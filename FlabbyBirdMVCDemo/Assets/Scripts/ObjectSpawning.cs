
using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class ObjectSpawning : MonoBehaviour
{
    [SerializeField] private  GameObject pipes;
    [SerializeField] private  GameObject bottom;
    
    
    [SerializeField]
    private  Vector2 bottomRestartPos = new Vector2(-9.56f, -5f);


    void LoadBottom()
    {
        Vector2 posBottom = bottom.transform.position;
        if (posBottom.x <= bottomRestartPos.x)
        {
            bottom.transform.position = new Vector3(0f,bottomRestartPos.y);
        }
    }
    
    
    void LoadPipes()
    {
        //Random rotation  -> see ObjectSpawning Inverse direction so that pipes are forced to follow world direction
        Quaternion rot= Quaternion.Euler(0, 0, Random.Range(-5f,5f));
        Vector3 pos = new Vector3(10f, Random.Range(-3.5f, 3.5f), 0);

        Instantiate(pipes, pos, rot);


    }


    void Start()
    {
        InvokeRepeating("LoadPipes",0f,2f);
    }

    
    void Update()
    {
        LoadBottom();
    }
}
