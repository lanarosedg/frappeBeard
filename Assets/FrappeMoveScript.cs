using UnityEngine;

public class FrappeMoveScript : MonoBehaviour
{
    public float moveSpeed;
    //public float stopFrappePosition = -20;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -20)
        {
            Debug.Log("Frappe Destroyed");
            Destroy(gameObject);
        }
    }
}
