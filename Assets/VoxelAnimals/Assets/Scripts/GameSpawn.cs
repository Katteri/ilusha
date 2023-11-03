using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class GameSpawn : MonoBehaviour
{
    private float _delay = 0.2f;
    [SerializeField] private GameObject _box;
    [SerializeField] private GameObject _flower;
    public void Play()
    {
        var position = Camera.main.transform.position + Camera.main.transform.forward * 1;
        var item = Instantiate(_box, position, Quaternion.identity);
        item.transform.Rotate(-90.0f, -90.0f, -90.0f, Space.Self);
        InvokeRepeating("Spawn", _delay, _delay);        
    }

    void Spawn()
    {
        Instantiate(_flower, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
    }

    public void StopPlay()
    {
        CancelInvoke();
        Destroy(GameObject.Find("Box(clone)"));

    }
}
