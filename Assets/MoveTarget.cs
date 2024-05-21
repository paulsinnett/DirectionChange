using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(Vector3.ClampMagnitude(new Vector3(h, 0, v), 1f) * speed * Time.deltaTime);
    }
}
