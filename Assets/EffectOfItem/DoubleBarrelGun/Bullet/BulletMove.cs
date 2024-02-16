using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class BulletMove : ThienMonoBehaviour
{
    
    [SerializeField] public  BulletSpawn  bulletSpawn;

    [SerializeField] public float  speed= 2f;

    

    void Update()
    {
                this.LoadSyncMove();

        this.LoadMove();
    }


    protected  virtual void LoadMove()
    {
       transform.Translate(new Vector2(0, 1) * this.speed * Time.deltaTime);
    }

    protected virtual void LoadSyncMove()
    {
        transform.parent.position= transform.position;
    }

}
