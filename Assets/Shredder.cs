using System.Collections;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "Player")
        {
            Destroy(col.gameObject);
        }
        
    }
}
