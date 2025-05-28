using UnityEngine;

public class RocketMove : MonoBehaviour
{

    private Vector3 targetPosition;
    private Ray ray;
    private RaycastHit hit;

    private Vector3 direction;

    private int speed = 6;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        //direction = (targetPosition - transform.position).normalized;
    }
    private void Update()
    {
        GetTargetPos();
    }
    private void FixedUpdate()
    {
            rb.MovePosition(Vector3.forward * speed * Time.deltaTime);
    }

    private void GetTargetPos()
    {
        ray = GetCamera.instance.mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            targetPosition = hit.point;

            targetPosition.y = transform.position.y;

            transform.LookAt(targetPosition);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
