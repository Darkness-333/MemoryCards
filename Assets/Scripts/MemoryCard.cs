using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour {
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
    public int id { get; private set; }

    private Animator animator;
    private bool isRevealed = false;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void OnMouseEnter() {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    private void OnMouseExit() {
        transform.localScale = Vector3.one;
    }

    private void OnMouseDown() {
        if (!isRevealed && controller.canReveal) {
            controller.CardRevealed(this);
            isRevealed = true;
            animator.SetFloat("Speed", 1);
            animator.Play("CardRotation",0,0);
        }
    }

    public void Unreveal() {
        isRevealed = false;
        animator.SetFloat("Speed", -1f);
        animator.Play("CardRotation", 0, 1f);

    }

    public void SetCard(int id, Sprite image) {
        this.id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }


}
