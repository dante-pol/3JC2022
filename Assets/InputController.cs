using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static bool IsTouch => Input.touchCount > 0 ? true : false;
}
