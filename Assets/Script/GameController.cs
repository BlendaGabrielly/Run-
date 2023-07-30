using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Configuração chão")]
    public float _chaoDestroy;
    public float _chaoTamanho;
    public GameObject chaoPrefab;
    public float _velocidade; 
    
    [Header("Configuração Obstáculo")]
    public float ObstáculoTempo;
    public GameObject prefab;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine("SpawObstaculo");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawObstaculo(){
        yield return new WaitForSeconds(ObstáculoTempo);

        GameObject objtOTemp=Instantiate(prefab);
        StartCoroutine("SpawObstaculo");
    }

}
