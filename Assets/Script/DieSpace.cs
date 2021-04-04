
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Chel")
        {
            Debug.Log("asdfsaf");
            other.transform.position = respawn.transform.position;
        }
    }
}