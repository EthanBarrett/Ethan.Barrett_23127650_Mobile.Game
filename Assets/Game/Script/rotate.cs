using UnityEngine;
using UnityEngine.InputSystem;

public class rotate : MonoBehaviour
{
    public float rotationSpeed = 5f;
    Vector2 move;
    public float speed = 5f;


    // Update is called once per frame
    void Update()
    {

        Vector3 pivot = new Vector3(0, 0, move.y);

        if (pivot.magnitude > 0.1f)
        {
            pivot.Normalize();
            

            Quaternion rotation = Quaternion.LookRotation(pivot);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        }

    }
}
