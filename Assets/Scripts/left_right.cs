using UnityEngine;

public class left_right : MonoBehaviour
{
    public GameObject ob;

    void Update()
    {
        int x = Random.Range(-9, 0);
        if (transform.position.x < -335)
        {
            transform.position = transform.position + new Vector3(-x, 0, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(x, 0, 0);
        }
    }
}
