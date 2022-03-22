using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
public class Character : LivingObject
{
    [SerializeField]
    protected Lore lore;
    [SerializeField, Range(0.1f, 15f)]
    protected float moveSpeed = 5f;
    protected GameInputs gameInputs;
    protected Animator anim;

    void Awake()
    {
        gameInputs = new GameInputs();
        anim = GetComponent<Animator>();
    }

    void OnEnable()
    {
        gameInputs.Enable();
    }

    void OnDisable()
    {
        gameInputs.Disable();
    }

    protected void Update()
    {
        Movement();
    }
    protected virtual void Movement ()
    {
        
    }

    protected void FacingDirection()
    {
        if(IsMoving)
        {
            transform.rotation = RotationDirection;
        }
    }

    

    Quaternion RotationDirection => Quaternion.LookRotation(Axis);

    protected bool IsMoving => Axis != Vector3.zero;

    protected Vector3 Axis => new Vector3(gameInputs.Gameplay.Horizontal.ReadValue<float>(), 0f, gameInputs.Gameplay.Vertical.ReadValue<float>());
}
