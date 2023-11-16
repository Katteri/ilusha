using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

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
        _position = Camera.main.transform.position + Camera.main.transform.forward * 0.2f;
        //var item = Instantiate(_box, _position, Quaternion.identity);
        //this.gameObject.SetActive(true);
        //this.transform.Rotate(-90.0f, -90.0f, -90.0f, Space.Self);
        //this.transform.position = _position;
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
        Instantiate(_flower, new Vector3(Random.Range(-(_position.x+0.25f), (_position.x+0.25f)), 0.5f, _position.z), Quaternion.identity);
    }

    public void StopPlay()
    {
        _boxGame.EndGame();
        _playerMoney.EarnMoney(_win * 10);
        _win = 0;
        CancelInvoke();
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("mini-game");
        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }

        if (_win >= 2 && _win < 5)
        {
            Instantiate(food[0], _position, Quaternion.identity);
        }
        else if (_win >= 5 && _win < 10)
        {
            Instantiate(food[1], _position, Quaternion.identity);
        }
        else if (_win >= 10 && _win < 15)
        {
            Instantiate(food[2], _position, Quaternion.identity);
        }
        else if (_win >= 15 && _win < 20)
        {
            Instantiate(food[3], _position, Quaternion.identity);
        }
        else if (_win >= 20)
        {
            Instantiate(food[4], _position, Quaternion.identity);
        }
    }
}
