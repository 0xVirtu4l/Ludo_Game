using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    [Header("Routes")]
    public Route commonRoute;//OUTER Route
    public Route finalRoute;// Final Route

    public List<Node> fullRoute = new List<Node>();
    [Header("NODES")]
    public Node startNode;

    public Node baseNode;// NODE IN HOME BASE
    public Node currentNode;
    public Node goalNode;

    int routePosition;
    int startNodeIndex;

    int steps;
    int doneSteps;

    [Header("BOOLS")]//Bools
    public bool isOut;
    bool isMoving;

    bool hasTurn;// Human Input 



    [Header("SELECTOR")]
    public GameObject selector;


    void start()
    {

        startNodeIndex = commonRoute.RequestPosition(startNode.gameObject.transform);
        CreateFullRoute();
    }

    void CreateFullRoute()
    {
        for (int i = 0; i < commonRoute.childNodeList.Count; i++)
        {
            int tempPos = startNodeIndex + i;
            tempPos %= commonRoute.childNodeList.Count;

            fullRoute.Add(commonRoute.childNodeList[tempPos].GetComponent<Node>());
        }

        for (int i = 0; i < finalRoute.childNodeList.Count; i++)
        {
            fullRoute.Add(finalRoute.childNodeList[i].GetComponent<Node>());
        }
    }

    

}
