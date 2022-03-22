using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Character, IHostile
{
    [SerializeField]
    protected int damage;
    [SerializeField]
    protected JobsOptions jobsOptions;
    [SerializeField]
    CharacterJob currentJob;

    void Start()
    {
        ChangeJob(jobsOptions);
        gameInputs.Gameplay.ChangeJob.performed += _=> ChangeJob(jobsOptions);
    }

    protected override void Movement()
    {
        base.Movement();
        transform.Translate(Axis.normalized.magnitude * Vector3.forward * moveSpeed * Time.deltaTime);
        FacingDirection();
    }

    protected void LateUpdate()
    {
        
    }

    public void Attack()
    {

    }

    public int GetDamage()
    {
        return damage;
    }

    void ChangeJob(JobsOptions job)
    {
        if(currentJob)
        {
            Destroy(currentJob);
        }
        switch(job)
        {
            case JobsOptions.MAGE:
            currentJob = gameObject.AddComponent<Mage>();
            break;
            case JobsOptions.ARCHER:
            currentJob = gameObject.AddComponent<Archer>();
            break;
            case JobsOptions.WARRIOR:
            currentJob = gameObject.AddComponent<Warrior>();
            break;
        }
    }
}
