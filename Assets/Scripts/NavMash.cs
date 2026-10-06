using UnityEngine;
using UnityEngine.AI;
public class NavMash : MonoBehaviour
{
    private NavMeshAgent navMashAgent;
    public int randomNum = 1;
    public GameObject cp1;
    public GameObject cp2;
    public GameObject cp3;
    public GameObject cp4;
    public GameObject cp5;

    void Start()
    {
        navMashAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (randomNum == 1)
        {
            navMashAgent.SetDestination(cp1.transform.position);
        }
        else if (randomNum == 2)
        {
            navMashAgent.SetDestination(cp2.transform.position);
        }
        else if (randomNum == 3)
        {
            navMashAgent.SetDestination(cp3.transform.position);
        }
        else if (randomNum == 4)
        {
            navMashAgent.SetDestination(cp4.transform.position);
        }
        else if (randomNum == 5)
        {
            navMashAgent.SetDestination(cp5.transform.position);
        }
    }
}
