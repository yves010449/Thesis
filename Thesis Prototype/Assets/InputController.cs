using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class InputController : MonoBehaviour
{
   
    public PlayerController playerController;

    public  Vector2 movementInput;


    public abstract Vector2 MovementInput();

    public void PauseInput() {
        playerController.Pause();
    }
    public void LearningModuleInput() {
        playerController.LearningTerminal();
    }
    public void InteractInput(Collider2D collider) {
        playerController.Interact(collider);
    }


}
