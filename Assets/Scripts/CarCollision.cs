using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public Playercarmovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if  (collision.collider.CompareTag("roadcar"))
        {
            movement.enabled = false;
        }
    }
}
