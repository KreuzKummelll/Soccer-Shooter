using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{

    Rigidbody rb;
    Vector3 startingPosition;

    [SerializeField] private VoidEvent onBallShoot;
    [SerializeField] private VoidEvent onBallReset;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
        ResetBall();
    }

    private void Update()
    {
        if ((transform.position.z > 10 || transform.position.z < startingPosition.z - 2) || (transform.position.x < -6 || transform.position.x > 6))
        {
            ResetBall();
        }

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var objecthitPonit = hit.point;
                onBallShoot.Raise();
                rb.AddForce(objecthitPonit * 10);
            }

        }
    }

    private void ResetBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startingPosition;
        onBallReset.Raise();
    }
}