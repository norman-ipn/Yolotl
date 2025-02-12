﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class allows us to verify is the player is grounded or not
/// without using a OnCollision fuction
/// 
/// </summary>

public class Feet : MonoBehaviour {
	// Box Size than it will check if the palyer is grounded or nor
	private float feetBoxWidth = 0.9f;
	private float feetBoxHeight = 0.04f;
	// Position where the box is
	private Transform feetPosition;
	/* 
	 * Layer where it will compare if the box is overlaped with the
	 * ground or not
	*/
	public LayerMask whatIsGround;

	/*
	 * This method draws a box in order to guide us about it size
	 * otherwise we will not be able to see what is overlaping
	 * and what is not.
	*/
	public void OnDrawGizmos(){
		feetPosition = GetComponent<Transform> ();
		Gizmos.DrawWireCube (feetPosition.position, new Vector3(feetBoxWidth, feetBoxHeight, 0f));
	}		

	/*
	 * Checks if the box is overlaping with what is on the laye Ground
	*/
	public bool IsOverlaping(){
		feetPosition = GetComponent<Transform> ();
		return Physics2D.OverlapBox (new Vector2(feetPosition.position.x, feetPosition.position.y), new Vector2(feetBoxWidth, feetBoxHeight), 360.0f, whatIsGround);
	}
}
