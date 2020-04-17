using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Goal: MonoBehaviour
{

    [SerializeField] private VoidEvent OnGoalScored;
    [SerializeField] private FloatEvent OnPointsMade;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            OnGoalScored.Raise();
            float score = (other.transform.position.x + other.transform.position.y);

            OnPointsMade.Raise(score);
        }
    }

  
}
