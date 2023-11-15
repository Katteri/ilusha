using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxGame : MonoBehaviour
{
    
    [SerializeField] private GameSpawn gameSpawn;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "mini-game")
        {
            gameSpawn.Score();
            Destroy(collider.gameObject);
        }
    }

    public void StartGame()
    {
        var _position = Camera.main.transform.position + Camera.main.transform.forward * 0.2f;
        this.transform.position = _position;
        this.gameObject.SetActive(true);
    }

    public void EndGame()
    {
        this.gameObject.SetActive(false);
    }
}
