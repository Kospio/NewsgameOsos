using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour
{
    public float scaleSpeed;

    public GameObject bear;

    public ChangeScene changeScene; 

    // Start is called before the first frame update
    void Start()
    {
        scaleSpeed /= 100; //Lo divido entre 100 para no tener que poner putodecimales en el inspector de Unity, que es el que controla la velocidad de reduccion
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Oso")
        {
            changeScene.SceneChanger(); 
        }
    }

    void FixedUpdate()
    {
        Vector3 scale = new Vector3(1, 1, 1);
        transform.localScale -= scale * Time.fixedDeltaTime * scaleSpeed; 
    }
}
