using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerAgentNav : MonoBehaviour
{
    private NavMeshAgent agent;





    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Agent destination is based on mouse click/position

        RaycastHit hit;

        if (Mouse.current.leftButton.isPressed)
        {
            Vector3 mousePos = new Vector3(Mouse.current.position.x.ReadValue(),
                Mouse.current.position.y.ReadValue());
            if (Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hit, 100f))
            {
                agent.destination = hit.point;
            }
        }
    }
}
