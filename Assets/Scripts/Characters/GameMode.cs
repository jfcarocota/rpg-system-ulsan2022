using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    List<Transform> party;
    Queue<Transform> partyQueue;

    // Start is called before the first frame update
    void Start()
    {
        partyQueue = new Queue<Transform>(party);
        partyQueue.Peek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetPartyLeader => partyQueue.Peek();
}
