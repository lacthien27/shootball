using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class ItemPickUp : ThienMonoBehaviour
{
        [SerializeField] public int isPickup =0;

    [SerializeField] ItemCtrl itemCtrl;
    protected override void LoadComponents()
    {
                base.LoadComponents();
                this.LoadItemCtrl();

    }

       protected virtual void LoadItemCtrl()
    {
        if(this.itemCtrl !=null) return;
        this.itemCtrl = transform.parent.GetComponent<ItemCtrl>();
        Debug.LogWarning(transform.name+" : LoadItemCtrl",gameObject);
    }











}
