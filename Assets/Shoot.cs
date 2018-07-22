using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    #region Variables
    //delay between shots
    public float timer = 5f;
    public GameObject projectile;
    public float projectileSpeed = 5f;

    //keeps track of the time
    [SerializeField]
    private float localTimer = 0f;
    #endregion 

    void Update()
    {
        localTimer += Time.deltaTime;
        if (localTimer >= timer)
        {
            Fire();
        }
    }

    void Fire()
    {
        //instantiate beam at the position of fire point
        GameObject beam = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
        beam.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, projectileSpeed);

        //play sound effect

        //reset localtimer
        localTimer = 0f;
    }
}
