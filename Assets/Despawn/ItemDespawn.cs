using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDespawn : Despawn
{
    [SerializeField] ItemCtrl itemCtrl;

    [SerializeField] public List<string> nameItems;

    [SerializeField] public List<GameObject> items;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemCtrl();
    }
    protected override bool   CanDespawn()
    {
        if(this.itemCtrl.itemPickUp.isPickup == 1) 
        {
            this.itemCtrl.itemPickUp.isPickup=0;
            
            this.LoadCreateEffectItem();
            
            
            return true;
            
        }
        return false;

        
    }

    protected virtual void LoadCreateEffectItem()
    {

         foreach ( Transform item in EffectItemSpawner.instance.prefabs)
        {
           nameItems.Add(item.name); 

           foreach(string nameItem in nameItems)
           {
            if(transform.parent.name==nameItem)
            {
                EffectItemSpawner.instance.turnOnObject( item.gameObject);

            }
            
           }          
        }

        
    }

     protected virtual void LoadItemCtrl()
    {
        if(this.itemCtrl !=null) return;
        this.itemCtrl = transform.parent.GetComponent<ItemCtrl>();
        Debug.LogWarning(transform.name+" : LoadItemCtrl",gameObject);
    }

   
}

