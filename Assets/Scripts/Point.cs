using UnityEngine;
public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            int newRandom = Random.Range(1, 6);
            while (newRandom == other.GetComponent<NavMash>().randomNum)
            {
                newRandom = Random.Range(1, 6);
            }
            other.GetComponent<NavMash>().randomNum = newRandom;
        }
    }

}
