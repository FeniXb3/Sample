using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpStrength = 500;

    public float moveSpeed = 300;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump!");
            rb.AddForce(Vector3.up * jumpStrength);
        }

        float horizontalDirection = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector3(horizontalDirection * moveSpeed, rb.linearVelocity.y, rb.linearVelocity.z);
    }
}
