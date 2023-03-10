using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorg : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    [ContextMenu(itemName: "Open")]
    public void Open()
    {
        _animator.SetTrigger(name:"Open");
    }
    [ContextMenu(itemName: "Close")]
    public void Close()
    {
        _animator.SetTrigger(name:"Close");
    }
}