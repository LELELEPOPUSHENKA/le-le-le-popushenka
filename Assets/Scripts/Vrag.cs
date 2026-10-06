using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrag : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int damag;
    public float detectionRange = 35f;
    public float stopRange = 1.5f;
    void Update()
    {
        if (target == null) return;

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance <= detectionRange && distance > stopRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.LookAt(target.position);
        }
        else if (distance <= stopRange)
        {
            transform.LookAt(target.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Igrok player = other.GetComponent<Igrok>();
        player.TakeDamage(damag);
    }
}
