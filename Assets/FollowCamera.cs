using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    // camera's position should be the same as the driver
    void LateUpdate() {
        transform.position = target.transform.position + new Vector3(0, 0, -10); 
    }
}
