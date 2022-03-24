using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maggie : Hero
{
    protected override void Movement()
    {
        //if(gamemanager,.insta.gamemode.GetLeader.gameObject == gameObject)
        base.Movement();
        anim.SetFloat("Move", MovementValue);
        /*if(ImLeader || (!ImLeader && CanMoveToleader))
        {
            anim.SetFloat("Move", Mathf.Abs(Axis.magnitude));
        }*/
    }
}
