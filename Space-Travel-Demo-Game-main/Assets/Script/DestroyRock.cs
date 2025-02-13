using UnityEngine;

public class DestroyRock:Rock
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
