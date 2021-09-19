using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float timer=2.0f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * Random.Range(1.0f, 10.0f);
       
    }
    
    void Update()
    {
        if (timer < 0)
        {
            Material material = Renderer.material;
            material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),1.0f);
            timer = Random.Range(2.0f, 5.0f);
        }
       
        transform.Rotate(Random.Range( 5.0f, 20.0f) * Time.deltaTime, 0.0f, Random.Range(5.0f, 20.0f) * Time.deltaTime);
        timer -= Time.deltaTime;

    }

}
