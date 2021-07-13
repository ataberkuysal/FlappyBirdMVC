using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BirdView _birdView;
    private BirdController _controller;

    private void Start()
    {
        _controller = new BirdController(_birdView);
    }

}
