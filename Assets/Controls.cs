using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public  Rigidbody pRigid;
    public float jumpTimer = 100;
    private Animator anim;
    public int maxHealth;
    private int currHealth;
    public int currDamage;
    public int mechPoints;
    public int evoPoints;
    public int researchPoints;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        currDamage = 1;
        maxHealth = 100;
        mechPoints=10;
        evoPoints = 1;
        researchPoints = 0;
        currHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        jumpTimer-=1;
       
        if(jumpTimer<0){
            jumpTimer=0;
        }
        movement();
        if(Input.GetKey("mouse 1")){
            anim.SetFloat("Blend",1.5f,0.1f,Time.deltaTime);
        }
        
    }

    public void movement(){
        if(Input.GetKey("left")){
            pRigid.velocity=Vector3.left*5;
            anim.SetFloat("Blend",0.75f,0.1f,Time.deltaTime);
        
        }
        else if(Input.GetKey("right")){
             pRigid.velocity= Vector3.right*5;
             anim.SetFloat("Blend",1,0.1f,Time.deltaTime);
           
        }
       else if (Input.GetKey("up")){
         pRigid.velocity= Vector3.forward*5;
         anim.SetFloat("Blend",0.25f,0.1f,Time.deltaTime);
       }
       else if(Input.GetKey("down")){
         pRigid.velocity= Vector3.back*5;
         anim.SetFloat("Blend",0.5f,0.1f,Time.deltaTime);
       }
       else if(Input.GetKey("space") && jumpTimer==0){
            pRigid.velocity = Vector3.up * 50;
            jumpTimer=100;
            anim.SetFloat("Blend",0,0.1f,Time.deltaTime);
            Debug.Log("Space pressed");
        }
         
        else{
            pRigid.velocity = Vector3.zero;
            anim.SetFloat("Blend",1.25f,0.1f,Time.deltaTime);
            Input.ResetInputAxes();
        }
    }
}
