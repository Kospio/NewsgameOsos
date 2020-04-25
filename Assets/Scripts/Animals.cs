using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Animals : MonoBehaviour
{
    public bool isSeal;
    public bool isPolarBear;
    public float speed = 1f;
    public EdgeCollider2D suelo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + speed * Time.deltaTime);
        transform.position += transform.up * Time.deltaTime * speed;

        if (isSeal)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Floor" || collision.gameObject.tag == "Player")
        {
            /*Debug.Log("Estoy fuera");
            transform.position = new Vector3(Random.Range(-edgecoll.size.x / 2, edgecoll.size.x / 2), Random.Range(-edgecoll.size.y / 2, edgecoll.size.y / 2), 0f); //:)))))))))))))))))*/
        }
        if (collision.gameObject.tag == "Floor")
        {
            
            //transform.Rotate(0, 0, 180);
            transform.Rotate(0f, 0f, Random.Range(-45 +180, 45 +180));
            //transform.right = new Vector2(transform.localPosition.x, transform.localPosition.y + 1);
            //speed *= -1;
            transform.right *= 1;
        }

    }
}
