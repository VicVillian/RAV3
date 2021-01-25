using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footSteps : MonoBehaviour
{

    [FMODUnity.EventRef] public string inputsound = "event:/Player/footSteps"; public bool playerIsMoving; public float walkingSpeed; float horizontal; float vertical; void Update() { Debug.Log(playerIsMoving); if (Input.GetKey(KeyCode.A)) playerIsMoving = true; if (Input.GetKey(KeyCode.D)) playerIsMoving = true; if (Input.GetKey(KeyCode.W)) playerIsMoving = true; if (Input.GetKey(KeyCode.S)) playerIsMoving = true;
        else playerIsMoving = false; }

   

    void FixedUpdate()
    {

    }

    void FootStepsAudio() { if (playerIsMoving == true) {
            FMODUnity.RuntimeManager.PlayOneShot(inputsound);
        }
    }

    void Start() {

        FootStepsAudio(); 
        // InvokeRepeating("FootStepsAudio", 0, walkingSpeed);
    }
    void OnDisable()
    {
        playerIsMoving = false;

    }
}