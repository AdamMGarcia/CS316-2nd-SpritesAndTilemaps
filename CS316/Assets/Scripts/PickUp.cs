using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
     PointCounter pointCounter;

    // Start is called before the first frame update
    void Start()
    {
        pointCounter = GameObject.Find("Canvas").GetComponent<PointCounter>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") 
        {
            pointCounter.score ++;
            Destroy(gameObject);
        }
    }
}
