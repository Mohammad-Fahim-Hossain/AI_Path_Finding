using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    
    public GameObject wpManager;
    GameObject[] wps;
    UnityEngine.AI.NavMeshAgent Agent;
   



    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WayPoinManager>().waypoints;
        Agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    public void GoToHeli() {
        Agent.SetDestination(wps[1].transform.position);
        //g.AStar(CurrentNode, wps[1]);
       // currentWP = 0;
    }

    public void GoToRuin() {
        Agent.SetDestination(wps[6].transform.position);
        // g.AStar(CurrentNode, wps[6]);
        // currentWP = 0;
    }
    public void GoToHil()
    {
        Agent.SetDestination(wps[2].transform.position);
        //   g.AStar(CurrentNode, wps[2]);
        // currentWP = 0;
    }


    void LateUpdate()
    {

        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
