using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameSpawn : MonoBehaviour
{
    private float _delay = 0.2f;
    private Vector3 _position;
    //[SerializeField] private GameObject _box;
    [SerializeField] private GameObject _flower;
    [SerializeField] private PlayerMoney _playerMoney;

    [SerializeField] private GameObject[] food;

    public int _win;
    [SerializeField] public TextMeshPro _score;
    [SerializeField] private BoxGame _boxGame;
    public void Play()
    {
        _position = Camera.main.transform.position + Camera.main.transform.forward * 1.5f;

        _boxGame.StartGame();
        _score.text = "очки: " + _win.ToString();
        InvokeRepeating("Spawn", _delay, 0.5f);
    }

    public void Score()
    {
        _win++;
        _score.text = "очки: " + _win.ToString();
    }
    void Spawn()
    {
        GameObject Flower = Instantiate(_flower, new Vector3(Random.Range(-(_position.x+1.5f), (_position.x+1.5f)), 2f, _position.z), Quaternion.identity);
        Destroy(Flower, 2);
    }

    public void StopPlay()
    {
        _boxGame.EndGame();
        _playerMoney.EarnMoney(_win * 10);
        
        CancelInvoke();

        if (_win >= 2 && _win < 5)
        {
            Instantiate(food[0], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (_win >= 5 && _win < 10)
        {
            Instantiate(food[1], Camera.main.transform.position, Quaternion.identity);
        }
        else if (_win >= 10 && _win < 15)
        {
            Instantiate(food[2], Camera.main.transform.position, Quaternion.identity);
        }
        else if (_win >= 15 && _win < 20)
        {
            Instantiate(food[3], Camera.main.transform.position, Quaternion.identity);
        }
        else if (_win >= 20)
        {
            Instantiate(food[4], Camera.main.transform.position, Quaternion.identity);
        }

        _win = 0;
    }
}
