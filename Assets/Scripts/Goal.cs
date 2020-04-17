using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Goal: MonoBehaviour
{

    [SerializeField] private VoidEvent OnGoalScored;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            OnGoalScored.Raise();
        }
    }

  
}
