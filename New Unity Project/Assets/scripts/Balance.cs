using UnityEngine;

public class Balance : MonoBehaviour
{

    public float targetBody;
    Rigidbody2D rb;
    public float force;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetBody, force * Time.deltaTime));
    }
}
