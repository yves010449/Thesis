using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PCInput : InputController
{

    public Camera mainCamera;
    public Vector2 detectionBoxSize = new Vector2(0.2f, 0.2f);
    public float rotationAngle = 0;
    [SerializeField]
    LayerMask layer;

     void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseInput();
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            //InteractInput();
        }
        if (Input.GetKeyDown(KeyCode.Tab)) {
            LearningModuleInput();
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

        Collider2D detectedCollider =
            Physics2D.OverlapBox(mouseWorldPosition, detectionBoxSize, rotationAngle,layer);

        if (Input.GetMouseButtonDown(0)) {
            if(detectedCollider != null) {
                InteractInput(detectedCollider);
            }
            
        }

        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        movementInput.Normalize();
        playerController.OnMovement?.Invoke(movementInput);
    }

    public override Vector2 MovementInput() {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
