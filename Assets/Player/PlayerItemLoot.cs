using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerItemLoot : ThienMonoBehaviour
{
    [SerializeField] public Rigidbody2D rb2D;
    [SerializeField] public BoxCollider2D boxCollider2D;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRb();
        this.LoadBoxCollider();
    }

    protected virtual void LoadRb()
    {
        if(this.rb2D !=null) return;
        this.rb2D= GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name+" :LoadRb",gameObject);
        this.rb2D.isKinematic = true;
        

    }

    protected virtual void LoadBoxCollider()
    {
         if(this.boxCollider2D !=null) return;
        this.boxCollider2D= GetComponent<BoxCollider2D>();
        Debug.LogWarning(transform.name+" :LoadBoxCollier2D",gameObject);
        this.boxCollider2D.size= new Vector3(0.8f,0.2f,1f);
        this.boxCollider2D.isTrigger= false;
    }

    private  void OnTriggerEnter2D(Collider2D other) 
    {
        ItemPickUp itemPickUp = other.GetComponentInChildren<ItemPickUp>();
        
        if(itemPickUp ==null) return;
        itemPickUp.isPickup =1;  //use delete item drop




    }


 


}
