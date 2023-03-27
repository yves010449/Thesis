using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotUI : MonoBehaviour
{



    [SerializeField]
    Animator animator;
    [SerializeField]
    ChangeScreen changeScreen;

    //public void Idle() {
    //    animator.SetBool("isTalking",true);
    //    changeScreen.SetDefaultParent();
    //}
    //public void BlankQuestion(Transform obj) {
    //    changeScreen.SetScreenParent(obj);
    //    animator.SetBool("isTalking", false);
    //}
    //public void BlankDebug() {
    //    animator.SetBool("isTalking", false);
    //    changeScreen.SetDefaultParent();
    //}
}
