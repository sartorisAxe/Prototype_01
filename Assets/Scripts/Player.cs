using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    #region Variables
    public Animator animator;

    #endregion

    #region UnityCommon
    // Use this for initialization
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Fire!");            
            AttackAnimation();
        }
    }

    void AttackAnimation()
    {
        //set animation of the attack
        animator.SetTrigger("Attack");
    }
    #endregion

}
