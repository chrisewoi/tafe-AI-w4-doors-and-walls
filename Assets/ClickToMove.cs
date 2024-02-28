using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(UnityEngine.AI.NavMeshAgent))]

public class ClickToMove : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
        //assign the NavMeshAgent to agent
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Debug.Log(hitInfo.ToString());
                agent.destination = hitInfo.point;
            }
        }
    }
}
