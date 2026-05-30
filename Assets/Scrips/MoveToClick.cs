
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


public class MoveToClick : MonoBehaviour
{
    private NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))

            {
                agent.SetDestination(hit.point);
            }
        }
    }


}




