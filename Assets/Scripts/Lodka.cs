using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 50f;
    private Vector3 startPos;
    private float timeOffset = 0f;
    private bool isActive = false;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (isActive)
        {
            timeOffset += Time.deltaTime * speed;
            float offset = Mathf.Sin(timeOffset) * distance;
            transform.position = startPos + new Vector3(offset, 0, 90);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            isActive = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
            isActive = false;
        }
    }
}