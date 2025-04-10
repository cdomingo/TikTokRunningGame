using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    private float clampX = 2.75f;
    private Vector3 leftClamp;
    private Vector3 rightClamp;
    
    [SerializeField] private float moveSpeed = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftClamp = new Vector3(-clampX, transform.position.y, transform.position.z);
        rightClamp = new Vector3(clampX, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > clampX)
        {
            transform.position = rightClamp;
        }
        if (transform.position.x < -clampX)
        {
            transform.position = leftClamp;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
    }
}
