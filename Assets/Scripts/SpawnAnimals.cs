using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] Animals;
    public GameObject emptyColl;
    public GameObject scenarioRef;
    GameObject myAnimal;
    GameObject terrain;
    BoxCollider2D edgecoll;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        terrain = GameObject.FindGameObjectWithTag("Floor");
        edgecoll = emptyColl.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //myEmptyColl.transform.position = this.transform.position;
        Scenario apScript = scenarioRef.GetComponent<Scenario>();
        edgecoll.size -= new Vector2(edgecoll.size.x,edgecoll.size.y) * apScript.scaleSpeed * Time.deltaTime;
        timer += 1f * Time.deltaTime;
        if (timer > 5f)
        {
            terrain = GameObject.FindGameObjectWithTag("Floor");
            myAnimal = Instantiate(Animals[Random.Range(0, Animals.Length)]);
            //myAnimal.transform.position = new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(emptyColl.transform.localScale.x, 0)).x), Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0,0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, emptyColl.transform.localScale.y)).y), 0f); //:)))))))))))))))))
            myAnimal.transform.position = new Vector3(Random.Range(- edgecoll.size.x / 2, edgecoll.size.x / 2), Random.Range(- edgecoll.size.y / 2, edgecoll.size.y / 2), 0f);
            timer = 0f;
        }
    }
}
