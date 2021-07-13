
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Animations;

public class BirdController
{
    private BirdView _birdView;
    private BirdModel _birdModel;
    
    private Rigidbody2D _rigidbody2D;
    private GameObject _gameObject;
    private GameManagement _gameManagement;
    private GameObject gameoversc = Resources
        .FindObjectsOfTypeAll<GameObject>()
        .FirstOrDefault(g=>g.CompareTag("gameoverscreen"));
    
    public BirdController(BirdView birdView)
    {
        _birdModel = new BirdModel();
        _birdView = birdView;

        _rigidbody2D = _birdView.GetComponent<Rigidbody2D>();
        _gameObject = _birdView.gameObject;
        _birdView.ActionJump += Jump;
        _birdView.ActionScore += Score;
        _birdView.ActionOnDeath += OnGameOver;
    }
    //Bird jumping and rotation
    void Jump()
    {
        _rigidbody2D.velocity = Vector2.up * _birdModel.jumpMultiplier;
        Vector3 restartRot = new Vector3(0,0,65f);
        restartRot.z = _gameObject.transform.eulerAngles.z;
    }
    void Score()
    {
        GameManagement.score++;
    }
    public static bool reloadIsTrue;
    private void OnGameOver()
    {
        Debug.Log("GAME OVER");
        gameoversc.SetActive(true);
        reloadIsTrue = true;
    }
}
