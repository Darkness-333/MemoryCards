using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {
    [SerializeField] private SceneController sceneController;

    public Color baseColor = Color.blue;
    public Color highlightColor = Color.cyan;
    
    private SpriteRenderer button;

    private void Start() {
        button = GetComponent<SpriteRenderer>();
        button.color = baseColor;
    }

    private void OnMouseEnter() {
        button.color = highlightColor;
    }

    private void OnMouseExit() {
        button.color = baseColor;
    }

    private void OnMouseDown() {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    private void OnMouseUp() {
        transform.localScale = Vector3.one;
        sceneController.Restart();
    }
}
