using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemMove : ThienMonoBehaviour
{

    [SerializeField] public float  speed = 4f;
    [SerializeField] public float  speedRot  = 10f;

    [SerializeField] public ItemCtrl itemCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemCtrl();
    }

    protected virtual void LoadItemCtrl()
    {
         if(this.itemCtrl !=null) return;
        this.itemCtrl= transform.parent.GetComponent<ItemCtrl>();
        Debug.LogWarning(transform.name+" :LoadItemCtrl",gameObject);
    }
    void Update()
    {
        this.LoadMove();
        this.Rotating();
    }
    protected virtual void LoadMove()
    {
        transform.parent.Translate(Vector2.down*this.speed*Time.deltaTime);
    }  
    protected virtual void Rotating()
    {
        this.itemCtrl.model.transform.Rotate( new Vector3(0,0,1),speedRot*Time.deltaTime);
    }
    

    
}
