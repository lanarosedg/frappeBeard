using UnityEngine;

public class MiddleFrappeScript : MonoBehaviour
{
    public LogicManagerScript logic;
    void Start()
    {
        logic = GameObject.Find("Logic Manager").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
