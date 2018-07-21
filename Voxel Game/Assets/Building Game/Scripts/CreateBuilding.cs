using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuilding : MonoBehaviour
{
    GameObject Block;
    public GameObject Storey;
    public GameObject Obj;
    Vector3 loc;
    public float x, y, z;
    // Use this for initialization
    void Start()
    {
        loc = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space)){
            Inst();
        }
    }

        void Inst(){ 
            loc.x = loc.x + x;
            loc.y = loc.y + y;
            loc.z = loc.z + z;
        Instantiate(Storey, loc, transform.rotation);
        Obj .transform.Translate(0,y ,0);





    }
    }


