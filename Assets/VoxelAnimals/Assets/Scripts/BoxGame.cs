using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGame : MonoBehaviour
{
    public int _win;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mini-game")
        {
            _win++;
            Destroy(collision.gameObject);
            Debug.Log(_win.ToString());
        }
    }
}
