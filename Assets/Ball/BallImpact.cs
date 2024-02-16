using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;


[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class BallImpact : ThienMonoBehaviour
{
    [SerializeField] public BallCtrl ballCtrl;
   [SerializeField] public Rigidbody2D rb2D;
    [SerializeField] public CircleCollider2D  circleCollider2D; 

    [SerializeField] public Vector2 reflectionVector;

    [SerializeField]  public int  Impacted =0;


    [SerializeField] protected float ranRotation;
    
    
   
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRb2D();
        this.LoadCircleCollider2D();
        this.LoadBallCtrl();
    }
    protected virtual void LoadBallCtrl()
    {
        if(this.ballCtrl!=null) return;
        this.ballCtrl =GetComponentInParent<BallCtrl>();
        Debug.LogWarning(transform.name+ ": LoadBallCtrl",gameObject);
    }
    protected virtual void LoadRb2D()
    {
        GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        if(this.rb2D !=null) return;
        this.rb2D= GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name+" :LoadRb",gameObject);
    }

    protected virtual void LoadCircleCollider2D()
    {
         if(this.circleCollider2D !=null) return;
        this.circleCollider2D= GetComponent<CircleCollider2D>();
        Debug.LogWarning(transform.name+" :LoadSphereCollider2D",gameObject);
        this.circleCollider2D.radius=0.28f;
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {       
            this.ballCtrl.ballDamSender.LoadDamDeliver(other.transform.parent);    
    } 
    protected virtual  void OnCollisionEnter2D(Collision2D other) 
    {
        RandomRotation();

        Vector2  incomingVector = gameObject.transform.parent.position.normalized;
        Vector2 normalVector = other.contacts[0].normal;  //get vector normal
        Vector2 reflectionVector = Vector2.Reflect(incomingVector,normalVector);

        transform.rotation= Quaternion.LookRotation(Vector3.forward, reflectionVector);

        this.Impacted=1;                        //check ball collide with the ball

        this.transform.parent.rotation = transform.rotation; // only change  direction when impact     

        this.ballCtrl.ballDamSender.LoadDamDeliver(other.transform.parent);
   }
     
    protected virtual void RandomRotation()
    {
        ranRotation = Random.Range(3,6f);
    }
}
    
    

        

