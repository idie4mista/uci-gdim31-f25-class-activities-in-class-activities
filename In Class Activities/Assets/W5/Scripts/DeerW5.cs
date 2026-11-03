using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using System;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class Deerw5 : MonoBehaviour
{
    [SerializeField] public Transform target;
    public NavMeshAgent agent;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

   void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            
        }
       
    }
}