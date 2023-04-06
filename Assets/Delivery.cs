using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage = false;
    private float delay = 0.2f;
    private Color32 hasPackageColor = new Color32(255, 0, 0, 255);
    private Color32 noPackageColor = new Color32(255, 255, 255, 255);
    private SpriteRenderer spriterenderer;

    private void Start() {
        spriterenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("oucH!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            // pick up package
            hasPackage = true;
            spriterenderer.color = hasPackageColor;
            Destroy(other.gameObject, delay);
        }
        else if (other.tag == "Customer" && hasPackage) {
            // deliver package
            hasPackage = false;
            spriterenderer.color = noPackageColor;
            Destroy(other.gameObject, delay);
        }
    }
} 
