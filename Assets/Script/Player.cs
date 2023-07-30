using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=0f;
    public bool isGround=true;
    private Animator anim;
    private Rigidbody2D rig;

    public LayerMask layer;
    public Transform check;
    public string isGroundbool="chao";

    public float jumpForce=650f;

    // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();

        MovimentaPlayer();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Jump();
        }
    }
    private void MovimentaPlayer(){
        transform.Translate(new Vector3(speed,0,0));
    }

    private void FixedUpdate(){
        transform.Translate(new Vector3(speed,0,0));
        if(Physics2D.OverlapCircle(check.transform.position,0.2f,layer)){
            anim.SetBool(isGroundbool,true);
            isGround=true;
        }else{
         anim.SetBool(isGroundbool,false);
         isGround=false;
        }
    }
    public void Jump(){
        if(isGround){
            rig.velocity=Vector2.zero;
            rig.AddForce(new Vector2(0,jumpForce));
        }
    }
}
