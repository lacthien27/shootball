using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ItemCtrl : ThienMonoBehaviour
{

    [SerializeField] public ItemDespawn itemDespawn;
    [SerializeField] public CircleCollider2D circleCollider2D;

    [SerializeField] public Transform model;

    [SerializeField] public ItemPickUp itemPickUp;

   

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemDespawn();
        this.LoadCollider2D();
        this.LoadModel();
        this.LoadItemPickUp();
    }

    protected virtual void LoadModel()
    {
    if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }

     protected virtual void LoadItemDespawn()
    {
        if(this.itemDespawn !=null) return;
        this.itemDespawn = GetComponentInChildren<ItemDespawn>();
        Debug.LogWarning(transform.name+" : LoadItemDespawn",gameObject);
    }

     protected virtual void LoadItemPickUp()
    {
        if(this.itemPickUp !=null) return;
        this.itemPickUp = GetComponentInChildren<ItemPickUp>();
        Debug.LogWarning(transform.name+" : LoadItemPickUp",gameObject);
    }


    
   

      protected virtual void LoadCollider2D()
    {
        if(this.circleCollider2D !=null) return;
        this.circleCollider2D =GetComponent<CircleCollider2D>();
        Debug.LogWarning(transform.name+" :LoadCircleCollider2D");
    }
   
}
