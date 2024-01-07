using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool jDown;
    private bool IsJumping;

    
    Vector3 moveVec;
    Animator anim;
    Rigidbody rigid;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        IsJumping = false;

        

    }

   
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
       

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        
        transform.position += moveVec * speed * Time.deltaTime;
        
     
        Jump();
        Turn();
        Sprint();
        Attack();

         
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))


        {
                
           anim.SetTrigger("isJump");


                
        }
        
    }
    void Turn()
    {
        transform.LookAt(transform.position + moveVec);

    }
   
    void Sprint()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5f;
            anim.speed = 1f;
        }
        else{
            speed = 2f;
           /* anim.SetTrigger("Re"); */
        }
        
        
 
    }
    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            anim.SetTrigger("isAttack");
        }
    }
 
 
    
}