using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public Animator anim;
    //private float inputH;
    //private float inputV;
    public Rigidbody rd;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("1")){
            anim.Play("WAIT01" ,-1, 0f);
        }
        if(Input.GetKeyDown("2")){
            anim.Play("WAIT02" ,-1, 0f);
        }
        if(Input.GetKeyDown("3")){
            anim.Play("WAIT03" ,-1, 0f);
        }
        if(Input.GetKeyDown("4")){
            anim.Play("WAIT04" ,-1, 0f);
        }
        /*
        if(Input.GetMouseButtonDown(0)){
            int r = Random.Range(0,2);
            if(r == 0){
                anim.Play("DAMAGED01" ,-1, 0f);
            }else{
                anim.Play("DAMAGED00" ,-1, 0f);
            }
        }

        //inputH = Input.GetAxis("Horizontal");
        //inputV = Input.GetAxis("Vertical");
        //anim.SetFloat("inputH", inputH);
        //anim.SetFloat("inputV", inputV);
        
        float moveX = inputH* 10f * Time.deltaTime;
        float moveZ = inputV* 30f * Time.deltaTime;
        if(moveZ <= 0f){
            moveX = 0f;
        }
        rd.velocity =new Vector3(moveX, 0f,moveZ);
        */
    }
    public void ClickedDamageBody(){
        int r = Random.Range(0,10);
        if(r == 0){
            anim.Play("DAMAGED01" ,-1, 0f);
        }else{
            anim.Play("DAMAGED00" ,-1, 0f);
        }
    }
    public void ClickedDamageHead(){
        int r = Random.Range(0,2);
        if(r == 0){
            anim.Play("DAMAGED01" ,-1, 0f);
        }else{
            anim.Play("DAMAGED00" ,-1, 0f);
        }
    }
}
