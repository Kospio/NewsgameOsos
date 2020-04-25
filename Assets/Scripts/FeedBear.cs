using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FeedBear : MonoBehaviour
{
    public float hungerSpeed;
    public Image imageComp;

    private void Start()
    {
        hungerSpeed /= 100; 
    }

    void Update()
    {
        imageComp.fillAmount -= hungerSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Seal")
        {
            imageComp.fillAmount += 0.3f;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "PolarBear")
        {
            imageComp.fillAmount += 0.5f;
            hungerSpeed += hungerSpeed;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Visión")
        {
            Debug.Log("Te veo chacho"); 
        }
    }
}
