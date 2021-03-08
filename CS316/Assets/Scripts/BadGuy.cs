using UnityEngine;
using UnityEngine.SceneManagement;

public class BadGuy : MonoBehaviour
{

    public bool goForward = false;

    public float moveSpeed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        // move back and forth between point A and B
        // move forward
        if (goForward)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        } 
        else // go backward
        {
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D otherGuy) 
    {
        if (otherGuy.gameObject.tag == "Player") 
        {
            // we COULD take away player health, 
            // or just make it a one-hit-kill by reloading the scene

            // use SceneManager to load the CURRENT scene again (a reset)
            // the LoadScene function just wants a NUMBER of the scene to load
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("We hit SOMETHING");
        if (other.gameObject.tag == "pointA") 
        {
            Debug.Log("We hit pointA");
            goForward = false;
        }
        else if (other.gameObject.tag == "pointB")
        {
            Debug.Log("We hit pointB");
            goForward = true;
        }
    }
}
