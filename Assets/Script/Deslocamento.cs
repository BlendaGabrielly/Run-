using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deslocamento : MonoBehaviour
{
    private Renderer objtRender;
    private Material objtMaterial;
    public float offset;
    public float offsetDeslocamento;
    public float offsetVelocidade;

    public string sortingLayer;
    public int order;

    // Start is called before the first frame update
    void Start()
    {
        objtRender=GetComponent<MeshRenderer>();

        objtRender.sortingLayerName=sortingLayer;
        objtRender.sortingOrder=order;

        objtMaterial=objtRender.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += offsetDeslocamento;
        objtMaterial.SetTextureOffset("_MainTex",new Vector2(offset*offsetVelocidade,0));
        
    }
}
