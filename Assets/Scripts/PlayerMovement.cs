using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 2f;
    Vector3 toStop;
    public GameObject invisibleColl;
    GameObject myInvisibleColl;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.touchCount > 0) //Esto es para el touch
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchpostion = Camera.main.ScreenToWorldPoint(touch.position);
            touchpostion.z = 0f;
            transform.position = touchpostion;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (myInvisibleColl != null) { Destroy(myInvisibleColl); }
            Vector3 mousePos = Input.mousePosition;
            Vector3 mouseInScreen = Camera.main.ScreenToWorldPoint(mousePos);
            mouseInScreen.z = 0f;
            //this.transform.position = mouseInScreen;
            rb.velocity = (mouseInScreen - this.transform.position).normalized * speed;
            this.transform.right = new Vector3(this.transform.position.x - mouseInScreen.x, this.transform.position.y - mouseInScreen.y, 0f);
            toStop = mouseInScreen;
            myInvisibleColl = Instantiate(invisibleColl);
            myInvisibleColl.transform.position = mouseInScreen;
        }
        //rb.velocity = new Vector2(0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == myInvisibleColl)
        {
            rb.velocity = new Vector2(0, 0);
            Destroy(collision.gameObject);
        }
    }
}
