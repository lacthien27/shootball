using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveGunBarrel : ThienMonoBehaviour
{
    [SerializeField] public Vector2  velocity;


    


     private void FixedUpdate() 
        
     
    {
        this.LoadMovementBefore();
        this.SyncMove();    
    }


    protected virtual void LoadMovementBefore()
    {
        velocity.x = GameCtrl.instance.playerCtrl.transform.position.x;
        velocity.y = transform.parent.transform.position.y;
    }

    protected virtual void SyncMove()
    {
        transform.parent.position =this.velocity;
    }




}
