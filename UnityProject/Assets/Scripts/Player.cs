using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontal, 0f, vertical) * speed * 50f * Time.deltaTime;
    }
}
