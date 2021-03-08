using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BadGuy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
