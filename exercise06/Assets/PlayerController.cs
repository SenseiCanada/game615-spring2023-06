using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public GameManager gm;
    public NavMeshAgent nma;

    // Start is called before the first frame update
    void Start()
    {
        nma = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      //if(Input.GetKeyDown(KeyCode.Space))
       // {
           // gameObject.transform.localScale = Vector3f.one;
       // }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collect"))
        {
            Destroy(other.gameObject);
            gm.IncrementPlayerScore();

        }
    }
}
