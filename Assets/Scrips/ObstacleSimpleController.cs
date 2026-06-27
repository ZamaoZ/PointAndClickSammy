using UnityEngine;

public class ObstacleSimpleController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float speedRotation;
    [SerializeField] private GameObject obstacleObj;
    [SerializeField] private Vector3 starPosition;
    private Vector3 currTargetPosition;

    void Start()
    {
        starPosition = obstacleObj.transform.position;
        currTargetPosition = target.position;
    }

    void Update()
    {
        obstacleObj.transform.Rotate(Vector3.up, speedRotation * Time.deltaTime);
        if (obstacleObj.transform.position != currTargetPosition)
        {
            obstacleObj.transform.position = Vector3.MoveTowards(obstacleObj.transform.position, currTargetPosition, speed * Time.deltaTime);

        }

        else
        {
            if (currTargetPosition == target.position)
            {
                currTargetPosition = starPosition;
            }
            else if (currTargetPosition == starPosition)
            {
                currTargetPosition = target.position;
            }


        }
    }


}
