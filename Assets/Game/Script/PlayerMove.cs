using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Vector2 move;
    public float speed = 5f;


    public void InputPlayer(InputAction.CallbackContext _context)
    {
        move = _context.ReadValue<Vector2>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 Player = new Vector3(move.x, 0, move.y);
        Player.Normalize();
        transform.Translate(speed * Player * Time.deltaTime);

       // if(Player != Vector3.zero)
     //   {
       //     float angle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;
       //     transform.rotation = Quaternion.Euler(0, angle, 0);
       // }
        

    }
}
