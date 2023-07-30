using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirChao : MonoBehaviour
{
    private GameController _gameContr;

    public bool _chaoinstanciado=false;

    // Start is called before the first frame update
    void Start(){
        _gameContr=FindObjectOfType(typeof(GameController))as GameController;        
    }

    // Update is called once per frame
    void Update()
    {
        if(_chaoinstanciado==false){
            if(transform.position.x<=0){
                _chaoinstanciado=true;
                GameObject ObjetoTemp=Instantiate(_gameContr.chaoPrefab);
                ObjetoTemp.transform.position=new Vector3(transform.position.x+_gameContr._chaoTamanho,transform.position.y,0);

                Debug.Log("CHAO INSTA");
            }
        }
        if(transform.position.x<_gameContr._chaoDestroy){
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate(){
        MoveChão();
    }

    void MoveChão(){
       transform.Translate(Vector2.left * _gameContr._velocidade*Time.deltaTime);
    }
}
