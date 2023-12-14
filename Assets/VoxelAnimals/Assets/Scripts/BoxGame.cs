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
        if (collider.gameObject.CompareTag("mini-game"))
        {
            Debug.Log("hgg");
            gameSpawn.Score();
            Destroy(collider.gameObject);
        }
    }

    public void StartGame()
    {
        //var _position = Camera.main.transform.position + Camera.main.transform.forward * 1.5f;
        var _position = Camera.main.transform.position + Camera.main.transform.forward;
        transform.parent.position = _position;
        this.gameObject.transform.parent.gameObject.SetActive(true);
    }

    public void EndGame()
    {
        this.gameObject.transform.parent.gameObject.SetActive(false);
    }
}
