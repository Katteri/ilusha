using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGameScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mini-game")
        {
            Destroy(collision.gameObject);
        }
    }
}
