﻿using System;
using NoMoreLegs;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    
    [SerializeField]
    private Animator _animator;
    
    private MovableObject _movableObject;
    private PlayerHookController _playerHookController;
    private start_movement _startMovement;
    private Rigidbody2D _rb;
    
    private void Awake()
    {
        _playerHookController = GetComponent<PlayerHookController>();
        _startMovement = GetComponent<start_movement>();
        _playerHookController.enabled = false;
        _startMovement.enabled = true;
        _rb = GetComponent<Rigidbody2D>();
    }

    public void SetAnimationParameter(int hashedAnim, bool value)
    {
        _animator.SetBool(hashedAnim, value);
    }

    public void LoseLegs()
    {
        _playerHookController.enabled = true;
        _startMovement.enabled = false;
        _rb.freezeRotation = false;
    }
}
