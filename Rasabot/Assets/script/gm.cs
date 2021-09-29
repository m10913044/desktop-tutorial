//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class gm : MonoBehaviour
{
    public Transform School;
    public Transform Park; 
    public Transform Library; 
    public GameObject CarControl; 
    public void Start() { 
        CarControl = GameObject.Find("yunbot"); 
    }
    public void GoSchool() { 
        CarControl.GetComponent<Pathfinding.AIDestinationSetter>().target = School.transform; 
    }
    public void GoPark() { 
        CarControl.GetComponent<Pathfinding.AIDestinationSetter>().target = Park.transform; 
    }
    public void GoLibrary() { 
        CarControl.GetComponent<Pathfinding.AIDestinationSetter>().target = Library.transform; 
    }
}
