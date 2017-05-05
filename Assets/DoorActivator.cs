using UnityEngine;
using System.Collections;

public class DoorActivator : MonoBehaviour
{

    public GameObject DoorGameObject;
    private Animator animator;

    void Awake()
    {
        animator = DoorGameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Open", false);
        }
    }
}