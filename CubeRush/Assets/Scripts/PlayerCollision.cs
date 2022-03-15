using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;
    public Rigidbody rb;

   void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="Obstacle")
        {
            rb.AddForce(0, 10f, 0, ForceMode.VelocityChange);
            Time.timeScale = 0.6f;
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
