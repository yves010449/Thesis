using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class MobileInput : InputController
{
    [SerializeField]
    Joystick joystick;

    public Camera mainCamera;
    public Vector2 detectionBoxSize = new Vector2(0.2f, 0.2f);
    public float rotationAngle = 0;
    [SerializeField]
    LayerMask layer;


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseInput();
        }

        movementInput.x = joystick.Horizontal;
        movementInput.y = joystick.Vertical;

        movementInput.Normalize();
        playerController.Movement = movementInput;

        

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = touch.position;
            touchPosition.z = mainCamera.nearClipPlane;
            Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(touchPosition);

            Collider2D detectedCollider =
                Physics2D.OverlapBox(mouseWorldPosition, detectionBoxSize, rotationAngle, layer);

            if (detectedCollider != null) {
                InteractInput(detectedCollider);
            }

        }
    }

    public override Vector2 MovementInput() {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }


}
