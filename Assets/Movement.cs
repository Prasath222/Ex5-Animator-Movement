using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public float inputX;
    public float inputY;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputX = Input.GetAxis("Vertical");
        animator.SetFloat("inputX",inputX);
        animator.SetFloat("inputY",inputY);

    } 
}