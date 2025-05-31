using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A, D oder Pfeil links/rechts
        float moveZ = Input.GetAxis("Vertical");   // W, S oder Pfeil hoch/runter

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;
        transform.Translate(moveDirection, Space.World);
    }
}
