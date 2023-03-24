using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public Transform target;
    public Transform landingPoint;

    private float throwForce;
    private float upwardForce;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            CalculateThrowForce(rb);
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            Vector3 upward = transform.up;
            upward.Normalize();
            Vector3 force = (direction + upward * upwardForce) * throwForce;

            if (!float.IsNaN(force.x) && !float.IsNaN(force.y) && !float.IsNaN(force.z))
            {
                Debug.Log("Throwing object with force: " + force);
                rb.AddForce(force, ForceMode.Impulse);
            }
            else
            {
                Debug.LogError("Invalid throw force: " + force);
            }
        }
    }

    private void CalculateThrowForce(Rigidbody rb)
    {
        float gravity = Physics.gravity.magnitude;
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        float heightDifference = transform.position.y - landingPoint.position.y;
        float distanceToLandPoint = Vector3.Distance(target.position, landingPoint.position);

        float verticalVelocity = Mathf.Sqrt(2 * gravity * heightDifference);
        float timeToTarget = Mathf.Sqrt(2 * (distanceToTarget - heightDifference) / gravity);
        float horizontalVelocity = distanceToTarget / timeToTarget;

        throwForce = horizontalVelocity * rb.mass / timeToTarget;
        upwardForce = (verticalVelocity + gravity * timeToTarget / 2) * rb.mass / timeToTarget;
    }
}
