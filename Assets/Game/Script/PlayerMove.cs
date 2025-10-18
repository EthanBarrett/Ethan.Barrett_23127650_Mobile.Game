using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Vector2 move;
    public float speed = 5f;
    public float rotationSpeed = 5f;

    public void InputPlayer(InputAction.CallbackContext _context)
    {
        move = _context.ReadValue<Vector2>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 Player = new Vector3(move.x, 0, move.y);


            if (Player.magnitude > 0.1f)
            {
                Player.Normalize();
                transform.Translate(speed * Player * Time.deltaTime, Space.World);

                Quaternion rotation = Quaternion.LookRotation(Player);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

            }
       
        

    }
}
