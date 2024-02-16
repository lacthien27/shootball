using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtrl : ThienMonoBehaviour
{
    [SerializeField] public BallImpact ballImpact;
    [SerializeField] public BallMovement ballMovement;

    [SerializeField] public BallDamSender ballDamSender;
    protected override  void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBallMovement();
        this.LoadBallImpact();
        this.LoadBallDamSender();
    }

    protected virtual void LoadBallDamSender()
    {
        if(this.ballDamSender!=null) return;
        this.ballDamSender =GetComponentInChildren<BallDamSender>();
        Debug.LogWarning(transform.name+" : LoadBallDamSender",gameObject);
    }

    protected virtual void LoadBallImpact()
    {
        if(this.ballImpact!=null) return;
        this.ballImpact =GetComponentInChildren<BallImpact>();
        Debug.LogWarning(transform.name+" : LoadBallImpact",gameObject);
    }

    protected virtual void  LoadBallMovement()
    {
        if(this.ballMovement !=null) return;
        this.ballMovement =GetComponentInChildren<BallMovement>();
        Debug.LogWarning(transform.name+" : LoadBallMovement",gameObject);


    }




}
