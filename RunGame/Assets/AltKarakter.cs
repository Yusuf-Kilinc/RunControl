using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AltKarakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent Agent;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;

    }

    void LateUpdate()
    {
        Agent.SetDestination(Target.transform.position);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IgneliKutu"))
        {
            GameManager.AnlikKarakterSayisi--;
            gameObject.SetActive(false);

        }
    }
}
