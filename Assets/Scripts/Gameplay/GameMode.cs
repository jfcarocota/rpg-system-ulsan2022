using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    List<Transform> party;
    Queue<Transform> partyQueue;

    // Start is called before the first frame update
    IEnumerator Start()
    {

        while(true)
        {
            if(Gamemanager.Instance)
            {
                partyQueue = new Queue<Transform>(party);
                //partyQueue.Peek();
                Gamemanager.Instance.CurrentGameMode = this;
                break;
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetPartyLeader => partyQueue.Peek();

    public bool CompareToLeader(Transform leader) => GetPartyLeader.Equals(leader);
}
