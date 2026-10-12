using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Igrok>() != null) return;
        if (other.GetComponent<Missile>() != null) return;

        Vrag enemy = other.GetComponent<Vrag>();
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }

        Destroy(gameObject);
    }
}