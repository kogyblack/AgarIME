﻿using UnityEngine;

[RequireComponent(typeof(Size))]
public class Food : MonoBehaviour {
    void Start() {
        GetComponent<Size>().OnGetEaten = OnGetEaten;
    }

    void OnEnable() {
        float x = Networking.instance.arenaSize.x;
        float y = Networking.instance.arenaSize.y;
        float r = (transform.position.x + x) / (2 * x);
        float g = (transform.position.y + y) / (2 * y);
        float b = transform.position.z;
        SetColor(new Color(r, g, b));

        transform.position = (Vector2) transform.position;
    }

    public void SetColor(Color color) {
        GetComponent<SpriteRenderer>().color = color;
    }

    void OnGetEaten() {
        //Network.Destroy(this.gameObject);
        Networking.instance.foodCount--;
    }
}
