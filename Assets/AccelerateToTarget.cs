using UnityEngine;

public class AccelerateToTarget : MonoBehaviour
{
    public Transform target;
    public float acceleration = 10f;
    public float maxSpeed = 10f;

    Vector3 velocity;

    static Vector3 ClampVector(Vector3 v, float max)
    {
        if (v.sqrMagnitude > max * max)
        {
            v = v.normalized * max;
        }
        return v;
    }

    void Update()
    {
        Vector3 position = transform.position;
        Vector3 direction = (target.position - position).normalized;
        Vector3 vChange = -velocity + direction * maxSpeed;
        Vector3 vAcceleration = vChange.normalized * acceleration;
        float deltaTime = Time.deltaTime;
        Vector3 newVelocity = ClampVector(velocity + vAcceleration * deltaTime, maxSpeed);
        position += 0.5f * (velocity + newVelocity) * deltaTime;
        velocity = newVelocity;
        transform.position = position;
    }
}
