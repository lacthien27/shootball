using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEditorInternal;

public class ReceiveSignalMouse : ThienMonoBehaviour
{
    public static ReceiveSignalMouse instance;
    public Vector3 mousePos = new  Vector3(0,0,0);
    public  int pressedMouse  = 0;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        ReceiveSignalMouse.instance =this;
    }

     private void Update() 
    {
        this.LoadSignalMousePos();
    
    }
    protected virtual void LoadSignalMousePos()
    {
        this.mousePos = Input.mousePosition;
        
    }

 
}
