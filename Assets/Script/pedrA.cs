using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedrA : MonoBehaviour
{
    private Rigidbody2D obst;

    public GameController game;
    public CameraShapper cameraShapper;
    // Start is called before the first frame update
    void Start()
    {
        obst=GetComponent<Rigidbody2D>();
       // obst.velocity=new Vector2(-5f,0);

       game=FindObjectOfType(typeof(GameController))as GameController;
       cameraShapper=FindObjectOfType(typeof(CameraShapper))as CameraShapper;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        Move();
    }
    void Move(){
     transform.Translate(Vector2.left*5f*Time.smoothDeltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision){
       if(collision.tag=="Player"){
        cameraShapper.ShakeIt();
        Debug.Log("Bateu");
       }
    }
    private void OnBecameInvisible(){
        Destroy(this.gameObject);
        Debug.Log("pedra foi de arrasta pra cima");
    }
}
