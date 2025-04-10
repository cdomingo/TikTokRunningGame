using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentFollowObject : MonoBehaviour
{
    NavMeshAgent m_Agent;
    GameObject m_Target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        m_Target = GameObject.Find("NavTarget");
        m_Agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetDestinationX(m_Target.transform.position.x);
    }

    private void SetDestinationX(float x)
    {
        Vector3 targetPosition = new Vector3(x, transform.position.y, transform.position.z);
        m_Agent.destination = targetPosition;
    }
}
